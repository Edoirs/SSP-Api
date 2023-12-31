
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OfficeOpenXml;
using SelfPortalAPi.ErasModel;
using SelfPortalAPi.Model;
using SelfPortalAPi.NewTables;
using SelfPortalAPi.UnitOfWork;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace SelfPortalAPi
{
    public class AllFunction
    {
        public void ConfigureServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            string? conn = builder.Configuration.GetConnectionString("DefaultConnection");
            string? connII = builder.Configuration.GetConnectionString("EirsContext");
            string? connIII = builder.Configuration.GetConnectionString("ERASContext");
            services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

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
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration.GetSection("JWT:ValidIssuer").Value,
                    ValidAudience = builder.Configuration.GetSection("JWT:ValidAudience").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:Secret").Value))
                };
            });
            services.AddDbContext<ErasContext>(opt => opt.UseSqlServer(connIII));
            services.AddDbContext<ApiDbContext>(opt => opt.UseSqlServer(connII));
            services.AddDbContextPool<PayeeContext>(opt => opt.UseSqlServer(conn));
            services.AddDbContext<EirsContext>(opt => opt.UseSqlServer(connIII));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IValidator<TokenRequest>, TokenRequestValidator>();
            services.AddScoped<IIndividualRepository, IndividualRepository>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUtilityRepository, UtilityRepository>();

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
        public enum ApprovalStatusEnum : int
        {
            Pending = 1,
            Approved,
            DisApproved
        } 
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
        public async Task<int> ValidateToken(string token)
        {
            if (token != null)
            {
                if (token.Contains("Bearer"))
                {
                    token = token.Replace("Bearer ", "").Trim();
                }
                else
                {
                    token = token.Replace("Basic ", "").Trim();
                }

                using var _context = new ErasContext();
                var user = await _context.MstUserTokens.FromSqlRaw($"SELECT top(1) * FROM [MST_UserToken] WHERE token = '{token}'").FirstOrDefaultAsync();

                if (user != null)
                {
                    return user.UserId.Value;
                }
            }
            return 0;
        }

        public static string RootPath()
        {
            return (string)AppDomain.CurrentDomain.GetData("ContentRootPath") ?? string.Empty;
        }

        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;

        public static void SendErrorToText(Exception ex)
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
                var date = DateTime.Now.ToString();
                sw.WriteLine($"--------------------------------*Start @ {date}*------------------------------------------");
                string error = "Log Written Date:" + " " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + line +
                               "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line +
                               "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation +
                               line + " Error Page Url:" + " " + exurl + line + "User Host IP:" + " " + hostIp + line;
                sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + "-----------------");
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
                    if (pro.Name == uh)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
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
                var date = DateTime.Now.ToString();
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

    }
}
