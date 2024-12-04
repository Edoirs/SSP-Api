
namespace SelfPortalAPi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class FormH3Controller : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IOptions<ConnectionStrings> _serviceSettings;
    private readonly SelfServiceConnect _con;
    private readonly IPhaseIIRepo _repo;
    private readonly IHttpContextAccessor _httpContextAccessor;

    string UserId = ""; string TO_RIN = ""; bool IsAdmin = false;
    public FormH3Controller(IOptions<ConnectionStrings> serviceSettings, IPhaseIIRepo repo, IHttpContextAccessor httpContextAccessor, IMapper mapper, SelfServiceConnect con)
    {
        _serviceSettings = serviceSettings;
        _repo = repo;
        _httpContextAccessor = httpContextAccessor;
        _con = con;
        var audience = _httpContextAccessor.HttpContext?.User.Claims.ToList();
        if (audience.Any())
        {
            UserId = audience.First(i => i.Type == "UserId").Value;
            TO_RIN = audience.First(i => i.Type == "TaxOffice").Value;
            IsAdmin = audience.First(i => i.Type == "IsAdmin").Value == "yes" ? true : false;
        }

    }


    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("newgetallformh3bycompanyId/{companyId}")]
    public async Task<IActionResult> newgetallformh3([FromRoute][Required] string companyId, [FromQuery] int pageNumber = 1,
    [FromQuery] int pageSize = 100)
    {
        try
        {
            ReturnObject rr = new();
            IQueryable<Models.AssetTaxPayerDetailsApi> res;
            IDictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int> resData;
            if (IsAdmin)
                resData = await _repo.GetCompanyTiedToAdminUser(TO_RIN, true, pageNumber, pageSize);
            else
                resData = await _repo.GetCompanyTiedToAdminUser(companyId, false, pageNumber, pageSize);


            res = resData.Keys.FirstOrDefault();
            var finalBusinessReturnModel = new List<NewBusinessReturnModel>();
            foreach (var r in res)
            {
                var empCountDet = _con.SspfiledFormH3s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                ).GroupBy(o => o.TaxYear).ToList();

                foreach (var r2 in empCountDet)
                {
                    var jan31st = new DateTime(r2.Key.Value, 1, 31);
                    var m = new NewBusinessReturnModel
                    {
                        BusinessRIN = r.AssetRin,
                        CompanyRin = r.TaxPayerRinnumber,
                        BusinessName = r.AssetName,
                        BusinessID = r.AssetId.ToString(),
                        CompanyName = r.TaxPayerName,
                        CompanyId = r.TaxPayerId.ToString(),
                        TaxYear = r2.Key.ToString(),
                        NoOfEmployees = r2.Count().ToString(),
                        DateForwarded = r2.FirstOrDefault().Datetcreated.ToString(),
                        DueDate = r2.FirstOrDefault().DueDate,
                        AnnualReturnStatus = r2.FirstOrDefault().Datetcreated > jan31st ? "Defaulter" : "Complied",
                    };
                    finalBusinessReturnModel.Add(m);
                }
            }
            rr.status = true;
            rr.message = "Record Found Successfully";
            rr.data = new { totalCount = resData.Values.FirstOrDefault(), result = finalBusinessReturnModel };
            return Ok(rr);
        }
        catch (System.Exception ex)
        {
            return (
                StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ReturnObject { status = false, message = ex.Message }
                )
            );
        }
    }

    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallformh3bycompanyId/{companyId}")]
    public async Task<IActionResult> getallform3([FromRoute] string companyId, [FromQuery] int pageNumber = 1,
    [FromQuery] int pageSize = 100, [FromQuery] string busRin = null)
    {
        bool eget = false;
        try
        {
            ReturnObject rr = new();
            List<Models.AssetTaxPayerDetailsApi> res;
            IDictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int> resData;
            if (IsAdmin)
                resData = await _repo.GetCompanyTiedToAdminUser(TO_RIN, true, pageNumber, pageSize);
            else
                resData = await _repo.GetCompanyTiedToAdminUser(companyId, false, pageNumber, pageSize);


            res = resData.Keys.FirstOrDefault().ToList();
            if (!string.IsNullOrEmpty(busRin))
            {
                if (res != null)
                    res = res.Where(o => string.Equals(o.AssetRin, busRin, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            res = res.Skip((pageNumber - 1) * pageSize)
             .Take(pageSize)
             .ToList();
            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            foreach (var r in res)
            {
                var empCountDet = _con.SspformH3s.Where(o => o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId);
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString(); 
                m.CompanyName = r.TaxPayerName.ToString();
                m.CompanyID = r.TaxPayerId.ToString();
                m.NoOfEmployees = empCountDet.Count() > 0 ? empCountDet.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
            }

            rr.status = true;
            rr.message = "Record Found Successfully";
            rr.data = new { totalCount = resData.Values.FirstOrDefault(), result = finalBusinessReturnModel };
            return Ok(rr);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallformh3WithcompanyId/{companyId}")]
    public async Task<IActionResult> getform3([FromRoute] string companyId)
    {
        try
        {
            var getRin = _con.UserManagements.FirstOrDefault(o => o.CompanyId == Convert.ToInt64(companyId));

            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            var res = _con.AssetTaxPayerDetailsApis.Where(o => o.TaxPayerRinnumber == getRin.CompanyRin);
            foreach (var r in res)
            {
                var empCountDet = _con.SspformH3s.Where(o => o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId);
                var empCount = _con.SspfiledFormH3s.Where(o => o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId);
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.TaxPayerName = r.TaxPayerName;
                m.BusinessID = r.AssetId.ToString();
                m.ProjectionYear = empCount.Count() > 0 ? empCount.FirstOrDefault().TaxYear.ToString() : "";
                m.DateForwarded = empCount.Count() > 0 ? empCount.FirstOrDefault().Datetcreated.Value.ToString("dd-MM-yyyy") : "";
                m.NoOfEmployees = empCountDet.Count() > 0 ? empCountDet.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
            }
            return Ok(finalBusinessReturnModel);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallformh3bycompanyId/{companyId}/bybusinessId/{businessId}")]
    public async Task<IActionResult> getallformh3bybusinessId([FromRoute] string companyId, [FromRoute] string businessId)
    {
        try
        {
            var getRin = _con.UserManagements.FirstOrDefault(o => o.CompanyId == Convert.ToInt64(companyId));

            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            var res = _con.AssetTaxPayerDetailsApis.Where(o => o.TaxPayerRinnumber == getRin.CompanyRin && o.AssetId == Convert.ToInt32(businessId));
            foreach (var r in res)
            {
                var empCountDet = _con.SspformH3s.Where(o => o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId);
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString();
                m.NoOfEmployees = empCountDet.Count() > 0 ? empCountDet.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
            }
            return Ok(finalBusinessReturnModel);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }

    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getalluplaodedformh3bycompanyId/{companyId}/bybusinessId/{businessId}")]
    public async Task<IActionResult> getalluplaodedformh3bybusinessId([FromRoute] string companyId, [FromRoute] string businessId)
    {
        try
        {
            using var _context = new SelfServiceConnect();
            string query = $@"
    SELECT s.[Id], s.[BusinessId], s.[CompanyId], I.FIRSTNAME, I.SURNAME, I.Designation, I.NATIONALITY,
       s.[TaxPayerId] AS TaxPayerID, s.IndividualId, s.[RIN], s.[PENSION], s.[NHF], s.[NHIS], s.[LIFEASSURANCE],
       s.[Rent], s.[Transport], s.[Basic], s.[StartMonth], s.[OtherIncome], 
       CASE WHEN s.[Status] = 0 THEN 'Inactive' ELSE 'Active' END AS StatusName,
       s.[datetcreated], s.[createdby],
       (s.[Rent] + s.[Basic] + s.[OtherIncome] + s.[Transport]) AS Total,
       s.[datemodified], s.[modifiedby],
       A.AssetName AS BusinessName, A.TaxPayerName AS CompanyName
FROM SSPFormH3s s
LEFT JOIN AssetTaxPayerDetails_API A ON s.BusinessId = A.AssetID and s.TaxPayerId = a.TaxPayerID
LEFT JOIN Individual I ON s.IndividualId = I.EmployeeId
WHERE s.CompanyId = '{companyId}' 
  AND s.BusinessId = '{businessId}'";

            var user = _context.ReturnSspformH3.FromSqlRaw(query).ToList();
            foreach (var u in user)
                u.NumberOfMonths = CalculateMonthsLeft(u.Startmonth);
            return Ok(user);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallfiledformh3bycompanyId/{companyId}/bybusinessId/{businessId}/byyear/{year}")]
    public async Task<IActionResult> getallfiledformh3bybusinessIdbyyear([FromRoute] string companyId, [FromRoute] string businessId, [FromRoute] string year)
    {
        var r = new ReturnObject();
        try
        {
            using var _context = new SelfServiceConnect();
            var query = $"SELECT  S.[Id],[BusinessId],[CompanyId],S.[TaxPayerId],A.AssetName,s.[IndividalId],s.[RIN],[PENSION],  B.FirstName + ' ' + B.OTHERNAME + ' ' + B.SURNAME AS FullName,[NHF],[NHIS],[LIFEASSURANCE],[Rent],[Transport],[Basic],[OtherIncome],[FiledStatus],[TaxYear],[DueDate],[ComplianceStatus],s.createdby   ,s.datemodified,s.datetcreated,s.modifiedby  FROM [SSPFiledFormH3s] s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID left join Individual B on s.IndividalId = B.Id  where s.BusinessId = '{businessId}' and s.CompanyId='{companyId}' and TaxYear = '{year}'";
            var user = _context.SspfiledFormH3ForSPs.FromSqlRaw(query).ToList();
            r.data = user;
            r.status = true;
            r.message = "Record Fetched Successfully";

            return Ok(r);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpPut]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("update-TaxpayerH3")]
    public async Task<IActionResult> updatetaxpayerH3([FromBody] TaxPayersH3 obj)
    {
        try
        {
            var r = new ReturnObject { message = "Record Updated Successfully", status = true };
            var all = _con.SspformH3s.Where(o =>
                    o.TaxPayerId == obj.TaxPayerId
                    && o.BusinessId == obj.BusinessId
                    && o.CompanyId == obj.CompanyId
                ).FirstOrDefault();
            if (all == null)
            {
                return Ok(new ReturnObject { message = "User Not Found", status = false });
            }
            _ = _con
                .SspformH3s.Where(o =>
                    o.TaxPayerId == obj.TaxPayerId
                    && o.BusinessId == obj.BusinessId
                    && o.CompanyId == obj.CompanyId
                )
                .ExecuteUpdate(setters =>
                    setters
                        // .SetProperty(b => b.FIRSTNAME, obj.FIRSTNAME)
                        .SetProperty(b => b.OtherIncome, Convert.ToDecimal(obj.OtherIncome))


                        .SetProperty(b => b.Pension, Convert.ToDecimal(obj.PENSION))
                        .SetProperty(b => b.Nhf, Convert.ToDecimal(obj.NHIS))
                        .SetProperty(b => b.Lifeassurance, Convert.ToDecimal(obj.LIFEASSURANCE))

                        .SetProperty(b => b.Rent, Convert.ToDecimal(obj.Rent))
                        .SetProperty(b => b.Transport, Convert.ToDecimal(obj.Transport))
                        .SetProperty(b => b.Basic, Convert.ToDecimal(obj.Basic))
                );
            _ = _con
               .Individuals.Where(o =>
                   o.EmployeeId == all.IndividualId
               )
               .ExecuteUpdate(setters =>
                   setters
                        .SetProperty(b => b.Firstname, obj.FIRSTNAME)
                        .SetProperty(b => b.Othername, obj.OTHERNAME)
                        .SetProperty(b => b.Surname, obj.SURNAME)
                        .SetProperty(b => b.Phonenumber, obj.PHONENUMBER)
                       .SetProperty(b => b.EmployeeRin, obj.RIN)
                        .SetProperty(b => b.Jtbtin, obj.JTBTIN)
                        .SetProperty(b => b.Nin, obj.NIN)
                        .SetProperty(b => b.Designation, obj.Designation)
                       .SetProperty(b => b.Nationality, obj.NATIONALITY)
                       .SetProperty(b => b.Homeaddress, obj.HOMEADDRESS));
            return Ok(r);

        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallfiledformh3bycompanyId/{companyId}")]
    public async Task<IActionResult> getallfiledformh3bycompanyId([FromRoute] string companyId)
    {
        var r = new ReturnObject();
        try
        {
            using var _context = new SelfServiceConnect();
            var query = $"SELECT  S.[Id],[BusinessId],[CompanyId],S.[TaxPayerId],A.AssetName,s.[IndividalId],s.[RIN],[PENSION],   CASE WHEN B.OTHERNAME IS NOT NULL THEN  B.FirstName + ' ' + B.OTHERNAME + ' ' + B.SURNAME   ELSE B.FirstName + ' ' + B.SURNAME     END AS FullName,[NHF],[NHIS],[LIFEASSURANCE],[Rent],[Transport],[Basic],[OtherIncome],[FiledStatus],[TaxYear],[DueDate],[ComplianceStatus],s.createdby   ,s.datemodified,s.datetcreated,s.modifiedby  FROM [SSPFiledFormH3s] s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID left join Individual B on s.IndividalId = B.EmployeeId  where  s.CompanyId='{companyId}'";
            var user = _context.SspfiledFormH3ForSPs.FromSqlRaw(query).ToList();
            r.data = user;
            r.status = true;
            r.message = "Record Fetched Successfully";

            return Ok(r);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }

    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("UploadMonthly")]
    public async Task<IActionResult> UploadMonthly([FromForm] AddFormH obj)
    {
        AllFunction af = new AllFunction();
        var lstErrorRes = new List<string>();
        string errorNote = "There Is An Error On Row";
        var r = new ReturnObject();
        var baseUrl = _serviceSettings.Value.ErasBaseUrl;
        string mainBaseurl = "";
        JavaScriptSerializer js = new();
        var resp = "";
        List<EmployeesMonthlyIncome> lstFormH1 = new();
        List<Individual> lstIndividual = new();
        Receiver rootobjectVm = new();
        try
        {
            var la = new List<PersonInfo>();
            r.status = true;
            r.message = "Record saved Successfully";
            if (obj.File != null && obj.File.Length > 0)
            {
                var table = AllFunction.ConvertExcelToDatatable(obj.File);
                la = AllFunction.ConvertDataTable<PersonInfo>(table);
                la = la.Where(o => o.FirstName != "NULL").ToList();

                int successCounter = 0;
                string mail = "";
                if (la.Count > 0)
                {
                    for (int i = 0; i < la.Count(); i++)
                    {
                        if (
                            (string.IsNullOrEmpty(la[i].PhoneNumber) || la[i].PhoneNumber.Length > 15)
                            && (string.IsNullOrEmpty(la[i].RIN))
                            && (string.IsNullOrEmpty(la[i].JTBTin))
                        )
                        {
                            lstErrorRes.Add(
                                   $"{errorNote} in row {i + 1} Provide PHONENUMBER or RIN or TIN."
                               );
                        }
                        if (
                            (string.IsNullOrEmpty(la[i].Basic))
                            && (string.IsNullOrEmpty(la[i].Rent))
                            && (string.IsNullOrEmpty(la[i].OtherIncome))
                            && (string.IsNullOrEmpty(la[i].Transport))
                        )
                        {
                            lstErrorRes.Add(
                                   $"{errorNote} in row {i + 1} Provide Basic or Rent or Other income or Transport."
                               );
                        }
                    }
                    if (lstErrorRes.Any())
                    {
                        var res = string.Join("", lstErrorRes);
                        r.status = false;
                        r.message = $"{res}";
                        return await Task.FromResult<IActionResult>(Ok(r));
                    }

                    var token = af.GetToken(_serviceSettings.Value.ErasBaseUrl, _serviceSettings.Value.eirsusername, _serviceSettings.Value.eirspassword);
                    if (token != null)
                    {
                        for (int i = 0; i < la.Count(); i++)
                        {

                            la[i].Pension = !string.IsNullOrEmpty(la[i].Pension) ? la[i].Pension : "0";
                            la[i].NHF = !string.IsNullOrEmpty(la[i].NHF) ? la[i].NHF : "0";
                            la[i].NHIS = !string.IsNullOrEmpty(la[i].NHIS) ? la[i].NHIS : "0";
                            la[i].LifeInsurance = !string.IsNullOrEmpty(la[i].LifeInsurance) ? la[i].LifeInsurance : "0";
                            la[i].Rent = !string.IsNullOrEmpty(la[i].Rent) ? la[i].Rent : "0";
                            la[i].Transport = !string.IsNullOrEmpty(la[i].Transport) ? la[i].Transport : "0";
                            la[i].Basic = !string.IsNullOrEmpty(la[i].Basic) ? la[i].Basic : "0";
                            la[i].OtherIncome = !string.IsNullOrEmpty(la[i].OtherIncome) ? la[i].OtherIncome : "0";
                            if (!string.IsNullOrEmpty(la[i].PhoneNumber) && la[i].PhoneNumber != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + la[i].PhoneNumber;
                            }
                            else if (!string.IsNullOrEmpty(la[i].RIN) && la[i].RIN != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + la[i].RIN;
                            }
                            else if (!string.IsNullOrEmpty(la[i].JTBTin) && la[i].JTBTin != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + la[i].JTBTin;
                            }
                            else
                            {
                                r.status = false;
                                r.message = "Error Occured Processing Record To ERAS";
                                return Ok(r);
                            }
                            decimal? Pension, Nhf, Nhis, Lifeassurance, Rent, Transport, Basic, OtherIncome = 0;

                            Pension = la[i].Pension != "NULL" ? Convert.ToDecimal(la[i].Pension) : 0;
                            Nhf = la[i].NHF != "NULL" ? Convert.ToDecimal(la[i].NHF) : 0;
                            Nhis = la[i].NHIS != "NULL" ? Convert.ToDecimal(la[i].NHIS) : 0;
                            Lifeassurance = la[i].LifeInsurance != "NULL" ? Convert.ToDecimal(la[i].LifeInsurance) : 0;
                            Rent = la[i].Rent != "NULL" ? Convert.ToDecimal(la[i].Rent) : 0;
                            Transport = la[i].Transport != "NULL" ? Convert.ToDecimal(la[i].Transport) : 0;
                            Basic = la[i].Basic != "NULL" ? Convert.ToDecimal(la[i].Basic) : 0;
                            OtherIncome = la[i].OtherIncome != "NULL" ? Convert.ToDecimal(la[i].OtherIncome) : 0;
                            resp = await CallAPi(mainBaseurl, token, "get", "");
                            rootobjectVm = js.Deserialize<Receiver>(resp);
                            if (rootobjectVm.Result.Count <= 0)
                            {
                                mainBaseurl = "";
                                if (string.IsNullOrEmpty(la[i].EmailAddress) || la[i].EmailAddress == "NULL")
                                {
                                    mail = "abc@gmail.com";
                                }
                                else
                                {
                                    mail = la[i].EmailAddress;
                                }
                                mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                AddTaxPayer ad = new();
                                ad.TaxPayerTypeId = 1;
                                ad.GenderID = 1;
                                ad.TitleID = 2;
                                ad.FirstName = la[i].FirstName;
                                ad.LastName = la[i].Surname;
                                ad.MiddleName = la[i].OtherName;
                                ad.DOB = "01/01/1960";
                                ad.TIN = la[i].JTBTin;
                                ad.MobileNumber1 = la[i].PhoneNumber;
                                ad.EmailAddress1 = mail;
                                ad.BiometricDetails = "";
                                ad.TaxOfficeID = 34;
                                ad.NewTaxOfficeID = 34;
                                ad.PresentTaxOfficeID = 34;
                                ad.MaritalStatusID = 3;
                                ad.NationalityID = 1;
                                ad.EconomicActivitiesID = 1;
                                ad.NotificationMethodID = 1;
                                ad.ContactAddress = la[i].HomeAddress;
                                string jsonData = js.Serialize(ad);

                                resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    mainBaseurl = "";
                                    if (!string.IsNullOrEmpty(la[i].PhoneNumber) && la[i].PhoneNumber != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + la[i].PhoneNumber;
                                    }
                                    else if (!string.IsNullOrEmpty(la[i].RIN) && la[i].RIN != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + la[i].RIN;
                                    }
                                    else if (!string.IsNullOrEmpty(la[i].JTBTin) && la[i].JTBTin != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + la[i].JTBTin;
                                    }
                                    else
                                    {
                                        r.status = false;
                                        r.message = "Error Occured Processing Record To ERAS";
                                        return Ok(r);
                                    }

                                    resp = await CallAPi(mainBaseurl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        var sp = new Individual
                                        {
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Firstname = la[i].FirstName,
                                            Surname = la[i].Surname,
                                            Othername = la[i].OtherName,
                                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Jtbtin = la[i].JTBTin,
                                            Nin = la[i].NIN,
                                            Nationality = la[i].Nationality,
                                            Homeaddress = la[i].HomeAddress,
                                            Designation = "",
                                            //Datetcreated = DateTime.UtcNow,
                                            //Datemodified = DateTime.UtcNow,
                                        };
                                        lstIndividual.Add(sp);
                                        lstFormH1.Add(new EmployeesMonthlyIncome
                                        {
                                            Pension = Pension,
                                            Nhf = Nhf,
                                            Nhis = Nhf,
                                            LifeAssurance = Lifeassurance,
                                            Rent = Rent,
                                            Transport = Transport,
                                            Basic = Basic,
                                            Others = OtherIncome,
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            BusinessId = obj.BusinessId,
                                            CompanyId = obj.CompanyId,
                                            Status = true
                                        });
                                        successCounter++;
                                    }
                                }
                                else
                                {
                                    string jsonDataErr = js.Serialize(rootobjectVm);
                                    lstErrorRes.Add($" Error Adding record  in Row {i + 1} From ERAS API {jsonDataErr}.");
                                }
                            }
                            else
                            {
                                if (rootobjectVm.Success == true)
                                {
                                    var res = _con.Individuals.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() && o.EmployeeRin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString());
                                    if (res != null)
                                    {
                                        _con.Individuals.Where(
                       o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                       .ExecuteUpdate(obj => obj
                                       .SetProperty(b => b.Firstname, la[i].FirstName)
                                       .SetProperty(b => b.Surname, la[i].Surname)
                                       .SetProperty(b => b.Othername, la[i].OtherName)
                                       .SetProperty(b => b.Phonenumber, rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString())
                                       .SetProperty(b => b.EmployeeRin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                       .SetProperty(b => b.Jtbtin, la[i].JTBTin)
                                       .SetProperty(b => b.Nin, la[i].NIN)
                                       .SetProperty(b => b.Nationality, la[i].Nationality)
                                       .SetProperty(b => b.Homeaddress, la[i].HomeAddress)
                                       .SetProperty(b => b.Designation, "")
                                       );
                                    }
                                    else
                                    {
                                        var sp = new Individual
                                        {
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Firstname = la[i].FirstName,
                                            Surname = la[i].Surname,
                                            Othername = la[i].OtherName,
                                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Jtbtin = la[i].JTBTin,
                                            Nin = la[i].NIN,
                                            Nationality = la[i].Nationality,
                                            Homeaddress = la[i].HomeAddress,
                                            Designation = "",
                                            Datetcreated = DateTime.UtcNow,
                                            Datemodified = DateTime.UtcNow,
                                        };
                                        lstIndividual.Add(sp);
                                    }
                                    var resForm = _con.EmployeesMonthlyIncomes.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                     && o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId);
                                    if (resForm != null)
                                    {
                                        _con.EmployeesMonthlyIncomes.Where(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                      .ExecuteUpdate(obj => obj
                                      .SetProperty(b => b.EmployeeId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                      //.SetProperty(b => b.Rin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                      //.SetProperty(b => b.Startmonth, la[i].STARTMONTH)
                                      .SetProperty(b => b.Pension, Pension)
                                      .SetProperty(b => b.Nhf, Nhf)
                                      .SetProperty(b => b.Nhis, Nhis)
                                      .SetProperty(b => b.LifeAssurance, Lifeassurance)
                                      .SetProperty(b => b.Rent, Rent)
                                      .SetProperty(b => b.Transport, Transport)
                                      .SetProperty(b => b.Basic, Basic)
                                      .SetProperty(b => b.Others, OtherIncome)
                                      );
                                    }
                                    else
                                    {
                                        lstFormH1.Add(new EmployeesMonthlyIncome
                                        {
                                            Pension = Pension,
                                            Nhf = Nhf,
                                            Nhis = Nhis,
                                            LifeAssurance = Lifeassurance,
                                            Rent = Rent,
                                            Transport = Transport,
                                            Basic = Basic,
                                            Others = OtherIncome,
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            BusinessId = obj.BusinessId,
                                            CompanyId = obj.CompanyId,
                                            Status = true
                                        });
                                    }

                                    successCounter++;
                                }
                                else
                                {
                                    string jsonDataErr = js.Serialize(rootobjectVm);
                                    lstErrorRes.Add($" Error Adding record  in Row {i + 1} From ERAS API {jsonDataErr}.");
                                }
                            }
                            mail = "";
                            mainBaseurl = "";
                        }
                        _con.Individuals.AddRange(lstIndividual);
                        _con.EmployeesMonthlyIncomes.AddRange(lstFormH1);
                        _con.SaveChanges();
                    }
                }
                if (lstErrorRes.Any())
                {
                    var res = string.Join("", lstErrorRes);
                    if (successCounter > 0)
                        r.message = $"Some Records Saved Successfully, However Some didnt{res}";
                    else
                        r.message = $"{res}";
                }
                return await Task.FromResult<IActionResult>(Ok(r));
            }
            else
            {
                r.status = false;
                r.message = "Error Occured Processing Wrong File";
                return await Task.FromResult<IActionResult>(Ok(r));
            }
        }
        catch (System.Exception ex)
        {
            AllFunction.SendErrorToText(ex);
            var res = new ReturnObject
            {
                status = false,
                message = $"{ex.Message} this is what i got from ERAS API {resp}"
            };
            return Ok(res);
        }
    }
    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("UploadFormH3")]
    public async Task<IActionResult> UploadFormH3([FromForm] AddFormH obj)
    {
        AllFunction af = new AllFunction();
        var lstErrorRes = new List<ReturnObjectC>();
        string errorNote = "There Is An Error On Row";
        var r = new ReturnObjectB();
        var baseUrl = _serviceSettings.Value.ErasBaseUrl;
        string mainBaseurl = "";
        JavaScriptSerializer js = new();
        var resp = "";
        List<SspformH3> lstFormH1 = new();
        List<Individual> lstIndividual = new();
        Receiver rootobjectVm = new();
        try
        {
            var la = new List<FormH3FM>();
            r.status = true;
            r.message = "Record saved Successfully";
            if (obj.File != null && obj.File.Length > 0)
            {
                var table = AllFunction.ConvertExcelToDatatable(obj.File);
                la = AllFunction.ConvertDataTable<FormH3FM>(table);
                la = la.Where(o => o.FIRSTNAME != "NULL").ToList();

                var newError = new List<ReceiverError>();
                int successCounter = 0;
                if (la.Count > 0)
                {
                    for (int i = 0; i < la.Count(); i++)
                    {
                        if (
                            (string.IsNullOrEmpty(la[i].PHONENUMBER) || la[i].PHONENUMBER == "NULL" || la[i].PHONENUMBER.Length > 15)
                            && (string.IsNullOrEmpty(la[i].RIN) || la[i].RIN == "NULL")
                            && (string.IsNullOrEmpty(la[i].JTBTIN) || la[i].JTBTIN == "NULL")
                        )
                        {
                            lstErrorRes.Add(new ReturnObjectC
                            {
                                data =
                                   $"{errorNote} in row {i + 1} Provide PHONENUMBER or RIN or TIN."
                            ,
                                id = 1
                            }
                               );
                        }
                    }
                    if (lstErrorRes.Any())
                    {
                        var res = string.Join("", lstErrorRes);
                        r.status = false;
                        r.message = lstErrorRes;
                        await Task.FromResult<IActionResult>(Ok(r));
                    }

                    var token = af.GetToken(_serviceSettings.Value.ErasBaseUrl, _serviceSettings.Value.eirsusername, _serviceSettings.Value.eirspassword);
                    if (token != null)
                    {
                        for (int i = 0; i < la.Count(); i++)
                        {
                            if (la[i].PHONENUMBER != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + la[i].PHONENUMBER;
                            }
                            else if (la[i].RIN != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + la[i].RIN;
                            }
                            else if (la[i].JTBTIN != "NULL")
                            {
                                mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + la[i].JTBTIN;
                            }
                            else
                            {
                                r.status = false;
                                r.message = "Error Occured Processing Record To ERAS";
                                return Ok(r);
                            }
                            resp = await CallAPi(mainBaseurl, token, "get", "");
                            rootobjectVm = js.Deserialize<Receiver>(resp);
                            if (rootobjectVm.Result.Count <= 0)
                            {
                                mainBaseurl = "";
                                mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                AddTaxPayer ad = new();
                                ad.TaxPayerTypeId = 1;
                                ad.GenderID = 1;
                                ad.TitleID = 2;
                                ad.FirstName = la[i].FIRSTNAME;
                                ad.LastName = la[i].SURNAME;
                                ad.MiddleName = la[i].OTHERNAME;
                                ad.DOB = "01/01/2004";
                                ad.TIN = la[i].JTBTIN;
                                ad.MobileNumber1 = la[i].PHONENUMBER;
                                ad.EmailAddress1 = "abc@gmail.com";
                                ad.BiometricDetails = "";
                                ad.TaxOfficeID = 34;
                                ad.NewTaxOfficeID = 34;
                                ad.PresentTaxOfficeID = 34;
                                ad.MaritalStatusID = 3;
                                ad.NationalityID = 1;
                                ad.EconomicActivitiesID = 1;
                                ad.NotificationMethodID = 1;
                                ad.ContactAddress = la[i].HOMEADDRESS;
                                string jsonData = js.Serialize(ad);

                                resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    mainBaseurl = "";
                                    if (la[i].PHONENUMBER != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + la[i].PHONENUMBER;
                                    }
                                    else if (la[i].RIN != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + la[i].RIN;
                                    }
                                    else if (la[i].JTBTIN != "NULL")
                                    {
                                        mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + la[i].JTBTIN;
                                    }
                                    else
                                    {
                                        r.status = false;
                                        r.message = "Error Occured Processing Record To ERAS";
                                        return Ok(r);
                                    }

                                    resp = await CallAPi(mainBaseurl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        var sp = new Individual
                                        {
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Firstname = la[i].FIRSTNAME,
                                            Surname = la[i].SURNAME,
                                            Othername = la[i].OTHERNAME,
                                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Jtbtin = la[i].JTBTIN,
                                            Nin = la[i].NIN,
                                            Nationality = la[i].NATIONALITY,
                                            Homeaddress = la[i].HOMEADDRESS,
                                            Designation = la[i].Designation,
                                        };
                                        lstIndividual.Add(sp);
                                        lstFormH1.Add(new SspformH3
                                        {
                                            Status = true,
                                            Datetcreated = DateTime.UtcNow,
                                            Datemodified = DateTime.UtcNow,
                                            BusinessId = obj.BusinessId,
                                            CompanyId = obj.CompanyId,
                                            TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            IndividualId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Rin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Pension = la[i].PENSION != "NULL" ? Convert.ToDecimal(la[i].PENSION) : 0,
                                            Nhf = la[i].NHF != "NULL" ? Convert.ToDecimal(la[i].NHF) : 0,
                                            Nhis = la[i].NHIS != "NULL" ? Convert.ToDecimal(la[i].NHIS) : 0,
                                            Lifeassurance = la[i].LIFEASSURANCE != "NULL" ? Convert.ToDecimal(la[i].LIFEASSURANCE) : 0,
                                            Rent = la[i].Rent != "NULL" ? Convert.ToDecimal(la[i].Rent) : 0,
                                            Startmonth = la[i].STARTMONTH != "NULL" ? la[i].STARTMONTH : "0",
                                            Transport = la[i].Transport != "NULL" ? Convert.ToDecimal(la[i].Transport) : 0,
                                            Basic = la[i].Basic != "NULL" ? Convert.ToDecimal(la[i].Basic) : 0,
                                            OtherIncome = la[i].OtherIncome != "NULL" ? Convert.ToDecimal(la[i].OtherIncome) : 0
                                        });
                                        successCounter++;
                                    }
                                    else
                                    {
                                        //newError.Add(rootobjectVm);
                                        string jsonDataErr = js.Serialize(rootobjectVm);
                                        lstErrorRes.Add(new ReturnObjectC { id = i + 1, data = rootobjectVm });
                                    }

                                }
                                else
                                {
                                    string jsonDataErr = js.Serialize(rootobjectVm);
                                    lstErrorRes.Add(new ReturnObjectC { id = i + 1, data = rootobjectVm });
                                }
                            }
                            else
                            {
                                if (rootobjectVm.Success == true)
                                {
                                    var res = _con.Individuals.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() && o.EmployeeRin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString());
                                    if (res != null)
                                    {
                                        _con.Individuals.Where(
                          o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                          .ExecuteUpdate(obj => obj
                                          .SetProperty(b => b.Firstname, la[i].FIRSTNAME)
                                          .SetProperty(b => b.Surname, la[i].SURNAME)
                                          .SetProperty(b => b.Othername, la[i].OTHERNAME)
                                          .SetProperty(b => b.Phonenumber, rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString())
                                          .SetProperty(b => b.EmployeeRin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                          .SetProperty(b => b.Jtbtin, la[i].JTBTIN)
                                          .SetProperty(b => b.Nin, la[i].NIN)
                                          .SetProperty(b => b.Nationality, la[i].NATIONALITY)
                                          .SetProperty(b => b.Homeaddress, la[i].HOMEADDRESS)
                                          .SetProperty(b => b.Designation, la[i].Designation)
                                          );
                                    }
                                    else
                                    {
                                        var sp = new Individual
                                        {
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Firstname = la[i].FIRSTNAME,
                                            Surname = la[i].SURNAME,
                                            Othername = la[i].OTHERNAME,
                                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Jtbtin = la[i].JTBTIN,
                                            Nin = la[i].NIN,
                                            Nationality = la[i].NATIONALITY,
                                            Homeaddress = la[i].HOMEADDRESS,
                                            Designation = la[i].Designation,
                                            Datetcreated = DateTime.UtcNow,
                                            Datemodified = DateTime.UtcNow,
                                        };
                                        lstIndividual.Add(sp);
                                    }
                                    var resForm = _con.SspformH3s.FirstOrDefault(o => o.IndividualId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                    && o.Rin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString() && o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId);
                                    if (resForm != null)
                                    {
                                        _con.SspformH3s.Where(o => o.IndividualId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() && o.Rin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                      .ExecuteUpdate(obj => obj
                                      .SetProperty(b => b.TaxPayerId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                      .SetProperty(b => b.Rin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                      .SetProperty(b => b.Status, true)
                                      .SetProperty(b => b.Startmonth, la[i].STARTMONTH)
                                      .SetProperty(b => b.Pension, la[i].PENSION != "NULL" ? Convert.ToDecimal(la[i].PENSION) : 0)
                                      .SetProperty(b => b.Nhf, la[i].NHF != "NULL" ? Convert.ToDecimal(la[i].NHF) : 0)
                                      .SetProperty(b => b.Nhis, la[i].NHIS != "NULL" ? Convert.ToDecimal(la[i].NHIS) : 0)
                                      .SetProperty(b => b.Lifeassurance, la[i].LIFEASSURANCE != "NULL" ? Convert.ToDecimal(la[i].LIFEASSURANCE) : 0)
                                      .SetProperty(b => b.Rent, la[i].Rent != "NULL" ? Convert.ToDecimal(la[i].Rent) : 0)
                                      .SetProperty(b => b.Transport, la[i].Transport != "NULL" ? Convert.ToDecimal(la[i].Transport) : 0)
                                      .SetProperty(b => b.Basic, la[i].Basic != "NULL" ? Convert.ToDecimal(la[i].Basic) : 0)
                                      .SetProperty(b => b.OtherIncome, la[i].OtherIncome != "NULL" ? Convert.ToDecimal(la[i].OtherIncome) : 0)

                                      );
                                    }
                                    else
                                    {
                                        lstFormH1.Add(new SspformH3
                                        {
                                            Status = true,
                                            BusinessId = obj.BusinessId,
                                            CompanyId = obj.CompanyId,
                                            TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            IndividualId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Startmonth = la[i].STARTMONTH,
                                            Rin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                            Pension = la[i].PENSION != "NULL" ? Convert.ToDecimal(la[i].PENSION) : 0,
                                            Nhf = la[i].NHF != "NULL" ? Convert.ToDecimal(la[i].NHF) : 0,
                                            Nhis = la[i].NHIS != "NULL" ? Convert.ToDecimal(la[i].NHIS) : 0,
                                            Lifeassurance = la[i].LIFEASSURANCE != "NULL" ? Convert.ToDecimal(la[i].LIFEASSURANCE) : 0,
                                            Rent = la[i].Rent != "NULL" ? Convert.ToDecimal(la[i].Rent) : 0,
                                            Transport = la[i].Transport != "NULL" ? Convert.ToDecimal(la[i].Transport) : 0,
                                            Basic = la[i].Basic != "NULL" ? Convert.ToDecimal(la[i].Basic) : 0,
                                            OtherIncome = la[i].OtherIncome != "NULL" ? Convert.ToDecimal(la[i].OtherIncome) : 0
                                        });
                                    }

                                    successCounter++;
                                }
                                else
                                {
                                    // newError.Add(new ReceiverError { Id = i + 1, Error.Add(rootobjectVm));
                                    string jsonDataErr = js.Serialize(rootobjectVm);
                                    lstErrorRes.Add(new ReturnObjectC { id = i + 1, data = rootobjectVm });
                                }
                            }
                            mainBaseurl = "";
                        }
                        _con.Individuals.AddRange(lstIndividual);
                        _con.SspformH3s.AddRange(lstFormH1);
                        _con.SaveChanges();
                    }
                }
                if (lstErrorRes.Any())
                {
                    r.status = false;
                    //var res = string.Join("", lstErrorRes);
                    if (successCounter > 0)
                    {
                        r.status = true;
                        r.message =lstErrorRes;
                    }
                    else
                        r.message = lstErrorRes;
                }
                return await Task.FromResult<IActionResult>(Ok(r));
            }
            else
            {
                r.status = false;
                r.message = "Error Occured Processing Wrong File";
                return await Task.FromResult<IActionResult>(Ok(r));
            }
        }
        catch (System.Exception ex)
        {
            AllFunction.SendErrorToText(ex);
            var res = new ReturnObject
            {
                status = false,
                message = $"{ex.Message} this is what i got from ERAS API {resp}"
            };
            return Ok(res);
        }
    }
    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("FileFormH3")]
    public async Task<IActionResult> FileFormH3([FromBody] FileFormH1 obj)
    {
        var r = new ReturnObject();
        try
        {
            var lst = new List<SspfiledFormH3>();
            var checker = _con.SspfiledFormH3s.FirstOrDefault(o => o.TaxYear == obj.TaxYear && o.CompanyId == obj.CompanyId && o.BusinessId == obj.BusinessId);
            if (checker != null)
            {
                r.status = false;
                r.message = $"record already filed for the year {obj.TaxYear}";
                return Ok(r);
            }
            var presDate = DateTime.UtcNow.Date;
            var lastDueDate = new DateTime(DateTime.UtcNow.Year, 1, 31);
            using var _context = new SelfServiceConnect();
            string query = $"SELECT s.Id,s.IndividualId,s.Startmonth, s.[BusinessId],s.[CompanyId],s.[TaxPayerId],s.[RIN],s.[PENSION],s.[NHF],s.[NHIS],\r\ns.[LIFEASSURANCE],s.[Rent],s.[Transport],s.[Basic],s.[OtherIncome],s.[datetcreated],s.[createdby],s.[datemodified], s.status, \r\ns.[modifiedby],A.AssetName,A.TaxPayerName \r\nFROM SSPFormH3s s   left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID and s.CompanyId = a.TaxPayerID\r\nwhere s.CompanyId = '{obj.CompanyId}' and s.BusinessId = '{obj.BusinessId}' and s.status = 1";
            var user = _context.SspformH3s.FromSqlRaw(query).ToList();
            foreach (var sr in user)
            {
                var empSr = new SspfiledFormH3
                {
                    BusinessId = sr.BusinessId,

                    CompanyId = sr.CompanyId,

                    TaxPayerId = sr.TaxPayerId,
                    Rin = sr.Rin,

                    Rent = sr.Rent,

                    Transport = sr.Transport,

                    Basic = sr.Basic,

                    OtherIncome = sr.OtherIncome,

                    Pension = sr.Pension,

                    Nhf = sr.Nhf,

                    Nhis = sr.Nhis,

                    Lifeassurance = sr.Lifeassurance,

                    Id = 0,
                    IndividalId = sr.IndividualId,
                    DueDate = $"31-January-{DateTime.UtcNow.Year + 1}",
                    ComplianceStatus = presDate > lastDueDate ? "2" : "1",
                    FiledStatus = ((int)ApprovalStatusEnum.Pending).ToString(),
                    TaxYear = obj.TaxYear,
                    Datetcreated = DateTime.UtcNow,
                    Createdby = sr.Createdby,

                    Datemodified = sr.Datemodified,

                    Modifiedby = sr.Modifiedby,
                };

                lst.Add(empSr);

            }
            _con.SspfiledFormH3s.AddRange(lst);
            _con.SaveChanges();
            r.status = true;
            r.message = "Record saved Successfully";

            return Ok(r);
        }
        catch (System.Exception ex)
        {
            AllFunction.SendErrorToText(ex);
            var res = new ReturnObject
            {
                status = false,
                data = ex.Message,
                message = ex.Message
            };
            return Ok(res);
        }
    }

    [HttpDelete]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("delete-TaxpayerH3bybusinessId/{businessId}/bycompanyId/{companyId}/byindividualId/{individualId}")]
    public async Task<IActionResult> deletetaxpayerH3([FromRoute] string businessId, [FromRoute] string companyId, [FromRoute] string individualId)
    {
        try
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Deleted Successfully";
            _ = _con.SspformH3s.Where(o => o.Id == Convert.ToInt64(individualId)
            && o.BusinessId == businessId
            && o.CompanyId == companyId).ExecuteDelete();
            // _ = res
            return Ok(r);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpDelete]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("delete-TaxpayerH3bybusinessId/{businessId}/bycompanyId/{companyId}")]
    public async Task<IActionResult> deletetaxpayerH3([FromRoute] string businessId, [FromRoute] string companyId)
    {
        try
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Deleted Successfully";
            r.data = _con.SspformH3s.Where(o => o.BusinessId == businessId && o.CompanyId == companyId).ExecuteDelete();
            return Ok(r);
        }
        catch (System.Exception ex)
        {
            return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    [NonAction]
    public string GetToken()
    {
        string URI = _serviceSettings.Value.ErasBaseUrl + "Account/Login";
        string user = _serviceSettings.Value.eirsusername;
        string password = _serviceSettings.Value.eirspassword;
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
    [NonAction]
    static int CalculateMonthsLeft(string monthName)
    {
        if (string.IsNullOrEmpty(monthName))
        {
            return 0;
        }
        string[] allMonths = new string[]
        {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
        };

        // Convert the month name to title case for case-insensitive comparison
        string inputMonth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName.ToLower());

        int currentMonthIndex = Array.IndexOf(allMonths, inputMonth);

        if (currentMonthIndex == -1)
        {
            return -1;
        }

        int monthsLeft = 12 - currentMonthIndex; // Subtract 1 to exclude the current month
        return monthsLeft;
    }
    [NonAction]
    public string CleanPhoneNumber(string phoneNumber)
    {
        if (phoneNumber.Length <= 10)
            return phoneNumber;
        // Check if the phone number starts with "+2340"
        if (phoneNumber.StartsWith("+2340"))
        {
            // Remove the first 5 characters ("+2340")
            return phoneNumber.Substring(5);
        }
        // Check if the phone number starts with "2340"
        else if (phoneNumber.StartsWith("2340"))
        {
            // Remove the first 4 characters ("2340")
            return phoneNumber.Substring(4);
        }
        // Check if the phone number starts with "0"
        else if (phoneNumber.StartsWith("0"))
        {
            // Remove the first character ("0")
            return phoneNumber.Substring(1);
        }
        // Return the phone number unchanged if no condition is met
        return phoneNumber;
    }

    [NonAction]
    static bool IsValidDecimalString(string input)
    {
        // Regular expression to allow only digits (0-9) and periods (.)
        return Regex.IsMatch(input, @"^[0-9.]+$");

    }

    static IDictionary<bool, string> IsValidDecimalStringForAll(List<string> dataList)
    {
        var ret = new Dictionary<bool, string>();
        for (int i = 0; i < dataList.Count(); i++)
        {
            if (!IsValidDecimalString(dataList[i]))
            {
                ret.Add(false, dataList[i]);
            }
        }
        return ret;
    }

    [NonAction]
    public async Task<string> CallAPi(string baseUrl, string st, string httpMethod, string? jsonData)
    {
        string res = "";
        HttpRequestMessage request = new();
        HttpResponseMessage response = new();
        var client = new HttpClient();
        switch (httpMethod.ToLower().Trim())
        {
            case "get":
                request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}");
                request.Headers.Add("Authorization", $"Bearer {st}");
                response = await client.SendAsync(request);
                res = await response.Content.ReadAsStringAsync();
                break;
            case "post":
                request = new HttpRequestMessage(HttpMethod.Post, baseUrl);
                request.Headers.Add("Authorization", $"Bearer {st}");
                var content = new StringContent(jsonData, null, "application/json");
                request.Content = content;
                response = await client.SendAsync(request);
                res = await response.Content.ReadAsStringAsync();
                break;
            default:
                break;
        }
        return res;
    }
}
