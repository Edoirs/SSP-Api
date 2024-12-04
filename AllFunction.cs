using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Quartz.Impl;
using Quartz.Spi;
using Quartz;
using SelfPortalAPi.Model;
using SelfPortalAPi.Models;
using SelfPortalAPi.UnitOfWork;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;
using Exception = System.Exception;
using static SelfPortalAPi.BackgroundJobs;
using System.Net;
using Microsoft.Extensions.Options;
using ClosedXML.Excel;
using OfficeOpenXml.Table;
using SelfPortalAPi.Models.ResModel;
using SelfPortalAPi.Models.Vm;
using RestSharp;


namespace SelfPortalAPi
{
    public class AllFunction
    {
        public void ConfigureServices(WebApplicationBuilder builder)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var services = builder.Services;
            // QuestPDF.Settings.License = LicenseType.Community;

            string? conn = builder.Configuration.GetConnectionString("SelfServiceConnect");
            string? connII = builder.Configuration.GetConnectionString("EirsContext");
            string? connIII = builder.Configuration.GetConnectionString("ERASContext");
            //string? connIV = builder.Configuration.GetConnectionString("PayeConnection");
            services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

            string? TaxOfficeJobTime = builder.Configuration.GetConnectionString("TaxOfficeJob");

            services.AddAutoMapper(typeof(Program));
            services.AddEndpointsApiExplorer();
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration.GetSection("JWT:ValidIssuer").Value,
                    ValidAudience = builder.Configuration.GetSection("JWT:ValidAudience").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:Secret").Value))
                };
            });

            services.AddDbContext<SelfServiceConnect>(opt => opt.UseSqlServer(conn));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ISelfRepository<>), typeof(SelfRepository<>));
            services.AddScoped<IValidator<TokenRequest>, TokenRequestValidator>();
            services.AddScoped<IIndividualRepository, IndividualRepository>();
            services.AddScoped<IUtilityRepository, UtilityRepository>();
            services.AddScoped<IPhaseIIRepo, PhaseIIRepo>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHealthChecks()
                .AddSqlServer(connIII, name: "ErasContext")
                .AddSqlServer(connII, name: "ApiDbContext")
                .AddSqlServer(conn, name: "SelfServiceConnect");
            // .AddSqlServer(connIV, name: "PinscherSpikeContext");
            services.AddScoped<PhaseBenchMark>();


            services.AddCors();
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "Self Service API",
                    Description = "WebAPI"
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Bearer Authentication with JWT Token",
                    Type = SecuritySchemeType.Http
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List < string > ()
        }
    });
            });
        }
        public class QuartzHostedService : IHostedService
        {
            private readonly ISchedulerFactory _schedulerFactory;
            private readonly IJobFactory _jobFactory;
            private readonly IEnumerable<JobSchedule> _jobSchedules;
            public IScheduler Scheduler { get; set; }

            public QuartzHostedService(
                ISchedulerFactory schedulerFactory,
                IJobFactory jobFactory,
                IEnumerable<JobSchedule> jobSchedules)
            {
                _schedulerFactory = schedulerFactory;
                _jobFactory = jobFactory;
                _jobSchedules = jobSchedules;
            }

            public async Task StartAsync(CancellationToken cancellationToken)
            {
                Scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
                Scheduler.JobFactory = _jobFactory;

                foreach (var jobSchedule in _jobSchedules)
                {
                    var job = CreateJob(jobSchedule);
                    var trigger = CreateTrigger(jobSchedule);

                    await Scheduler.ScheduleJob(job, trigger, cancellationToken);
                }

                await Scheduler.Start(cancellationToken);
            }

            public async Task StopAsync(CancellationToken cancellationToken)
            {
                await Scheduler?.Shutdown(cancellationToken);
            }

            private IJobDetail CreateJob(JobSchedule schedule)
            {
                var jobType = schedule.JobType;
                return JobBuilder
                    .Create(jobType)
                    .WithIdentity(jobType.FullName)
                    .WithDescription(jobType.Name)
                    .Build();
            }

            private ITrigger CreateTrigger(JobSchedule schedule)
            {
                return TriggerBuilder
                    .Create()
                    .WithIdentity($"{schedule.JobType.FullName}.trigger")
                    .WithCronSchedule(schedule.CronExpression)
                    .WithDescription(schedule.CronExpression)
                    .Build();
            }
        }
        public class SingletonJobFactory : IJobFactory
        {
            private readonly IServiceProvider _serviceProvider;

            public SingletonJobFactory(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
            }

            public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
            {
                return _serviceProvider.GetService(bundle.JobDetail.JobType) as IJob;
            }

            public void ReturnJob(IJob job) { }
        }
        public string GetToken(string url, string user, string password)
        {
            string URI = url + "Account/Login";
            string myParameters = "UserName=" + user + "&Password=" + password + "&grant_type=password";
            string BearerToken = "";
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                BearerToken = wc.UploadString(URI, myParameters);
            }

            Token TokenObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(BearerToken);
            return TokenObj.access_token;
        }
        public class Base64FormFile : IFormFile
        {
            private readonly byte[] _fileContent;
            private readonly string _fileName;

            public Base64FormFile(string base64String, string fileName)
            {
                _fileContent = Convert.FromBase64String(base64String);
                _fileName = fileName;
            }

            public string ContentDisposition => $"form-data; name={Name}; filename={FileName}";

            public string ContentType => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            public IHeaderDictionary Headers => new HeaderDictionary();

            public long Length => _fileContent.Length;

            public string Name => "file";

            public string FileName => _fileName;

            public Stream OpenReadStream()
            {
                return new MemoryStream(_fileContent);
            }

            public async Task CopyToAsync(Stream target, System.Threading.CancellationToken cancellationToken = default)
            {
                await target.WriteAsync(_fileContent, 0, _fileContent.Length, cancellationToken);
            }

            //public void CopyTo(Stream target)
            //{
            //    throw new NotImplementedException();
            //}

            public void CopyTo(Stream target)
            {
                target.Write(_fileContent, 0, _fileContent.Length);
            }
        }
        public enum ApprovalStatusEnum : int
        {
            Pending = 1,
            Approved,
            DisApproved
        }
        // public enum TccStatusEnum : int
        // {
        //     Requested = 15,
        //     Approved,
        //     DisApproved
        // }
        public enum FillingStatusEnum : int
        {
            Filled = 1,
            Approved,
            DisApproved
        }
        public enum TaxPayerTypeEnum : byte
        {
            Individual = 1,
            Company,
            Special
        }
        public static string GetAccessToken(string username, string password)
        {
            string allChar = username + ":" + password;
            var random = new Random();
            var resultToken = new string(
               Enumerable.Repeat(allChar, 6)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            string authToken = resultToken.ToString();
            return authToken;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public class Token
        {
            public string access_token { get; set; }
        }


        public bool SendSMS(string pStrToNumber, string pStrBody, string para1, string para2)
        {
            // Create a new RestClient instance
            var client = new RestClient("https://app.multitexter.com/v2/app/sms");

            // Create a new RestRequest with POST method
            var request = new RestRequest("POST");
            request.AddHeader("Content-Type", "application/json");

            // Prepare the parameters
            string email = para1;
            string password = para2;
            string message = pStrBody;
            string sender_name = "PAYE";
            string recipients = pStrToNumber;
            string forcednd = "1";

            // Create the JSON body for the request
            var jsonBody = new
            {
                email = email,
                password = password,
                message = message,
                sender_name = sender_name,
                recipients = recipients,
                forcednd = forcednd
            };

            // Add the JSON body to the request
            request.AddJsonBody(jsonBody);

            // Execute the request and get the response
            var response = client.Execute(request);

            // Check for a successful response
            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool SendSMS(string pStrToNumber, string pStrBody, string para1, string para2)
        //    {
        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://app.multitexter.com/v2/app/sms");
        //        httpWebRequest.ContentType = "application/json"; httpWebRequest.Method = "POST";
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        //        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //        {
        //            string email = para1;
        //            string password = para2;
        //            string message = pStrBody;
        //            string sender_name = "PAYE";
        //            string recipients = pStrToNumber;
        //            string forcednd = "1";
        //            string json = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"message\":\"" + message + "\",\"sender_name\":\"" + sender_name + "\",\"recipients\":\"" + recipients + "\",\"forcednd\":\"" + forcednd + "\"}";
        //            streamWriter.Write(json); streamWriter.Flush(); streamWriter.Close();
        //        }
        //        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //        {
        //            var result = streamReader.ReadToEnd(); Console.WriteLine(result);
        //        }

        //        return true;
        //    }
        public async Task<bool> SendTiloSMS(string pStrToNumber, string body)
        {
            string recPnt = "";
            if (pStrToNumber.StartsWith("+234"))
            {
                recPnt = pStrToNumber;
            }
            else if (pStrToNumber.StartsWith("234"))
            {
                recPnt = $"+{pStrToNumber}";
            }
            else
            {
                recPnt = $"+234{pStrToNumber}";
            }
            string msg = "";

            msg = bin2hex(body);
            // var msg = fnStringConverterCodepage(bytes);
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://sxmp.gw1.vanso.com/api/sxmp/1.0");
            var content = new StringContent($"<?xml version=\"1.0\"?>\n<operation type=\"submit\">\n    <account username=\"NG.106.0717\" password=\"Fa9mhLDl\"/>\n    <submitRequest>\n        <deliveryReport>true</deliveryReport>\n        <sourceAddress type=\"alphanumeric\">NOWNOW</sourceAddress>\n        <destinationAddress type=\"international\">{pStrToNumber}</destinationAddress>\n        <text encoding=\"ISO-8859-1\">{msg}</text>\n    </submitRequest>\n</operation>", null, "text/xml");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var res = await response.Content.ReadAsStringAsync();
            res = $"This is the response I got when i sent sms to this number:{recPnt} vanso sent : {res}";
            return true;
        }

        public static string bin2hex(string bindata)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(bindata);
            string hexString = "";
            for (int ii = 0; ii < bytes.Length; ii++)
            {
                hexString += bytes[ii].ToString("x2");
            }
            return hexString;
        }
        public byte[] ExportListToExcel<T>(List<T> data, string sheetName = "Sheet1")
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName);

                // Get the properties of the object type T
                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                // Add header row dynamically from the property names
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = properties[i].Name;
                }

                // Insert data into the worksheet
                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];
                    for (int j = 0; j < properties.Length; j++)
                    {
                        var value = properties[j].GetValue(item)?.ToString() ?? "";
                        worksheet.Cell(i + 2, j + 1).Value = value;
                    }
                }

                // Save to a memory stream
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
        public async Task<string> CallAPi(string baseUrl, string token, string httpMethod, string? jsonData = null)
        {
            using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(60) };
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), baseUrl);

            if (!string.IsNullOrEmpty(token))
                request.Headers.Add("Authorization", $"Bearer {token}");

            if (httpMethod.Equals("post", StringComparison.OrdinalIgnoreCase) && jsonData != null)
                request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
        public static string RootPath()
        {
            return (string)AppDomain.CurrentDomain.GetData("ContentRootPath") ?? string.Empty;
        }

        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;

        public static void SendErrorToText(System.Exception ex)
        {
            var line = Environment.NewLine + Environment.NewLine;

            ErrorlineNo = ex.StackTrace.ToString();
            Errormsg = ex.GetType().Name;
            extype = ex.GetType().ToString();
            ErrorLocation = ex.Message;

            try
            {
                string filepath = System.IO.Path.Combine(RootPath(), "ErrorLog/");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = filepath + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }

                using StreamWriter sw = File.AppendText(filepath);
                var date = DateTime.UtcNow.ToString();
                sw.WriteLine($"--------------------------------*Start @ {date}*------------------------------------------");
                string error = "Log Written Date:" + " " + DateTime.UtcNow.ToString(CultureInfo.InvariantCulture) + line +
                               "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line +
                               "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation +
                               line + " Error Page Url:" + " " + exurl + line + "User Host IP:" + " " + hostIp + line;
                sw.WriteLine("-----------Exception Details on " + " " + DateTime.UtcNow.ToString(CultureInfo.InvariantCulture) + "-----------------");
                sw.WriteLine("-------------------------------------------------------------------------------------");
                sw.WriteLine(line);
                sw.WriteLine(error);
                sw.WriteLine("--------------------------------*End*------------------------------------------");
                sw.WriteLine(line);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static List<T> ConvertDataTable2<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                foreach (var prop in typeof(T).GetProperties())
                {
                    if (prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(decimal?))
                    {
                        if (row.Table.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                        {
                            if (decimal.TryParse(row[prop.Name].ToString(), out decimal result))
                            {
                                prop.SetValue(item, result);
                            }
                            else
                            {
                                // Handle the case where conversion fails
                                prop.SetValue(item, 0m); // or throw an exception based on your needs
                            }
                        }
                    }
                    else
                    {
                        if (row.Table.Columns.Contains(prop.Name))
                        {
                            prop.SetValue(item, row[prop.Name]);
                        }
                    }
                }
                data.Add(item);
            }
            return data;
        }

        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (string.IsNullOrEmpty(dr[column.ColumnName].ToString()))
                    {
                        dr[column.ColumnName] = "NULL";
                    }
                    var uh = column.ColumnName;
                    if (uh.Contains("/"))
                        uh = uh.Replace("/", "");
                    else if (uh.Contains("-"))
                        uh = uh.Replace("-", "");
                    else if (uh.Contains(" "))
                        uh = uh.Replace(" ", "");
                    else if (string.IsNullOrEmpty(uh))
                        uh = uh.TrimEnd().TrimStart().Trim();
                    if (pro.Name.ToLower() == uh.ToLower())
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public static List<PersonInfo> ReadFromExcel(IFormFile file)
        {
            var people = new List<PersonInfo>();

            // Load the Excel file from the IFormFile stream
            using (var stream = new MemoryStream())
            {
                file.CopyTo(stream);
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first worksheet
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Assuming row 1 is the header
                    {
                        var person = new PersonInfo
                        {
                            SerialNumber = int.Parse(worksheet.Cells[row, 1].Text),
                            FirstName = worksheet.Cells[row, 2].Text,
                            Surname = worksheet.Cells[row, 3].Text,
                            OtherName = worksheet.Cells[row, 4].Text,
                            PhoneNumber = worksheet.Cells[row, 5].Text,
                            RIN = worksheet.Cells[row, 6].Text,
                            JTBTin = worksheet.Cells[row, 7].Text,
                            NIN = worksheet.Cells[row, 8].Text,
                            Nationality = worksheet.Cells[row, 9].Text,
                            EmailAddress = worksheet.Cells[row, 10].Text,
                            HomeAddress = worksheet.Cells[row, 11].Text,
                            Basic = worksheet.Cells[row, 12].Text,
                            Rent = worksheet.Cells[row, 13].Text,
                            Transport = worksheet.Cells[row, 14].Text,
                            OtherIncome = worksheet.Cells[row, 15].Text,
                            Pension = worksheet.Cells[row, 16].Text,
                            NHF = worksheet.Cells[row, 17].Text,
                            NHIS = worksheet.Cells[row, 18].Text,
                            LifeInsurance = worksheet.Cells[row, 19].Text
                        };

                        people.Add(person);
                    }
                }
            }

            return people;
        }
        public static DataTable ConvertExcelToDatatable(IFormFile file)
        {
            DataTable table = new DataTable();
            using (var stream = file.OpenReadStream())
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelPackage package = new ExcelPackage();
                package.Load(stream);
                if (package.Workbook.Worksheets.Count > 0)
                {
                    using (ExcelWorksheet workSheet = package.Workbook.Worksheets.First())
                    {
                        int noOfCol = workSheet.Dimension.End.Column;
                        int noOfRow = workSheet.Dimension.End.Row;
                        int rowIndex = 1;

                        for (int c = 1; c <= noOfCol; c++)
                        {
                            table.Columns.Add(workSheet.Cells[rowIndex, c].Text);
                        }
                        rowIndex = 2;
                        for (int r = rowIndex; r <= noOfRow; r++)
                        {
                            DataRow dr = table.NewRow();
                            for (int c = 1; c <= noOfCol; c++)
                            {
                                dr[c - 1] = workSheet.Cells[r, c].Value;
                            }
                            table.Rows.Add(dr);
                        }

                        return table;
                    }
                }
                else
                    return table;

            }
        }
        public static List<Dictionary<string, object>> GenerateListFromExcel(IFormFile file, string sheetName)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();

            using (var stream = file.OpenReadStream())
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[sheetName];
                    var startRow = worksheet.Dimension.Start.Row;
                    var endRow = worksheet.Dimension.End.Row;
                    var startCol = worksheet.Dimension.Start.Column;
                    var endCol = worksheet.Dimension.End.Column;

                    // Read header row
                    var headers = new List<string>();
                    for (int col = startCol; col <= endCol; col++)
                    {
                        var head = worksheet.Cells[startRow, col].Text.Trim();
                        if (!string.IsNullOrEmpty(head))
                            headers.Add(head);
                    }

                    // Read data rows
                    for (int row = startRow + 1; row <= endRow; row++)
                    {
                        var rowData = new Dictionary<string, object>();

                        for (int col = startCol; col <= headers.Count; col++)
                        {
                            var header = headers[col - 1];
                            var cellValue = worksheet.Cells[row, col].Value;

                            rowData.Add(header, cellValue);
                            if (col == headers.Count)
                            {
                                resultList.Add(rowData);
                                rowData.Clear();
                            }

                        }


                    }
                }
            }

            return resultList;
        }
        public static byte[] ConvertListToExcel<T>(List<T> list)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Load the list into the worksheet, starting from cell A1
                worksheet.Cells["A1"].LoadFromCollection(list, true, TableStyles.Medium9);

                // Return the Excel file as a byte array
                return package.GetAsByteArray();
            }
        }
        public static void WriteFormModel(string payload, string location)
        {
            var line = Environment.NewLine + Environment.NewLine;
            try
            {
                string filepath = System.IO.Path.Combine(RootPath(), $"Payloads/{location}/");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = filepath + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }

                using StreamWriter sw = File.AppendText(filepath);
                var date = DateTime.UtcNow.ToString();
                sw.WriteLine($"--------------------------------*Start @ {date}*------------------------------------------");
                sw.WriteLine(payload);
                sw.WriteLine("--------------------------------*End*------------------------------------------");
                sw.WriteLine(line);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public async Task<FileContentResult> GenerateExcelFileAsync<T>(List<T> data, string sheetName, string fileName, string heading)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                // Add custom heading
                worksheet.Cells["A1"].Value = heading;
                worksheet.Cells["A1:N1"].Merge = true; // Adjust the range based on how many columns you want to merge
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.Font.Size = 16;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // Add data starting from row 3
                worksheet.Cells["A3"].LoadFromCollection(data, true);

                // Style header row
                using (var range = worksheet.Cells[3, 1, 3, worksheet.Dimension.End.Column])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.AutoFitColumns(); // Adjust the column width to fit content
                }

                // Adjust print settings for A4 page size
                worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
                worksheet.PrinterSettings.FitToWidth = 1;
                worksheet.PrinterSettings.FitToHeight = 0; // Keep the height proportional

                var stream = new MemoryStream();
                await package.SaveAsAsync(stream);

                stream.Position = 0;
                return new FileContentResult(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                {
                    FileDownloadName = fileName
                };
            }
        }

        public static string GenerateTableRows(List<Schedulepdf> schedule)
        {
            var rows = new StringBuilder();
            foreach (var item in schedule)
            {
                string gross = item.Gross.HasValue ? $"₦{item.Gross.Value:N2}" : "₦0.00";
                string cra = item.Cra.HasValue ? $"₦{item.Cra.Value:N2}" : "₦0.00";
                string pension = item.Pension.HasValue ? $"₦{item.Pension.Value:N2}" : "₦0.00";
                string nhf = item.Nhf.HasValue ? $"₦{item.Nhf.Value:N2}" : "₦0.00";
                string nhis = item.Nhis.HasValue ? $"₦{item.Nhis.Value:N2}" : "₦0.00";
                string tfp = item.Tfp.HasValue ? $"₦{item.Tfp.Value:N2}" : "₦0.00";
                string ci = item.Ci.HasValue ? $"₦{item.Ci.Value:N2}" : "₦0.00";
                string tax = item.Tax.HasValue ? $"₦{item.Tax.Value:N2}" : "₦0.00";
                rows.Append("<tr>")
                    .Append($"<td>{item.SerialNo + 1}</td>")
                    .Append($"<td>{item.Rin}</td>")
                    .Append($"<td>{item.Name}</td>")
                    .Append($"<td>{gross}</td>")
                    .Append($"<td>{cra}</td>")
                    .Append($"<td>{pension}</td>")
                    .Append($"<td>{nhf}</td>")
                    .Append($"<td>{nhis}</td>")
                    .Append($"<td>{tfp}</td>")
                    .Append($"<td>{ci}</td>")
                    .Append($"<td>{tax}</td>")
                    .Append("</tr>");
            }
            return rows.ToString();
        }
    }
}
