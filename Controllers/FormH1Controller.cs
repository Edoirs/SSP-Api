
namespace SelfPortalAPi.Controllers;

[Route("api/SSP/[controller]")]
[ApiController]
[Authorize]
public class FormH1Controller : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IOptions<ConnectionStrings> _serviceSettings;
    private readonly SelfServiceConnect _con;
    private readonly IPhaseIIRepo _repo;
    private readonly IHttpContextAccessor _httpContextAccessor;

    private string UserId = ""; private string TO_RIN = ""; private bool IsAdmin = false;

    public FormH1Controller(
        IOptions<ConnectionStrings> serviceSettings,
        IMapper mapper,
        IPhaseIIRepo repo,
        IHttpContextAccessor httpContextAccessor,
        SelfServiceConnect con
    )
    {
        _serviceSettings = serviceSettings;
        _mapper = mapper;
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
    [Route("getallformh1bycompanyId/{companyId}")]
    public async Task<IActionResult> getallformh1([FromRoute] string companyId, [FromQuery] int pageNumber = 1,
    [FromQuery] int pageSize = 100, [FromQuery] string busRin = null)
    {
        //IQueryable<Models.AssetTaxPayerDetailsApi> res;
        List<Models.AssetTaxPayerDetailsApi> res;
        var finalBusinessReturnModel = new List<BusinessReturnModel>();
        bool eget = false;
        try
        {
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
            foreach (var r in res)
            {
                var empCount = _con.SspformH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );

                var empCountDet = _con.SspfiledFormH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );
                BusinessReturnModel m = new();
                m.CompanyID = r.TaxPayerId.ToString();
                m.CompanyName = r.TaxPayerName;
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString();
                m.ProjectionYear =empCountDet.Count() > 0
                        ? empCountDet.FirstOrDefault().TaxYear.ToString()
                        : "0";
                m.NoOfEmployees = empCount.Count() > 0 ? empCount.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
                eget = true;
            }
            ReturnObject rd = new();
            rd.message = eget ? "Record Found Successfully" : "No Record Found";
            rd.data = eget ? new { result = finalBusinessReturnModel, totalCount = resData.Values.FirstOrDefault() } : null;
            rd.status = eget ? true : false;
            return Ok(rd);
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
    [Route("newgetallfiledformh1bycompanyId/{companyId}")]
    public async Task<IActionResult> newgetallfiledformh1([FromRoute] string companyId)
    {
        bool eget = false;
        try
        {
            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            var res = _con.AssetTaxPayerDetailsApis.Where(o =>
                o.TaxPayerId.ToString() == companyId
            );
            foreach (var r in res)
            {
                var empCountDet = _con.SspfiledFormH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString();
                m.ProjectionYear =
                    empCountDet.Count() > 0
                        ? empCountDet.FirstOrDefault().TaxYear.ToString()
                        : "0";
                m.NoOfEmployees = empCountDet.Count() > 0 ? empCountDet.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
                eget = true;
            }
            ReturnObject rd = new();
            rd.message = eget ? "Record Found Successfully" : "No Record Found";
            rd.data = eget ? finalBusinessReturnModel : null;
            rd.status = eget ? true : false;
            return Ok(rd);
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
    [Route("newgetallformh1bycompanyId/{companyId}")]
    public async Task<IActionResult> newgetallformh1([FromRoute] string companyId, [FromQuery] int pageNumber = 1,
    [FromQuery] int pageSize = 100)
    {
        IQueryable<Models.AssetTaxPayerDetailsApi> res;
        var finalBusinessReturnModel = new List<NewBusinessReturnModel>();
        bool eget = false;
        try
        {
            IDictionary<IQueryable<Models.AssetTaxPayerDetailsApi>, int> resData;
            if (IsAdmin)
                resData = await _repo.GetCompanyTiedToAdminUser(TO_RIN, true, pageNumber, pageSize);
            else
                resData = await _repo.GetCompanyTiedToAdminUser(companyId, false, pageNumber, pageSize);
            ReturnObject rd = new();

            res = resData.Keys.FirstOrDefault();

            foreach (var r in res)
            {
                var empCountDet = _con
                    .SspfiledFormH1s.Where(o =>
                        o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                    )
                    .GroupBy(o => o.TaxYear)
                    .ToList();

                foreach (var r2 in empCountDet)
                {
                    var jan31st = new DateTime(r2.Key.Value, 1, 31);
                    var m = new NewBusinessReturnModel
                    {
                        BusinessRIN = r.AssetRin,
                        CompanyRin = r.TaxPayerRinnumber,
                        CompanyId = r.TaxPayerId.ToString(),
                        CompanyName = r.TaxPayerName,
                        BusinessName = r.AssetName,
                        BusinessID = r.AssetId.ToString(),
                        TaxYear = r2.Key.ToString(),
                        DueDate = r2.FirstOrDefault().DueDate,
                        NoOfEmployees = r2.Count().ToString(),
                        DateForwarded = r2.FirstOrDefault().Datetcreated.ToString(),
                        AnnualReturnStatus =
                            r2.FirstOrDefault().Datetcreated > jan31st
                                ? "Defaulter"
                                : "Complied",
                    };

                    finalBusinessReturnModel.Add(m);
                }
            }
            rd.data = new { result = finalBusinessReturnModel, totalCount = resData.Values.FirstOrDefault() };
            rd.message = "Record Found succesfully";
            rd.status = true;
            return Ok(rd);
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
    [Route("getallformh1WithcompanyId/{companyId}")]
    public async Task<IActionResult> getformh1([FromRoute] string companyId)
    {
        bool eget = false;
        try
        {
            var getRin = _con.UserManagements.FirstOrDefault(o =>
                o.CompanyId == Convert.ToInt64(companyId)
            );

            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            var res = _con.AssetTaxPayerDetailsApis.Where(o =>
                o.TaxPayerRinnumber == getRin.CompanyRin
            );
            foreach (var r in res)
            {
                var empCount = _con.SspformH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );
                var empCountDet = _con.SspfiledFormH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString();
                m.ProjectionYear =
                    empCountDet.Count() > 0
                        ? empCountDet.FirstOrDefault().TaxYear.ToString()
                        : "0";
                m.NoOfEmployees = empCount.Count() > 0 ? empCount.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);

                eget = true;
            }
            ReturnObject rd = new();
            rd.message = eget ? "Record Found Successfully" : "No Record Found";
            rd.data = eget ? finalBusinessReturnModel : null;
            rd.status = eget ? true : false;
            return Ok(rd);
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

    [HttpPut]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("update-TaxpayerH1")]
    public async Task<IActionResult> updatetaxpayerH1([FromBody] TaxPayers obj)
    {
        try
        {
            var r = new ReturnObject { message = "Record Updated Successfully", status = true };
            var all = _con
                .SspformH1s.Where(o =>
                    o.TaxPayerId == obj.TaxPayerId
                    && o.BusinessId == obj.BusinessId
                    && o.CompanyId == obj.CompanyId
                )
                .FirstOrDefault();
            if (all == null)
            {
                return Ok(new ReturnObject { message = "User Not Found", status = false });
            }
            _ = _con
                .SspformH1s.Where(o =>
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
                        .SetProperty(
                            b => b.Consolidatedreliefallowancecra,
                            Convert.ToDecimal(obj.CONSOLIDATEDRELIEFALLOWANCECRA)
                        )
                        .SetProperty(b => b.Annualtaxpaid, Convert.ToDecimal(obj.ANNUALTAXPAID))
                        .SetProperty(
                            b => b.Totalmonthspaid,
                            Convert.ToDecimal(obj.TOTALMONTHSPAID)
                        )
                        .SetProperty(b => b.Rent, Convert.ToDecimal(obj.Rent))
                        .SetProperty(b => b.Transport, Convert.ToDecimal(obj.Transport))
                        .SetProperty(b => b.Basic, Convert.ToDecimal(obj.Basic))
                );
            _ = _con
                .Individuals.Where(o => o.Id == Convert.ToInt32(all.IndividalId))
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
                        .SetProperty(b => b.Homeaddress, obj.HOMEADDRESS)
                );
            return Ok(r);
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
    [Route("getallformh1bycompanyId/{companyId}/bybusinessId/{businessId}")]
    public async Task<IActionResult> getallformh1bybusinessId(
        [FromRoute] string companyId,
        [FromRoute] string businessId
    )
    {
        try
        {
            var getRin = _con.UserManagements.FirstOrDefault(o =>
                o.CompanyId == Convert.ToInt64(companyId)
            );

            var finalBusinessReturnModel = new List<BusinessReturnModel>();
            var res = _con.AssetTaxPayerDetailsApis.Where(o =>
                o.TaxPayerRinnumber == getRin.CompanyRin

                && o.AssetId == Convert.ToInt32(businessId)
            );
            foreach (var r in res)
            {
                var empCountDet = _con.SspformH1s.Where(o =>
                    o.BusinessId == r.AssetId.ToString() && o.CompanyId == companyId
                );
                BusinessReturnModel m = new();
                m.BusinessRIN = r.AssetRin;
                m.BusinessAddress = r.AssetAddress;
                m.BusinessName = r.AssetName;
                m.BusinessID = r.AssetId.ToString();
                m.NoOfEmployees =
                    empCountDet.Count() > 0 ? empCountDet.Count().ToString() : "0";
                finalBusinessReturnModel.Add(m);
            }
            return Ok(finalBusinessReturnModel);
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
    [Route("getalluplaodedformh1bycompanyId/{companyId}/bybusinessId/{businessId}")]
    public async Task<IActionResult> getalluplaodedformh1bybusinessId(
        [FromRoute] string companyId,
        [FromRoute] string businessId
    )
    {
        try
        {
            using var _context = new SelfServiceConnect();
            string query =
                $"SELECT s.[IndividalId], s.[BusinessId],I.FIRSTNAME, I.SURNAME,I.Designation,I.NATIONALITY,s.[CompanyId],(s.[Rent] + s.[Basic] +s.[OTHERINCOME]+s.[TRANSPORT]) as Total,\r\ns.[TaxPayerId],s.[Id],s.[RIN],s.[PENSION],s.[NHF],s.[NHIS],s.[LIFEASSURANCE],s.[CONSOLIDATEDRELIEFALLOWANCECRA],s.[ANNUALTAXPAID],s.[TOTALMONTHSPAID],s.[Rent],s.[Transport],s.[Basic],s.[OtherIncome],s.[datetcreated],s.[createdby],s.[datemodified],s.[modifiedby], A.AssetName as BusinessName ,A.TaxPayerName as CompanyName FROM [SSPFormH1s] s left join AssetTaxPayerDetails_API A on  s.BusinessId  =  A.AssetID and s.CompanyId = a.TaxPayerID left join Individual I on s.IndividalId = I.EmployeeId  where s.CompanyId = '{companyId}' and s.BusinessId = '{businessId}'";
            var user = _context.ReturnSspformH1.FromSqlRaw(query).ToList();
            return Ok(user);
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
    [Route("getallfiledformh1bycompanyId/{companyId}")]
    public async Task<IActionResult> getallfiledformh1bycompanyId([FromRoute] string companyId)
    {
        var r = new ReturnObject();
        try
        {
            using var _context = new SelfServiceConnect();
            var query =
                $"SELECT  S.[Id],[BusinessId],[CompanyId],S.[TaxPayerId],A.AssetName,s.[IndividalId],s.[RIN],[PENSION],  B.FirstName + ' ' + B.OTHERNAME + ' ' + B.SURNAME AS FullName,[NHF],[NHIS],[LIFEASSURANCE],[CONSOLIDATEDRELIEFALLOWANCECRA],[ANNUALTAXPAID],[TOTALMONTHSPAID],[Rent],[Transport],[Basic],[OtherIncome],[FiledStatus],[TaxYear],[DueDate],[ComplianceStatus] ,s.createdby   ,s.datemodified,s.datetcreated,s.modifiedby  FROM [SSPFiledFormH1s] s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID left join Individual B on s.IndividalId = B.EmployeeId  where  s.CompanyId='{companyId}'";
            var user = _context.SspfiledFormH1ForSPs.FromSqlRaw(query).ToList();
            r.data = user;
            r.status = true;
            r.message = "Record Fetched Successfully";

            return Ok(r);
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
    [Route("getallfiledformh1bycompanyIdfornewscreen/{companyId}")]
    public async Task<IActionResult> getallfiledformh1bycompanyIdfornewscreen(
        [FromRoute] string companyId
    )
    {
        var r = new ReturnObject();
        try
        {
            var getRin = _con.UserManagements.FirstOrDefault(o =>
                o.CompanyId == Convert.ToInt64(companyId)
            );

            var res = _con.AssetTaxPayerDetailsApis.Where(o =>
                o.TaxPayerRinnumber == getRin.CompanyRin
            );
            var kkkk = new List<SspfiledFormH1ForSP>();
            using var _context = new SelfServiceConnect();
            var query1 =
                $"SELECT top(1) S.[Id],[BusinessId],[CompanyId],S.[TaxPayerId],A.AssetName,s.[IndividalId],s.[RIN],[PENSION],  B.FirstName + ' ' + B.OTHERNAME + ' ' + B.SURNAME AS FullName,[NHF],[NHIS],[LIFEASSURANCE],[CONSOLIDATEDRELIEFALLOWANCECRA],[ANNUALTAXPAID],[TOTALMONTHSPAID],[Rent],[Transport],[Basic],[OtherIncome],[FiledStatus],[TaxYear],[DueDate],[ComplianceStatus] ,s.createdby   ,s.datemodified,s.datetcreated,s.modifiedby  FROM [SSPFiledFormH1s] s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID left join Individual B on s.IndividalId = B.EmployeeId where  s.CompanyId='{companyId}'";
            var user1 = _context.SspfiledFormH1ForSPs.FromSqlRaw(query1).ToList();
            var query =
                $"select distinct (TaxYear)FROM [SSPFiledFormH1s] where CompanyId='{companyId}'";
            var user = _context.SspfiledFormH1ListOfYears.FromSqlRaw(query).ToList();
            foreach (var it in user)
            {
                var empCountDet = _con.SspformH1s.Where(o => o.CompanyId == companyId);

                SspfiledFormH1ForSP sp = new SspfiledFormH1ForSP();
                sp.AssetName = user1.FirstOrDefault().AssetName;
                sp.BusinessName = user1.FirstOrDefault().BusinessName;
                sp.CompanyId = companyId;
                sp.TaxYear = it.TaxYear;
                sp.TaxPayerId = user1.FirstOrDefault().TaxPayerId;
            }
            r.data = user;
            r.status = true;
            r.message = "Record Fetched Successfully";

            return Ok(r);
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
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getallfiledformh1bycompanyId/{companyId}/bybusinessId/{businessId}/byyear/{year}")]
    public async Task<IActionResult> getallfiledformh1bybusinessIdbyyear(
        [FromRoute] string companyId,
        [FromRoute] string businessId,
        [FromRoute] string year
    )
    {
        var r = new ReturnObject();
        try
        {
            using var _context = new SelfServiceConnect();
            var query =
                $"SELECT  S.[Id],[BusinessId],[CompanyId],S.[TaxPayerId],A.AssetName,s.[IndividalId],s.[RIN],B.FirstName + ' ' + B.SURNAME AS FullName,([Rent]+ [Transport]+ [Basic]+[OtherIncome]) as totalIncome,\r\n([NHF] + [NHIS] + [LIFEASSURANCE] +[CONSOLIDATEDRELIEFALLOWANCECRA]) as TaxFreePay, [ANNUALTAXPAID], CASE WHEN [TOTALMONTHSPAID] = 0 THEN 12 ELSE [TOTALMONTHSPAID] END as Totalmonthspaid , [FiledStatus],[TaxYear],[DueDate],[ComplianceStatus] ,s.createdby, s.datemodified,s.datetcreated, s.modifiedby  FROM [SSPFiledFormH1s] s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID \r\nleft join Individual B on s.IndividalId = B.EmployeeId     where s.BusinessId = '{businessId}' and s.CompanyId='{companyId}' and TaxYear = '{year}'";
            var user = _context.SspfiledFormH1ForSPs.FromSqlRaw(query).ToList();
            r.data = user;
            r.status = true;
            r.message = "Record Fetched Successfully";

            return Ok(r);
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

    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("UploadFormH1")]
    public async Task<IActionResult> UploadFormH1([FromForm] AddFormH obj)
    {
        var lstErrorRes = new List<string>();
        string errorNote = "There Is An Error On Row";
        var r = new ReturnObject();
        var baseUrl = _serviceSettings.Value.ErasBaseUrl;
        string mainBaseurl = "";
        JavaScriptSerializer js = new();
        var resp = "";
        List<SspformH1> lstFormH1 = new();
        List<Individual> lstIndividual = new();
        Receiver rootobjectVm = new();
        AllFunction af = new AllFunction();
        try
        {
            var la = new List<FormH1FM>();
            r.status = true;
            r.message = "Record saved Successfully";
            if (obj.File != null && obj.File.Length > 0)
            {
                var table = AllFunction.ConvertExcelToDatatable(obj.File);
                la = AllFunction.ConvertDataTable<FormH1FM>(table);
                la = la.Where(o => o.FIRSTNAME != "NULL").ToList();

                if (la.Count > 0)
                {
                    for (int i = 0; i < la.Count(); i++)
                    {
                        if (
                            (
                                string.IsNullOrEmpty(la[i].PHONENUMBER)
                                || la[i].PHONENUMBER == "NULL" || la[i].PHONENUMBER.Length > 15
                            )
                            && (string.IsNullOrEmpty(la[i].RIN) || la[i].RIN == "NULL")
                            && (string.IsNullOrEmpty(la[i].JTBTIN) || la[i].JTBTIN == "NULL")
                        )
                        {
                            lstErrorRes.Add(
                                $"{errorNote} in row {i + 1}. Please Provide PHONENUMBER or RIN or TIN."
                            );
                        }
                    }
                    if (lstErrorRes.Any())
                    {
                        var res = string.Join(";", lstErrorRes);
                        r.status = false;
                        r.message = $"{res}";
                        return await Task.FromResult<IActionResult>(Ok(r));
                    }
                    var token = af.GetToken(
                        _serviceSettings.Value.ErasBaseUrl,
                        _serviceSettings.Value.eirsusername,
                        _serviceSettings.Value.eirspassword
                    );
                    if (token != null)
                    {
                        for (int i = 0; i < la.Count(); i++)
                        {
                            var fm = la[i];
                            string phone = CleanPhoneNumber(fm.PHONENUMBER);
                            if (phone != "NULL")
                            {
                                mainBaseurl =
                                    $"{baseUrl}TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber={phone}";
                                resp = await af.CallAPi(mainBaseurl, token, "get", "");
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                            }
                            else if (fm.RIN != "NULL")
                            {
                                mainBaseurl = $"{baseUrl}TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN={fm.RIN}";
                                resp = await af.CallAPi(mainBaseurl, token, "get", "");
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                            }
                            else if (fm.JTBTIN != "NULL")
                            {
                                mainBaseurl =
                                    $"{baseUrl}TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN={fm.JTBTIN}";
                                resp = await af.CallAPi(mainBaseurl, token, "get", "");
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                            }
                            else
                            {
                                lstErrorRes.Add(
                                    $"{errorNote} in row {i + 1} Provide PHONENUMBER or RIN or TIN."
                                );
                            }

                            if (rootobjectVm.Result.Count <= 0)
                            {
                                if (phone != "NULL")
                                {
                                    mainBaseurl = $"{baseUrl}TaxPayer/Individual/PayeInsert";
                                    AddTaxPayer ad = new();
                                    ad.TaxPayerTypeId = 1;
                                    ad.GenderID = 1;
                                    ad.TitleID = 2;
                                    ad.FirstName = fm.FIRSTNAME;
                                    ad.LastName = fm.SURNAME;
                                    ad.MiddleName = fm.OTHERNAME;
                                    ad.DOB = "01/01/2004";
                                    ad.TIN = fm.JTBTIN;
                                    ad.MobileNumber1 = phone;
                                    ad.EmailAddress1 = "abc@gmail.com";
                                    ad.BiometricDetails = "";
                                    ad.TaxOfficeID = 34;
                                    ad.NewTaxOfficeID = 34;
                                    ad.PresentTaxOfficeID = 34;
                                    ad.MaritalStatusID = 3;
                                    ad.NationalityID = 1;
                                    ad.EconomicActivitiesID = 1;
                                    ad.NotificationMethodID = 1;
                                    ad.ContactAddress = fm.HOMEADDRESS;
                                    string jsonData = js.Serialize(ad);
                                    resp = await af.CallAPi(
                                        mainBaseurl,
                                        token,
                                        "post",
                                        jsonData
                                    );
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (fm.PHONENUMBER != "NULL")
                                        {
                                            baseUrl =
                                                baseUrl
                                                + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber="
                                                + fm.PHONENUMBER;
                                        }
                                        else if (fm.RIN != "NULL")
                                        {
                                            baseUrl =
                                                baseUrl
                                                + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN="
                                                + fm.RIN;
                                        }
                                        else if (fm.JTBTIN != "NULL")
                                        {
                                            baseUrl =
                                                baseUrl
                                                + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN="
                                                + fm.JTBTIN;
                                        }
                                        resp = await af.CallAPi(baseUrl, token, "get", "");
                                        rootobjectVm = js.Deserialize<Receiver>(resp);
                                        if (rootobjectVm.Success == true)
                                        {
                                            if (rootobjectVm.Result.Count > 0)
                                            {
                                                var sp = new Individual
                                                {
                                                    EmployeeId = rootobjectVm.Result.FirstOrDefault()
                                                        .TaxPayerID.ToString(),
                                                    Firstname = fm.FIRSTNAME,
                                                    Surname = fm.SURNAME,
                                                    Othername = fm.OTHERNAME,
                                                    Phonenumber = rootobjectVm
                                                        .Result.FirstOrDefault()
                                                        .TaxPayerMobileNumber.ToString(),
                                                    EmployeeRin = rootobjectVm
                                                        .Result.FirstOrDefault()
                                                        .TaxPayerRIN.ToString(),
                                                    Jtbtin = fm.JTBTIN,
                                                    Nin = fm.NIN,
                                                    Nationality = fm.NATIONALITY,
                                                    Homeaddress = fm.HOMEADDRESS,
                                                    Designation = fm.Designation,
                                                    Datetcreated = DateTime.UtcNow,
                                                    Datemodified = DateTime.UtcNow,
                                                };
                                                lstIndividual.Add(sp);
                                                lstFormH1.Add(
                                                    new SspformH1
                                                    {
                                                        BusinessId = obj.BusinessId,
                                                        CompanyId = obj.CompanyId,
                                                        TaxPayerId = rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerID.ToString(),
                                                        IndividalId = rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerID.ToString(),
                                                        Rin = rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerRIN.ToString(),
                                                        Pension =
                                                            fm.PENSION != "NULL"
                                                                ? Convert.ToDecimal(fm.PENSION)
                                                                : 0,
                                                        Nhf =
                                                            fm.NHF != "NULL"
                                                                ? Convert.ToDecimal(fm.NHF)
                                                                : 0,
                                                        Nhis =
                                                            fm.NHIS != "NULL"
                                                                ? Convert.ToDecimal(fm.NHIS)
                                                                : 0,
                                                        Lifeassurance =
                                                            fm.LIFEASSURANCE != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.LIFEASSURANCE
                                                                )
                                                                : 0,
                                                        Consolidatedreliefallowancecra =
                                                            fm.CONSOLIDATEDRELIEFALLOWANCECRA
                                                            != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.CONSOLIDATEDRELIEFALLOWANCECRA
                                                                )
                                                                : 0,
                                                        Annualtaxpaid =
                                                            fm.ANNUALTAXPAID != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.ANNUALTAXPAID
                                                                )
                                                                : 0,
                                                        Totalmonthspaid =
                                                            fm.TOTALMONTHSPAID != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.TOTALMONTHSPAID
                                                                )
                                                                : 0,
                                                        Rent =
                                                            fm.Rent != "NULL"
                                                                ? Convert.ToDecimal(fm.Rent)
                                                                : 0,
                                                        Transport =
                                                            fm.Transport != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.Transport
                                                                )
                                                                : 0,
                                                        Basic =
                                                            fm.Basic != "NULL"
                                                                ? Convert.ToDecimal(fm.Basic)
                                                                : 0,
                                                        OtherIncome =
                                                            fm.OtherIncome != "NULL"
                                                                ? Convert.ToDecimal(
                                                                    fm.OtherIncome
                                                                )
                                                                : 0
                                                    }
                                                );
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (rootobjectVm.Success == true)
                                {
                                    var res = _con.Individuals.FirstOrDefault(o =>
                                        o.EmployeeId
                                            == rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerID.ToString()
                                        && o.EmployeeRin
                                            == rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerRIN.ToString()
                                    );
                                    if (res != null)
                                    {
                                        _con.Individuals.Where(o =>
                                            o.EmployeeId
                                            == rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerID.ToString()
                                        )
                                            .ExecuteUpdate(obj =>
                                                obj.SetProperty(b => b.Firstname, fm.FIRSTNAME)
                                                    .SetProperty(b => b.Surname, fm.SURNAME)
                                                    .SetProperty(b => b.Othername, fm.OTHERNAME)
                                                    .SetProperty(
                                                        b => b.Phonenumber,
                                                        rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerMobileNumber.ToString()
                                                    )
                                                    .SetProperty(
                                                        b => b.EmployeeRin,
                                                        rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerRIN.ToString()
                                                    )
                                                    .SetProperty(b => b.Jtbtin, fm.JTBTIN)
                                                    .SetProperty(b => b.Nin, fm.NIN)
                                                    .SetProperty(
                                                        b => b.Nationality,
                                                        fm.NATIONALITY
                                                    )
                                                    .SetProperty(
                                                        b => b.Homeaddress,
                                                        fm.HOMEADDRESS
                                                    )
                                                    .SetProperty(
                                                        b => b.Designation,
                                                        fm.Designation
                                                    )
                                            );
                                    }
                                    else
                                    {
                                        var sp = new Individual
                                        {
                                            EmployeeId = rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerID.ToString(),
                                            Firstname = fm.FIRSTNAME,
                                            Surname = fm.SURNAME,
                                            Othername = fm.OTHERNAME,
                                            Phonenumber = rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerMobileNumber.ToString(),
                                            EmployeeRin = rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerRIN.ToString(),
                                            Jtbtin = fm.JTBTIN,
                                            Nin = fm.NIN,
                                            Nationality = fm.NATIONALITY,
                                            Homeaddress = fm.HOMEADDRESS,
                                            Designation = fm.Designation,
                                            Datetcreated = DateTime.UtcNow,
                                            Datemodified = DateTime.UtcNow,
                                        };
                                        lstIndividual.Add(sp);
                                    }
                                    var resForm = _con.SspformH1s.FirstOrDefault(o =>
                                        o.IndividalId
                                            == rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerID.ToString()
                                        && o.Rin
                                            == rootobjectVm
                                                .Result.FirstOrDefault()
                                                .TaxPayerRIN.ToString()
                                        && o.BusinessId == obj.BusinessId
                                        && o.CompanyId == obj.CompanyId
                                    );
                                    if (resForm != null)
                                    {
                                        _con.SspformH1s.Where(o =>
                                            o.IndividalId
                                                == rootobjectVm
                                                    .Result.FirstOrDefault()
                                                    .TaxPayerID.ToString()
                                            && o.Rin
                                                == rootobjectVm
                                                    .Result.FirstOrDefault()
                                                    .TaxPayerRIN.ToString()
                                        )
                                            .ExecuteUpdate(obj =>
                                                obj.SetProperty(
                                                        b => b.TaxPayerId,
                                                        rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerID.ToString()
                                                    )
                                                    .SetProperty(
                                                        b => b.Rin,
                                                        rootobjectVm
                                                            .Result.FirstOrDefault()
                                                            .TaxPayerRIN.ToString()
                                                    )
                                                    .SetProperty(
                                                        b => b.Pension,
                                                        fm.PENSION != "NULL"
                                                            ? Convert.ToDecimal(fm.PENSION)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Nhf,
                                                        fm.NHF != "NULL"
                                                            ? Convert.ToDecimal(fm.NHF)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Nhis,
                                                        fm.NHIS != "NULL"
                                                            ? Convert.ToDecimal(fm.NHIS)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Lifeassurance,
                                                        fm.LIFEASSURANCE != "NULL"
                                                            ? Convert.ToDecimal(
                                                                fm.LIFEASSURANCE
                                                            )
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Consolidatedreliefallowancecra,
                                                        fm.CONSOLIDATEDRELIEFALLOWANCECRA
                                                        != "NULL"
                                                            ? Convert.ToDecimal(
                                                                fm.CONSOLIDATEDRELIEFALLOWANCECRA
                                                            )
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Annualtaxpaid,
                                                        fm.ANNUALTAXPAID != "NULL"
                                                            ? Convert.ToDecimal(
                                                                fm.ANNUALTAXPAID
                                                            )
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Totalmonthspaid,
                                                        fm.TOTALMONTHSPAID != "NULL"
                                                            ? Convert.ToDecimal(
                                                                fm.TOTALMONTHSPAID
                                                            )
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Rent,
                                                        fm.Rent != "NULL"
                                                            ? Convert.ToDecimal(fm.Rent)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Transport,
                                                        fm.Transport != "NULL"
                                                            ? Convert.ToDecimal(fm.Transport)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.Basic,
                                                        fm.Basic != "NULL"
                                                            ? Convert.ToDecimal(fm.Basic)
                                                            : 0
                                                    )
                                                    .SetProperty(
                                                        b => b.OtherIncome,
                                                        fm.OtherIncome != "NULL"
                                                            ? Convert.ToDecimal(fm.OtherIncome)
                                                            : 0
                                                    )
                                            );
                                    }
                                    else
                                    {
                                        lstFormH1.Add(
                                            new SspformH1
                                            {
                                                BusinessId = obj.BusinessId,
                                                CompanyId = obj.CompanyId,
                                                TaxPayerId = rootobjectVm
                                                    .Result.FirstOrDefault()
                                                    .TaxPayerID.ToString(),
                                                IndividalId = rootobjectVm
                                                    .Result.FirstOrDefault()
                                                    .TaxPayerID.ToString(),
                                                Rin = rootobjectVm
                                                    .Result.FirstOrDefault()
                                                    .TaxPayerRIN.ToString(),
                                                Pension =
                                                    fm.PENSION != "NULL"
                                                        ? Convert.ToDecimal(fm.PENSION)
                                                        : 0,
                                                Nhf =
                                                    fm.NHF != "NULL"
                                                        ? Convert.ToDecimal(fm.NHF)
                                                        : 0,
                                                Nhis =
                                                    fm.NHIS != "NULL"
                                                        ? Convert.ToDecimal(fm.NHIS)
                                                        : 0,
                                                Lifeassurance =
                                                    fm.LIFEASSURANCE != "NULL"
                                                        ? Convert.ToDecimal(fm.LIFEASSURANCE)
                                                        : 0,
                                                Consolidatedreliefallowancecra =
                                                    fm.CONSOLIDATEDRELIEFALLOWANCECRA != "NULL"
                                                        ? Convert.ToDecimal(
                                                            fm.CONSOLIDATEDRELIEFALLOWANCECRA
                                                        )
                                                        : 0,
                                                Annualtaxpaid =
                                                    fm.ANNUALTAXPAID != "NULL"
                                                        ? Convert.ToDecimal(fm.ANNUALTAXPAID)
                                                        : 0,
                                                Totalmonthspaid =
                                                    fm.TOTALMONTHSPAID != "NULL"
                                                        ? Convert.ToDecimal(fm.TOTALMONTHSPAID)
                                                        : 0,
                                                Rent =
                                                    fm.Rent != "NULL"
                                                        ? Convert.ToDecimal(fm.Rent)
                                                        : 0,
                                                Transport =
                                                    fm.Transport != "NULL"
                                                        ? Convert.ToDecimal(fm.Transport)
                                                        : 0,
                                                Basic =
                                                    fm.Basic != "NULL"
                                                        ? Convert.ToDecimal(fm.Basic)
                                                        : 0,
                                                OtherIncome =
                                                    fm.OtherIncome != "NULL"
                                                        ? Convert.ToDecimal(fm.OtherIncome)
                                                        : 0
                                            }
                                        );
                                    }
                                }
                            }
                            mainBaseurl = "";
                        }
                        _con.Individuals.AddRange(lstIndividual);
                        _con.SspformH1s.AddRange(lstFormH1);
                        _con.SaveChanges();
                    }
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
                data = ex.InnerException.Message,
                message = ex.Message
            };
            return Ok(res);
        }
    }

    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("FileFormH1")]
    public async Task<IActionResult> FileFormH1([FromBody] FileFormH1 obj)
    {
        var r = new ReturnObject();
        try
        {
            if (obj.TaxYear == DateTime.UtcNow.Year)
            {
                r.status = false;
                r.message = $"You cant file for curent year";
                return Ok(r);
            }
            var lst = new List<SspfiledFormH1>();
            var checker = _con.SspfiledFormH1s.FirstOrDefault(o =>
                o.TaxYear == obj.TaxYear
                && o.CompanyId == obj.CompanyId
                && o.BusinessId == obj.BusinessId
            );
            if (checker != null)
            {
                r.status = false;
                r.message = $"record already filed for the year {obj.TaxYear}";
                return Ok(r);
            }
            var presDate = DateTime.UtcNow.Date;
            var lastDueDate = new DateTime(DateTime.UtcNow.Year, 1, 31);
            using var _context = new SelfServiceConnect();
            string query =
                $"SELECT s.Id, s.[BusinessId],s.[CompanyId],s.[TaxPayerId],s.[IndividalId],s.[RIN],s.[PENSION],s.[NHF],s.[NHIS],s.[LIFEASSURANCE],s.[CONSOLIDATEDRELIEFALLOWANCECRA],s.[ANNUALTAXPAID],s.[TOTALMONTHSPAID],s.[Rent],s.[Transport],s.[Basic],s.[OtherIncome],s.[datetcreated],s.[createdby],s.[datemodified],s.[modifiedby],A.AssetName,A.TaxPayerName  FROM SSPFormH1s s  left join AssetTaxPayerDetails_API A on s.BusinessId = A.AssetID where CompanyId = '{obj.CompanyId}' and BusinessId = '{obj.BusinessId}'";
            var user = _context.SspformH1s.FromSqlRaw(query).ToList();
            foreach (var sr in user)
            {
                var empSr = _mapper.Map<SspfiledFormH1>(sr);
                empSr.Id = 0;
                empSr.DueDate = $"31-January-{obj.TaxYear + 1}";
                empSr.ComplianceStatus = presDate > lastDueDate ? "Defaulted" : "Complied";
                empSr.FiledStatus = ((int)ApprovalStatusEnum.Pending).ToString();
                empSr.TaxYear = obj.TaxYear;
                empSr.Datetcreated = DateTime.UtcNow;
                lst.Add(empSr);
            }
            _con.SspfiledFormH1s.AddRange(lst);
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
                data = ex.InnerException.Message,
                message = ex.Message
            };
            return Ok(res);
        }
    }

    [HttpDelete]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route(
        "delete-TaxpayerH1bybusinessId/{businessId}/bycompanyId/{companyId}/byindividualId/{individualId}"
    )]
    public async Task<IActionResult> deletetaxpayerH1(
        [FromRoute] string businessId,
        [FromRoute] string companyId,
        [FromRoute] string individualId
    )
    {
        try
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Deleted Successfully";
            r.data = _con
                .SspformH1s.Where(o =>
                    o.IndividalId == individualId
                    && o.BusinessId == businessId
                    && o.CompanyId == companyId
                )
                .ExecuteDelete();
            return Ok(r);
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

    [HttpDelete]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("delete-TaxpayerH1bybusinessId/{businessId}/bycompanyId/{companyId}")]
    public async Task<IActionResult> deletetaxpayerH1(
        [FromRoute] string businessId,
        [FromRoute] string companyId
    )
    {
        try
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Deleted Successfully";
            r.data = _con
                .SspformH1s.Where(o => o.BusinessId == businessId && o.CompanyId == companyId)
                .ExecuteDelete();
            return Ok(r);
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

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

    // [NonAction]
    // public async Task<string> CallAPi(
    //     string baseUrl,
    //     string st,
    //     string httpMethod,
    //     string? jsonData
    // )
    // {
    //     string res = "";
    //     HttpRequestMessage request = new();
    //     HttpResponseMessage response = new();
    //     var client = new HttpClient();
    //     switch (httpMethod.ToLower().Trim())
    //     {
    //         case "get":
    //             request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}");
    //             request.Headers.Add("Authorization", $"Bearer {st}");
    //             response = await client.SendAsync(request);
    //             res = await response.Content.ReadAsStringAsync();
    //             break;
    //         case "post":
    //             request = new HttpRequestMessage(HttpMethod.Post, baseUrl);
    //             request.Headers.Add("Authorization", $"Bearer {st}");
    //             var content = new StringContent(jsonData, null, "application/json");
    //             request.Content = content;
    //             response = await client.SendAsync(request);
    //             res = await response.Content.ReadAsStringAsync();
    //             break;
    //         default:
    //             break;
    //     }
    //     return res;
    // }
}