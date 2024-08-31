﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Nancy.Diagnostics;
using Nancy.Json;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.Models;
using SelfPortalAPi.NewModel;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;
using System.Drawing;
using System.Net;
using System.Threading.RateLimiting;
using static SelfPortalAPi.AllFunction;
using AssetTaxPayerDetailsApi = SelfPortalAPi.Models.AssetTaxPayerDetailsApi;
using EmployeesMonthlyIncome = SelfPortalAPi.Models.EmployeesMonthlyIncome;
using EmployeesMonthlySchedule = SelfPortalAPi.Models.EmployeesMonthlySchedule;
using Individual = SelfPortalAPi.Models.Individual;
using SelfPortalAPi.PhaseIIVm;
using System.Linq;
using static Azure.Core.HttpHeader;
using Bogus;
using SelfPortalAPi.Model;
using SelfPortalAPi.Vm;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Html;
using PuppeteerSharp;
using Grpc.Core;
using Bogus.DataSets;
using System.ComponentModel.Design;
using static QuestPDF.Helpers.Colors;


namespace SelfPortalAPi.Controllers.PhaseIIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhaseIIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPhaseIIRepo _phaseIIRepo;
        private readonly SelfServiceConnect _repo;
        private readonly PhaseBenchMark _phaseBench;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOptions<ConnectionStrings> _serviceSettings;
       
        private string errMsg = "Unable to process request, kindly try again";


        public PhaseIIController(IMapper mapper, SelfServiceConnect repo, IPhaseIIRepo repos, PhaseBenchMark phaseBench, IHttpContextAccessor httpContextAccessor, IOptions<ConnectionStrings> serviceSettings)
        {
            _repo = repo;
            _mapper = mapper;
            _phaseIIRepo = repos;
            _phaseBench = phaseBench;
            _httpContextAccessor = httpContextAccessor;
            _serviceSettings = serviceSettings;
            
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetallBusinesses")]
        public async Task<IActionResult> GetAllBusinesses([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100)
        {
            var r = new ReturnObject();
            var BusinessList = new List<BusinessRinVm>();
            var businesses = new BusinessRinVm();
            r.status = true;
            r.message = "Records Fetched Successfully";
            try
            {
                var ret = await _phaseIIRepo.GetAllBusinessesAsync(pageNumber, pageSize);
                var ret2 = await _repo.AssetTaxPayerDetailsApis.CountAsync();

                var result = new CombinedResult
                {
                    Businesses = ret,
                    TotalCount = ret2
                };

                r.data = result;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetallBusinessEmployees")]
        public async Task<IActionResult> GetAllBusinessEmployees([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100)
        {
            var r = new ReturnObject();
            var BusinessList = new List<BusinessRinVm>();
            var businesses = new BusinessRinVm();
            r.status = true;
            r.message = "Records Fetched Successfully";
            try
            {
                var ret = await _phaseIIRepo.getallEmployeesCount(pageNumber, pageSize);
                var ret2 = await _repo.AssetTaxPayerDetailsApis.CountAsync();

                var result = new CombinedResult2
                {
                    Businesses = ret,
                    TotalCount = ret2
                };

                r.data = result;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetBussinessEmployeesByRin")]
        public async Task<IActionResult> GetBussinessEmployeesByRin([FromQuery][Required] string businessRin, [FromQuery][Required] string companyRin)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";

            if (string.IsNullOrEmpty(businessRin) || string.IsNullOrEmpty(companyRin))
            {
                r.status = false;
                r.message = "All Fields are Required and Cannot Be Null or Empty.";
            }

            try
            {
                var buss = GetBusinessCompanyId(businessRin, companyRin);

                var emp = new EmployeesViewFmModel
                {
                    BusinessId = buss.Result.BusinessId,
                    CompanyId = buss.Result.Companyid
                };

                var ret = await _phaseIIRepo.GetEmployeeIncomeView(emp);
                r.data = ret;
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

        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("UpdateEmployeeIncome")]
        public async Task<IActionResult> UpdateEmployeeIncome([FromBody] UpdateEmpIncome1 obj)
        {
            try
            {
                var r = new ReturnObject { message = "Record Updated Successfully", status = true };
                if (obj != null)
                {
                    var buss = await GetBusinessCompanyId(obj.BusinessRin, obj.CompanyRin);
                    if (buss != null)
                    {
                        var Indiv = await _repo.Individuals.Where(x => x.EmployeeRin == obj.EmployeeRin).ToListAsync();
                        if (Indiv != null)
                        {
                            foreach (var Ind in Indiv)
                            {
                                var mrk = await _repo.EmployeesMonthlyIncomes
                                  .Where(e => e.BusinessId == buss.BusinessId && e.EmployeeId == Ind.EmployeeId && e.CompanyId == buss.Companyid)
                                  .ExecuteUpdateAsync(
                                        setters =>
                                            setters
                                            .SetProperty(b => b.Basic, obj.Basic)
                                            .SetProperty(b => b.Rent, Convert.ToDecimal(obj.Rent))
                                            .SetProperty(b => b.Transport, obj.Transport)
                                            .SetProperty(b => b.Meal, obj.Meal)
                                            .SetProperty(b => b.Ltg, obj.Ltg)
                                            .SetProperty(b => b.Utility, obj.Utility)
                                            .SetProperty(b => b.Others, obj.Others)
                                                .SetProperty(b => b.Nhf, obj.Nhf)
                                            .SetProperty(b => b.Pension, obj.Pension)
                                            .SetProperty(b => b.Nhis, obj.Nhis)
                                            .SetProperty(b => b.LifeAssurance, obj.LifeAssurance)
                                            );

                            }
                        }
                        r.data = Indiv;

                    }
                    if (buss == null)
                    {
                        return NotFound(new ReturnObject { message = "Employee or Company Not Found", status = false });
                    }

                }
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
        [Route("UploadEmployees")]
        public async Task<IActionResult> UploadEmployees([FromForm] AddFormEmployee emp)
        {
            var r = new ReturnObject();
            var lstErrorRes = new List<string>();
            string errorNote = "There Is An Error On Row";
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;
            var resp = "";
            List<EmployeesMonthlyIncome> lstEmpMonthlyIncome = new();
            List<Individual> lstIndividual = new();
            Receiver rootobjectVm = new();
            try
            {
                var conv = new List<UploadEmployeesFm2>();
                r.status = true;
                r.message = "Record saved Successfully";
                if (emp.File != null && emp.File.Length > 0)
                {
                    var table = AllFunction.ConvertExcelToDatatable(emp.File);
                    conv = AllFunction.ConvertDataTable2<UploadEmployeesFm2>(table);
                    var buss = GetBusinessCompanyId(emp.BusinessRin, emp.CompanyRin);

                    FormH1FormModel emp1 = new FormH1FormModel
                    {
                        BusinessId = buss.Result.BusinessId,
                        CompanyId = buss.Result.Companyid

                    };
                    if (conv.Count > 0)
                    {
                        for (int i = 0; i < conv.Count(); i++)
                        {
                            if (
                                (string.IsNullOrEmpty(conv[i].PhoneNumber) || conv[i].PhoneNumber == "NULL")
                                && (string.IsNullOrEmpty(conv[i].RIN) || conv[i].RIN == "NULL")
                                && (string.IsNullOrEmpty(conv[i].JTBTIN) || conv[i].JTBTIN == "NULL")
                            )
                            {
                                lstErrorRes.Add(
                                       $"{errorNote} in row {i + 1} Provide PHONENUMBER or RIN or TIN."
                                   );
                            }
                        }
                        if (lstErrorRes.Any())
                        {
                            var res = string.Join("", lstErrorRes);
                            r.status = false;
                            r.message = $"{res}";
                            await Task.FromResult<IActionResult>(Ok(r));
                        }
                        var token = GetToken();
                        if (token != null)
                        {
                            foreach (var fm in conv)
                            {
                                if (fm.PhoneNumber != "NULL")
                                {
                                    mainBaseurl =
                                    baseUrl
                                    + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber="
                                    + fm.PhoneNumber;
                                    resp = await CallAPi(mainBaseurl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                }
                                else if (fm.RIN != "NULL")
                                {
                                    mainBaseurl =
                                   baseUrl
                                   + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN="
                                   + fm.RIN;
                                    resp = await CallAPi(mainBaseurl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                }
                                else if (fm.JTBTIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                    resp = await CallAPi(mainBaseurl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                }
                                else
                                {
                                    r.status = false;
                                    r.message = "Error Occured Processing Record To ERAS";
                                    return Ok(r);
                                }
                                if (rootobjectVm.Result.Count <= 0)
                                {
                                    if (
                                        fm.PhoneNumber != "NULL"
                                    )
                                    {
                                        mainBaseurl =
                                            _serviceSettings.Value.ErasBaseUrl
                                            + "TaxPayer/Individual/PayeInsert";
                                        AddTaxPayer ad = new();
                                        ad.TaxPayerTypeId = 1;
                                        ad.GenderID = 1;
                                        ad.TitleID = 2;
                                        ad.FirstName = fm.FirstName;
                                        ad.LastName = fm.Surname;
                                        ad.MiddleName = fm.OtherName;
                                        ad.DOB = "01/01/2004";
                                        ad.TIN = fm.JTBTIN;
                                        ad.MobileNumber1 = fm.PhoneNumber;
                                        ad.EmailAddress1 = "abc@gmail.com";
                                        ad.BiometricDetails = "";
                                        ad.TaxOfficeID = 34;
                                        ad.MaritalStatusID = 3;
                                        ad.NationalityID = 1;
                                        ad.EconomicActivitiesID = 1;
                                        ad.NotificationMethodID = 1;
                                        ad.ContactAddress = fm.HomeAddress;
                                        string jsonData = js.Serialize(ad);
                                        resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                        rootobjectVm = js.Deserialize<Receiver>(resp);
                                        if (rootobjectVm.Success == true)
                                        {
                                            if (fm.PhoneNumber != "NULL")
                                            {
                                                baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PhoneNumber;
                                            }
                                            else if (fm.RIN != "NULL")
                                            {
                                                baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                            }
                                            else if (fm.JTBTIN != "NULL")
                                            {
                                                baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                            }
                                            resp = await CallAPi(baseUrl, token, "get", "");
                                            rootobjectVm = js.Deserialize<Receiver>(resp);
                                            if (rootobjectVm.Success == true)
                                            {
                                                if (rootobjectVm.Result.Count > 0)
                                                {
                                                    var sp = new Individual
                                                    {
                                                        EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                        Firstname = fm.FirstName,
                                                        Surname = fm.Surname,
                                                        Othername = fm.OtherName,
                                                        Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                                        EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                                        Jtbtin = fm.JTBTIN,
                                                        Nin = fm.NIN,
                                                        Nationality = fm.Nationality,
                                                        Homeaddress = rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString(),
                                                        Designation = "",
                                                        EmailAddress = "ABC@eirs.com",
                                                        LgaCode = 0,
                                                        Title = "",
                                                        Bvn = 0,
                                                        ZipCode = "",
                                                        Datetcreated = DateTime.Now,
                                                        Datemodified = DateTime.Now,
                                                    };
                                                    lstIndividual.Add(sp);
                                                    lstEmpMonthlyIncome.Add(
                                                        new EmployeesMonthlyIncome
                                                        {
                                                            BusinessId = emp1.BusinessId,
                                                            CompanyId = emp1.CompanyId,
                                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                            Pension = fm.Pension != null ? Convert.ToDecimal(fm.Pension) : 0,
                                                            Nhf = fm.NHF != null ? Convert.ToDecimal(fm.NHF) : 0,
                                                            Nhis = fm.NHIS != null ? Convert.ToDecimal(fm.NHF) : 0,
                                                            Rent = fm.Rent != null ? Convert.ToDecimal(fm.Rent) : 0,
                                                            Transport = fm.Transport != null ? Convert.ToDecimal(fm.Transport) : 0,
                                                            Basic = fm.Basic != null ? Convert.ToDecimal(fm.Basic) : 0,
                                                            Others = fm.OtherIncome != null ? Convert.ToDecimal(fm.OtherIncome) : 0,
                                                            LifeAssurance = fm.LifeAssurance != null ? Convert.ToDecimal(fm.LifeAssurance) : 0,
                                                            Ltg = fm.Ltg != null ? Convert.ToDecimal(fm.Ltg) : 0,
                                                            Meal = fm.Meal != null ? Convert.ToDecimal(fm.Meal) : 0,
                                                            Utility = fm.Utility != null ? Convert.ToDecimal(fm.Utility) : 0,
                                                            Status = true,
                                                            CreatedDate = DateTime.Now,
                                                            ModifiedDate = DateTime.Now,
                                                            CreatedBy = username,
                                                            ModifiedBy = username,
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
                                        var res = _repo.Individuals.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() &&
                                             o.EmployeeRin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString());

                                        if (res != null)
                                        {   //update existing taxpayer on Individual 
                                            _repo.Individuals.Where(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                                .ExecuteUpdate(obj => obj
                                                        .SetProperty(b => b.Firstname, fm.FirstName)
                                                        .SetProperty(b => b.Surname, fm.Surname)
                                                        .SetProperty(b => b.Othername, fm.OtherName)
                                                        .SetProperty(b => b.Phonenumber, rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString())
                                                        .SetProperty(b => b.EmployeeRin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                                        .SetProperty(b => b.Jtbtin, fm.JTBTIN)
                                                        .SetProperty(b => b.Nin, fm.NIN)
                                                        .SetProperty(b => b.Nationality, fm.Nationality)
                                                        .SetProperty(b => b.Homeaddress, rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString())
                                                        .SetProperty(b => b.Designation, "")
                                                       );
                                        }
                                        else
                                        {
                                            var sp = new Individual
                                            {
                                                EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                Firstname = fm.FirstName,
                                                Surname = fm.Surname,
                                                Othername = fm.OtherName,
                                                Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                                EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                                Jtbtin = fm.JTBTIN,
                                                Nin = fm.NIN,
                                                Nationality = fm.Nationality,
                                                Homeaddress = rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString(),
                                                Designation = "",
                                                EmailAddress = "ABC@eirs.com",
                                                LgaCode = 0,
                                                Title = "",
                                                Bvn = 0,
                                                ZipCode = "",
                                                Datetcreated = DateTime.Now,
                                                Datemodified = DateTime.Now,
                                            };
                                            lstIndividual.Add(sp);
                                        }
                                        var resEmp = _repo.EmployeesMonthlyIncomes.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                            && o.BusinessId == emp1.BusinessId && o.CompanyId == emp1.CompanyId
                                        );
                                        if (resEmp != null)
                                        {
                                            _repo.EmployeesMonthlyIncomes.Where(o =>
                                                o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                                 && o.BusinessId == emp1.BusinessId && o.CompanyId == emp1.CompanyId
                                            )
                                                .ExecuteUpdate(obj => obj
                                                        .SetProperty(b => b.EmployeeId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                                        .SetProperty(b => b.BusinessId, emp1.BusinessId)
                                                        .SetProperty(b => b.CompanyId, emp1.CompanyId)
                                                        .SetProperty(b => b.Pension, fm.Pension != null ? Convert.ToDecimal(fm.Pension) : 0)
                                                        .SetProperty(b => b.Nhf, fm.NHF != null ? Convert.ToDecimal(fm.NHF) : 0)
                                                        .SetProperty(b => b.Nhis, fm.NHIS != null ? Convert.ToDecimal(fm.NHIS) : 0)
                                                        .SetProperty(b => b.Basic, fm.Basic != null ? Convert.ToDecimal(fm.Basic) : 0)
                                                        .SetProperty(b => b.Rent, fm.Rent != null ? Convert.ToDecimal(fm.Rent) : 0)
                                                        .SetProperty(b => b.LifeAssurance, fm.LifeAssurance != null ? Convert.ToDecimal(fm.LifeAssurance) : 0)
                                                        .SetProperty(b => b.Transport, fm.Transport != null ? Convert.ToDecimal(fm.Transport) : 0)
                                                        .SetProperty(b => b.Others, fm.OtherIncome != null ? Convert.ToDecimal(fm.OtherIncome) : 0)
                                                        .SetProperty(b => b.Meal, fm.Meal != null ? Convert.ToDecimal(fm.Meal) : 0)
                                                        .SetProperty(b => b.Ltg, fm.Ltg != null ? Convert.ToDecimal(fm.Ltg) : 0)
                                                        .SetProperty(b => b.Utility, fm.Utility != null ? Convert.ToDecimal(fm.Utility) : 0)
                                                        .SetProperty(b => b.Status, true)
                                                        .SetProperty(b => b.CreatedDate, DateTime.Now)
                                                        .SetProperty(b => b.ModifiedDate, DateTime.Now)
                                                        .SetProperty(b => b.CreatedBy, username)
                                                        .SetProperty(b => b.ModifiedBy, username)
                                                     );
                                        }
                                        else
                                        {
                                            lstEmpMonthlyIncome.Add(
                                                new EmployeesMonthlyIncome
                                                {
                                                    BusinessId = emp1.BusinessId,
                                                    CompanyId = emp1.CompanyId,
                                                    EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                    Pension = fm.Pension != null ? Convert.ToDecimal(fm.Pension) : 0,
                                                    Nhf = fm.NHF != null ? Convert.ToDecimal(fm.NHF) : 0,
                                                    Nhis = fm.NHF != null ? Convert.ToDecimal(fm.NHF) : 0,
                                                    Basic = fm.Basic != null ? Convert.ToDecimal(fm.Basic) : 0,
                                                    Rent = fm.Rent != null ? Convert.ToDecimal(fm.Rent) : 0,
                                                    Transport = fm.Transport != null ? Convert.ToDecimal(fm.Transport) : 0,
                                                    Others = fm.OtherIncome != null ? Convert.ToDecimal(fm.OtherIncome) : 0,
                                                    LifeAssurance = fm.LifeAssurance != null ? Convert.ToDecimal(fm.LifeAssurance) : 0,
                                                    Ltg = fm.Ltg != null ? Convert.ToDecimal(fm.Ltg) : 0,
                                                    Meal = fm.Meal != null ? Convert.ToDecimal(fm.Meal) : 0,
                                                    Utility = fm.Utility != null ? Convert.ToDecimal(fm.Utility) : 0,
                                                    Status = true,
                                                    CreatedDate = DateTime.Now,
                                                    ModifiedDate = DateTime.Now,
                                                    CreatedBy = username,
                                                    ModifiedBy = username,
                                                });
                                        }
                                    }
                                }
                                mainBaseurl = "";
                            }
                        }
                    }
                }

                await _phaseBench.SqlBulkUpload(lstIndividual, "dbo.individual");
                await _phaseBench.SqlBulkUpload(lstEmpMonthlyIncome, "dbo.EmployeesMonthlyIncome");
                r.data = lstIndividual.Count;
                r.status = true;
                r.message = "Employees uploaded successfully.";
            }
            catch (System.Exception ex)
            {
                r.status = false;
                r.message = $"Error uploading employees: {ex.Message}";
            }

            return Ok(r);
        }


        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeesInd1 emp)
        {
            var r = new ReturnObject();
            var lstErrorRes = new List<string>();
            string errorNote = "There Is An Error ";
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var resp = "";
            List<EmployeesMonthlyIncome> lstEmpMonthlyIncome = new();
            List<Individual> lstIndividual = new();
            Receiver rootobjectVm = new();
            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;

            try
            {
                r.status = true;
                r.message = "Record saved Successfully";
                if (string.IsNullOrEmpty(emp.EmployeeRin) || emp.EmployeeRin.Length != 10 || string.IsNullOrEmpty(emp.Phonenumber) || emp.Phonenumber.Length != 10)
                {
                    var buss = GetBusinessCompanyId(emp.BusinessRin, emp.CompanyRin);

                    AddEmployeesInd ObjBus = new AddEmployeesInd
                    {
                        BusinessId = buss.Result.BusinessId,
                        CompanyId = buss.Result.Companyid

                    };

                    if ((string.IsNullOrEmpty(emp.Phonenumber) || emp.Phonenumber == "NULL")
                         && (string.IsNullOrEmpty(emp.EmployeeRin) || emp.EmployeeRin == "NULL")
                         && (string.IsNullOrEmpty(emp.Jtbtin) || emp.Jtbtin == "NULL"))
                    {
                        lstErrorRes.Add(
                               $"{errorNote} in row Provide PHONENUMBER or EmployeeRin or NIN."
                           );
                    }
                    if (lstErrorRes.Any())
                    {
                        var res = string.Join("", lstErrorRes);
                        r.status = false;
                        r.message = $"{res}";
                        return Ok(r);
                    }
                    var token = GetToken();
                    if (token != null)
                    {
                        if (emp.Phonenumber != "NULL")
                        {
                            mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + emp.Phonenumber;
                            resp = await CallAPi(mainBaseurl, token, "get", "");
                            rootobjectVm = js.Deserialize<Receiver>(resp);
                        }
                        else if (emp.EmployeeRin != "NULL")
                        {
                            mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + emp.EmployeeRin;
                            resp = await CallAPi(mainBaseurl, token, "get", "");
                            rootobjectVm = js.Deserialize<Receiver>(resp);
                        }
                        else if (emp.Jtbtin != "NULL")
                        {
                            mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + emp.Jtbtin;
                            resp = await CallAPi(mainBaseurl, token, "get", "");
                            rootobjectVm = js.Deserialize<Receiver>(resp);
                        }
                        else
                        {
                            r.status = false;
                            r.message = "Error Occured Processing Record To ERAS";
                            return Ok(r);
                        }
                        if (rootobjectVm.Result.Count <= 0)
                        {
                            if (emp.Phonenumber != "NULL")
                            {
                                mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/PayeInsert";
                                AddTaxPayer ad = new();
                                ad.TaxPayerTypeId = 1;
                                ad.GenderID = 1;
                                ad.TitleID = 2;
                                ad.FirstName = emp.Firstname;
                                ad.LastName = emp.Surname;
                                ad.MiddleName = emp.Othername;
                                ad.DOB = "01/01/2004";
                                ad.TIN = emp.Jtbtin;
                                ad.MobileNumber1 = emp.Phonenumber;
                                ad.EmailAddress1 = "abc@gmail.com";
                                ad.BiometricDetails = "";
                                ad.TaxOfficeID = 34;
                                ad.MaritalStatusID = 3;
                                ad.NationalityID = 1;
                                ad.EconomicActivitiesID = 1;
                                ad.NotificationMethodID = 1;
                                ad.ContactAddress = emp.Homeaddress;
                                string jsonData = js.Serialize(ad);
                                resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                rootobjectVm = js.Deserialize<Receiver>(resp);

                                if (rootobjectVm.Success == true)
                                {
                                    if (emp.Phonenumber != "NULL")
                                    {
                                        baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + emp.Phonenumber;
                                    }
                                    else if (emp.EmployeeRin != "NULL")
                                    {
                                        baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + emp.EmployeeRin;
                                    }
                                    else if (emp.Jtbtin != "NULL")
                                    {
                                        baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + emp.Jtbtin;
                                    }
                                    resp = await CallAPi(baseUrl, token, "get", "");
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (rootobjectVm.Result.Count > 0)
                                        {
                                            var sp = new Individual
                                            {
                                                EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                Firstname = emp.Firstname,
                                                Surname = emp.Surname,
                                                Othername = emp.Othername,
                                                Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                                EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                                Jtbtin = emp.Jtbtin,
                                                Nin = emp.Nin,
                                                Nationality = emp.Nationality,
                                                Homeaddress = rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString(),
                                                Designation = "",
                                                EmailAddress = "ABC@eirs.com",
                                                LgaCode = 0,
                                                Title = "",
                                                Bvn = 0,
                                                ZipCode = "",
                                                Datetcreated = DateTime.Now,
                                                Datemodified = DateTime.Now,
                                            };
                                            lstIndividual.Add(sp);
                                            lstEmpMonthlyIncome.Add(
                                                new EmployeesMonthlyIncome
                                                {
                                                    BusinessId = ObjBus.BusinessId,
                                                    CompanyId = ObjBus.CompanyId,
                                                    EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                                    Pension = emp.Pension != 0 ? emp.Pension : 0,
                                                    Nhf = emp.Nhf != 0 ? emp.Nhf : 0,
                                                    Nhis = emp.Nhis != 0 ? emp.Nhis : 0,
                                                    Rent = emp.Rent != 0 ? emp.Rent : 0,
                                                    Transport = emp.Transport != 0 ? emp.Transport : 0,
                                                    Basic = emp.Basic != 0 ? emp.Basic : 0,
                                                    Others = emp.OtherIncome != 0 ? emp.OtherIncome : 0,
                                                    LifeAssurance = emp.LifeAssurance != 0 ? emp.LifeAssurance : 0,
                                                    Ltg = emp.Ltg != 0 ? emp.Ltg : 0,
                                                    Meal = emp.Meal != 0 ? emp.Meal : 0,
                                                    Utility = emp.Utility != 0 ? emp.Utility : 0,
                                                    Status = true,
                                                    CreatedDate = DateTime.Now,
                                                    ModifiedDate = DateTime.Now,
                                                    CreatedBy = username,
                                                    ModifiedBy = username,
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
                                var res = _repo.Individuals.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() &&
                                     o.EmployeeRin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString());

                                //update existing taxpayer on Individual 
                                if (res != null)
                                {
                                    _repo.Individuals.Where(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                        .ExecuteUpdate(obj => obj
                                                .SetProperty(b => b.Firstname, emp.Firstname)
                                                .SetProperty(b => b.Surname, emp.Surname)
                                                .SetProperty(b => b.Othername, emp.Othername)
                                                .SetProperty(b => b.Phonenumber, rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString())
                                                .SetProperty(b => b.EmployeeRin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                                                .SetProperty(b => b.Jtbtin, emp.Jtbtin)
                                                .SetProperty(b => b.Nin, emp.Nin)
                                                .SetProperty(b => b.Nationality, emp.Nationality)
                                                .SetProperty(b => b.Homeaddress, rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString())
                                                .SetProperty(b => b.Designation, "")
                                               );
                                }
                                else
                                {
                                    var sp = new Individual
                                    {
                                        EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                        Firstname = emp.Firstname,
                                        Surname = emp.Surname,
                                        Othername = emp.Othername,
                                        Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                                        EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                        Jtbtin = emp.Jtbtin,
                                        Nin = emp.Nin,
                                        Nationality = emp.Nationality,
                                        Homeaddress = rootobjectVm.Result.FirstOrDefault().TaxPayerAddress.ToString(),
                                        Designation = "",
                                        EmailAddress = "ABC@eirs.com",
                                        LgaCode = 0,
                                        Title = "",
                                        Bvn = 0,
                                        ZipCode = "",
                                        Datetcreated = DateTime.Now,
                                        Datemodified = DateTime.Now,
                                    };
                                    lstIndividual.Add(sp);
                                }
                                var resEmp = _repo.EmployeesMonthlyIncomes.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                    && o.BusinessId == ObjBus.BusinessId && o.CompanyId == ObjBus.CompanyId
                                );
                                if (resEmp != null)
                                {
                                    _repo.EmployeesMonthlyIncomes.Where(o =>
                                        o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                                         && o.BusinessId == ObjBus.BusinessId && o.CompanyId == ObjBus.CompanyId
                                    )
                                        .ExecuteUpdate(obj => obj
                                                .SetProperty(b => b.EmployeeId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                                                .SetProperty(b => b.BusinessId, ObjBus.BusinessId)
                                                .SetProperty(b => b.CompanyId, ObjBus.CompanyId)
                                                .SetProperty(b => b.Pension, emp.Pension != 0 ? emp.Pension : 0)
                                                .SetProperty(b => b.Nhf, emp.Nhf != 0 ? emp.Nhf : 0)
                                                .SetProperty(b => b.Nhis, emp.Nhis != 0 ? emp.Nhis : 0)
                                                .SetProperty(b => b.Basic, emp.Basic != 0 ? emp.Basic : 0)
                                                .SetProperty(b => b.Rent, emp.Rent != 0 ? Convert.ToDecimal(emp.Rent) : 0)
                                                .SetProperty(b => b.LifeAssurance, emp.LifeAssurance != 0 ? Convert.ToDecimal(emp.LifeAssurance) : 0)
                                                .SetProperty(b => b.Transport, emp.Transport != 0 ? emp.Transport : 0)
                                                .SetProperty(b => b.Others, emp.OtherIncome != 0 ? emp.OtherIncome : 0)
                                                .SetProperty(b => b.Meal, emp.Meal != 0 ? emp.Meal : 0)
                                                .SetProperty(b => b.Ltg, emp.Ltg != 0 ? emp.Ltg : 0)
                                                .SetProperty(b => b.Utility, emp.Utility != 0 ? emp.Utility : 0)
                                                .SetProperty(b => b.Status, true)
                                                .SetProperty(b => b.CreatedDate, DateTime.Now)
                                                .SetProperty(b => b.ModifiedDate, DateTime.Now)
                                                .SetProperty(b => b.CreatedBy, username)
                                                .SetProperty(b => b.ModifiedBy, username)
                                             );
                                }
                                else
                                {
                                    lstEmpMonthlyIncome.Add(
                                        new EmployeesMonthlyIncome
                                        {
                                            BusinessId = ObjBus.BusinessId,
                                            CompanyId = ObjBus.CompanyId,
                                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                            Pension = emp.Pension != 0 ? emp.Pension : 0,
                                            Nhf = emp.Nhf != 0 ? emp.Nhf : 0,
                                            Nhis = emp.Nhis != 0 ? emp.Nhis : 0,
                                            Basic = emp.Basic != 0 ? emp.Basic : 0,
                                            Rent = emp.Rent != 0 ? emp.Rent : 0,
                                            Transport = emp.Transport != 0 ? emp.Transport : 0,
                                            Others = emp.OtherIncome != 0 ? emp.OtherIncome : 0,
                                            LifeAssurance = emp.LifeAssurance != 0 ? emp.LifeAssurance : 0,
                                            Ltg = emp.Ltg != 0 ? emp.Ltg : 0,
                                            Meal = emp.Meal != 0 ? emp.Meal : 0,
                                            Utility = emp.Utility != 0 ? emp.Utility : 0,
                                            Status = true,
                                            CreatedDate = DateTime.Now,
                                            ModifiedDate = DateTime.Now,
                                            CreatedBy = username,
                                            ModifiedBy = username,
                                        });
                                }
                            }
                        }
                        mainBaseurl = "";
                    }

                    await _repo.AddRangeAsync(lstIndividual);
                    await _repo.AddRangeAsync(lstEmpMonthlyIncome);
                    r.data = lstIndividual;
                    _repo.SaveChanges();
                }
                else
                {
                    lstErrorRes.Add($"{errorNote} TaxpayerRin Must Not Be Empty .");
                }
                return await Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                AllFunction.SendErrorToText(ex);
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message

                }));
            }
        }

        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Mark-Employee-Inactive")]
        public async Task<IActionResult> MarkEmployeeInactive([FromBody] MarkEmpInactive1 obj)
        {
            try
            {
                if (obj.EmployeeRin == null || obj.BusinessRin == null || obj.CompanyRin == null)
                {
                    return NotFound(new ReturnObject { message = "EmployeeId, BusinessId, or CompanyId Cannot Be Null", status = false });
                }
                else
                {
                    var r = new ReturnObject { message = "Successfully Marked", status = true };
                    var Ind = await _repo.Individuals.FirstOrDefaultAsync(x => x.EmployeeRin == obj.EmployeeRin);

                    var buss = GetBusinessCompanyId(obj.BusinessRin, obj.CompanyRin);

                    MarkEmpInactive ObjBus = new MarkEmpInactive
                    {
                        BusinessId = buss.Result.BusinessId,
                        Companyid = buss.Result.Companyid,
                        Employeeid = Ind.EmployeeId,

                    };

                    var stat = await _repo.EmployeesMonthlyIncomes
                        .Where(e => e.EmployeeId == Ind.EmployeeId && e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                        .Select(o => o.Status)
                        .FirstOrDefaultAsync();

                    if (stat != null)
                    {
                        r.data = await _repo.EmployeesMonthlyIncomes
                            .Where(e => e.EmployeeId == Ind.EmployeeId && e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                            .ExecuteUpdateAsync(setters =>
                                setters.SetProperty(b => b.Status, stat == true ? false : true));
                    }
                    else
                    {
                        return NotFound(new ReturnObject { message = "Employee not found", status = false });
                    }

                    return Ok(r);
                }

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
        [Route("Mark-All-Employee-Inactive")]
        public async Task<IActionResult> MarkAllEmployeeInactive([FromBody] MarkH3Inactive obj)
        {
            try
            {
                if (obj.BusinessRin == null || obj.CompanyRin == null)
                {
                    return NotFound(new ReturnObject { message = "BusinessId, or CompanyId Cannot Be Null", status = false });
                }
                else
                {
                    var r = new ReturnObject { message = "Successfully Marked All", status = true };
                    //var Ind = await _repo.Individuals.FirstOrDefaultAsync(x => x.EmployeeRin == obj.EmployeeRin);

                    var buss = GetBusinessCompanyId(obj.BusinessRin, obj.CompanyRin);

                    MarkEmpInactive ObjBus = new MarkEmpInactive
                    {
                        BusinessId = buss.Result.BusinessId,
                        Companyid = buss.Result.Companyid
                    };

                    if (ObjBus != null)
                    {
                        var stat = await _repo.EmployeesMonthlyIncomes
                                         .Where(e => e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                                         .Select(o => o.Status)
                                         .FirstOrDefaultAsync();

                        if (stat != null)
                        {
                            r.data = await _repo.EmployeesMonthlyIncomes
                                .Where(e => e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                                .ExecuteUpdateAsync(setters =>
                                    setters.SetProperty(b => b.Status, false));
                        }
                        else
                        {
                            return NotFound(new ReturnObject { message = "Employees not found", status = false });
                        }
                    }
                    else
                    {
                        return NotFound(new ReturnObject { message = "Employer not found", status = false });
                    }
                    return Ok(r);
                }

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
        [Route("GetSchedulebyDate")]
        public async Task<IActionResult> GetSchedulebyDate([FromBody] EmpSchedule1 Obj)
        {
            var r = new ReturnObject
            {
                status = false,
                message = "Schedule Has Already Been Forward For Selected Month and Year"
            };

            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;

            try
            {
                if (Obj != null)
                {
                    var buss = GetBusinessCompanyId(Obj.BusinessRin, Obj.CompanyRin);

                    EmpSchedule ObjBus = new EmpSchedule
                    {
                        BusinessId = buss.Result.BusinessId,
                        Companyid = buss.Result.Companyid,
                        Month = Obj.Month,
                        Year = Obj.Year
                    };

                    var EmpIncome = await _phaseIIRepo.GetMonthlyIncomeAsync(ObjBus);
                    if (EmpIncome.Any(o => o.Status == true))
                    {
                        foreach (var EmpIn in EmpIncome)
                        {
                            var Calcu = await _phaseIIRepo.CalculateMonthScheduleAsync(ObjBus);
                            if (Calcu != null && Calcu.Any())
                            {
                                foreach (var ItemCal in Calcu)
                                {
                                    var Individual = await _repo.Individuals
                                                         .Where(x => x.EmployeeId == EmpIn.EmployeeId)
                                                         .ToListAsync();
                                    if (Individual.Any())
                                    {
                                        foreach (var Ind in Individual)
                                        {
                                            var AddSchedule = new EmployeesMonthlySchedule
                                            {
                                                BusinessId = EmpIn.BusinessId,
                                                EmployerId = EmpIn.CompanyId,
                                                EmployeeRin = Ind.EmployeeRin,
                                                TaxMonth = Obj.Month,
                                                TaxYear = Obj.Year,
                                                Basic = EmpIn.Basic,
                                                Rent = EmpIn.Rent,
                                                Transport = EmpIn.Transport,
                                                OtherIncome = EmpIn.Others,
                                                Pension = EmpIn.Pension,
                                                Nhf = EmpIn.Nhf,
                                                Nhis = EmpIn.Nhis,
                                                LifeAssurance = EmpIn.LifeAssurance,
                                                Cra = ItemCal.Cra,
                                                Tfp = ItemCal.Tfp,
                                                Ci = ItemCal.Ci,
                                                Tax = ItemCal.Tax,
                                                AssessementStatusId = 2,
                                                CreatedBy = username,
                                                CreatedDate = DateTime.Now
                                            };

                                            _repo.EmployeesMonthlySchedules.Add(AddSchedule);
                                            await _repo.SaveChangesAsync();
                                        }
                                    }
                                }
                                r.status = true;
                                r.message = "Successfully Compute Forward Monthly Schedule.";
                            }
                            else
                            {
                                r.status = false;
                                r.message = "No Data Found For Calculation.";
                            }

                        }
                    }
                    if (EmpIncome == null)
                    {
                        return NotFound(new ReturnObject { message = "EmployeeRin, BusinessId, or CompanyId Cannot Be Null", status = false });
                    }
                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FileContentResult))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("download-employee-details")]
        public async Task<IActionResult> DownloadEmployeeDetails([FromQuery] DownloadEmployeeFm Obj)
        {
            var r = new ReturnObject
            {
                status = false,
                message = "Successfully Downloaded Employees Details."
            };
            // still look for problem in  download
            try
            {
                var GetBusDetail = await _repo.AssetTaxPayerDetailsApis
                                                .FirstOrDefaultAsync(x => x.AssetRin == Obj.BusinessRin && x.TaxPayerRinnumber == Obj.CompanyRin);

                var lstEmpDwn = await GetEmployeeDetailsAsync(Obj);

                if (lstEmpDwn.Any())
                {
                    var heading = $"Company Name: {GetBusDetail.AssetName} BusinessRin: {Obj.BusinessRin}";
                    var fileName = $"EmployeeDetails_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    var result = await GenerateExcelFileAsync(lstEmpDwn, "EmployeeDetails", fileName, heading);
                    return result;
                }
                else
                {
                    r.status = false;
                    r.message = "No Data Found For Individual.";
                    return Ok(r);
                }
            }
            catch (System.Exception ex)
            {
                r.message = $"An error occurred: {ex.Message}";
                return StatusCode(StatusCodes.Status500InternalServerError, r);
            }
        }



        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetAllScheduleDetails")]
        public async Task<IActionResult> GetAllScheduleDetails()
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            List<ScheduleGetAllRes> lstSchs = new();

            try
            {
                List<ScheduleGetAllRes> lstSch = await _phaseIIRepo.GetAllSchedulesAsync();

                if (lstSch != null && lstSch.Any())
                {
                    foreach (var res in lstSch)
                    {

                        var AddSchs = new ScheduleGetAllRes
                        {
                            BusinessName = res.BusinessName,
                            CompanyRin = res.CompanyRin,
                            BusinessRin = res.BusinessRin,
                            TaxMonth = res.TaxMonth,
                            TaxYear = res.TaxYear,
                            EmployeeCount = res.EmployeeCount,
                            TotalIncome = res.TotalIncome,
                            MonthlyTax = res.MonthlyTax,
                            DateForwarded = res.DateForwarded,
                            AssessementStatus = res.AssessementStatus
                        };
                        lstSchs.Add(AddSchs);
                    }

                }

                var ret2 = lstSchs.Count();

                var result = new CombinedResult3
                {
                    Businesses = lstSchs,
                    TotalCount = ret2
                };

                r.data = result;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetAllSchedulesView")]
        public async Task<IActionResult> GetAllSchedulesView([FromQuery] EmpSchFm1 Obj)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            try
            {
                var buss = GetBusinessCompanyId(Obj.BusinessRin, Obj.CompanyRin);

                EmpSchFm ObjBus = new EmpSchFm
                {
                    BusinessId = buss.Result.BusinessId,
                    Companyid = buss.Result.Companyid
                };

                if (ObjBus != null)
                {
                    var Calcu = await _phaseIIRepo.GetSchedulesViewAsync(ObjBus);

                    if (Calcu.Any()) { r.data = Calcu; }
                    else { r.status = false; r.message = "No Schedule Found For EmployerRin."; }
                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("SendToRDM")]
        public async Task<IActionResult> SendToRDM([FromBody] BusSchFm Obj)
        {
            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            EmployerMonthlyAssessment AddMontAss = new EmployerMonthlyAssessment();
            List<EmployerMonthlyAssessment> lstEmpAss = new List<EmployerMonthlyAssessment>();
            var r = new AssReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };
            try
            {
                var buss = GetBusinessCompanyId(Obj.BusinessRin, Obj.CompanyRin);

                BusSchFm1 ObjBus = new BusSchFm1
                {
                    BusinessId = buss.Result.BusinessId,
                    CompanyId = buss.Result.Companyid,
                    TaxMonth = Obj.TaxMonth,
                    TaxYear = Obj.TaxYear
                };

                var AssRDM = await _phaseIIRepo.GetAssessmentRDMAsync(ObjBus);
                if (AssRDM != null && AssRDM.Any())
                {
                    foreach (var item in AssRDM)
                    {
                        var AddAssRDM = new AssessmentRDMRes
                        {
                            TaxPayerTypeID = item.TaxPayerTypeID,
                            TaxPayerID = item.TaxPayerID.ToString(),
                            AssetTypeID = item.AssetTypeID,
                            AssetID = item.AssetID,
                            Notes = "ssp",
                            TaxYear = item.TaxYear,
                            TaxBaseAmount = item.TaxBaseAmount,
                            ProfileID = item.ProfileID,
                            AssessmentRuleID = item.AssessmentRuleID,
                            LstAssessmentItem = new List<AssessmentItemss>
                            {
                                new AssessmentItemss
                                {
                                    AssessmentItemID = item.LstAssessmentItem.First().AssessmentItemID,
                                    TaxBaseAmount = item.LstAssessmentItem.First().TaxBaseAmount
                                }
                            }
                        };

                        var client = new HttpClient();
                        var token = GetToken();
                        //var mainBaseurl = "https://api.eirs.gov.ng/RevenueData/Assessment/Insert";
                        var mainBaseurl = baseUrl + "RevenueData/Assessment/Insert";
                        var request = new HttpRequestMessage(HttpMethod.Post, mainBaseurl);
                        request.Headers.Add("Authorization", token);
                        var jsonContent = JsonConvert.SerializeObject(AddAssRDM);
                        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                        request.Content = content;
                        var response = await client.SendAsync(request);
                        if (response.IsSuccessStatusCode)
                        {
                            var responseBody = await response.Content.ReadAsStringAsync();
                            var responseObject = JsonConvert.DeserializeObject<ResponseModel>(responseBody);
                            if (ObjBus != null)
                            {
                                if (responseObject != null)
                                {
                                    foreach (var RefItem in responseObject.Result)
                                    {
                                        using var _context = new EirsContext();
                                        string query = $"select * from assessment where assessmentrefno = '{RefItem.AssessmentRefNo}'";
                                        var Assitem = _context.Assessments.FromSqlRaw(query).ToList();

                                        if (Assitem.Any())
                                        {
                                            foreach (var Ass in Assitem)
                                            {
                                                string Txid = AddAssRDM.TaxPayerID;
                                                var Rin = GetEmployeeRin(Txid);

                                                AddMontAss.EmployerId = ObjBus.CompanyId;
                                                AddMontAss.BusinessId = ObjBus.BusinessId;
                                                AddMontAss.EmployerRin = Rin.ToString();
                                                AddMontAss.TaxYear = (int)Obj.TaxYear;
                                                AddMontAss.TaxMonth = Obj.TaxMonth;
                                                AddMontAss.TotalAmount = AddAssRDM.TaxBaseAmount;
                                                AddMontAss.TotalAssessed = AddAssRDM.TaxBaseAmount;
                                                AddMontAss.AssessmentRefNo = RefItem.AssessmentRefNo;
                                                AddMontAss.AssessmentRefId = (int)Ass.AssessmentId;
                                                AddMontAss.CreatedBy = username ?? "Unknown";
                                                AddMontAss.CreatedDate = DateTime.Now;
                                                lstEmpAss.Add(AddMontAss);
                                            }
                                        }
                                        await _repo.EmployerMonthlyAssessments.AddRangeAsync(lstEmpAss);
                                        _repo.SaveChanges();
                                    };
                                }
                            }
                            return Ok(r);
                        }
                        else
                        {
                            var errorBody = await response.Content.ReadAsStringAsync();
                            return StatusCode((int)response.StatusCode, errorBody);
                        }
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "No Records Found";
                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }

        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Re-SendToRDM")]
        public async Task<IActionResult> ReSendToRDM([FromBody] EmpMtAss Obj)
        {
            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;

            var r = new AssReturnObject
            {
                status = true,
                message = "Record Pushed Successfully"
            };
            try
            {
                if (Obj != null)
                {
                    var GetBus = _phaseIIRepo.GetAssessmentSchudeleDetails(Obj);
                    if (GetBus is not null)
                    {
                        foreach (var item in GetBus.Result)
                        {
                            var Ass = await _repo.EmployerMonthlyAssessments
                                        .Where(x => x.BusinessId == item.BusinessId &&
                                        x.EmployerId == item.EmployerId &&
                                        x.EmployerRin == item.EmployeeRin &&
                                        x.TaxMonth == item.TaxMonth &&
                                        x.TaxYear == item.TaxYear)
                                        .ToListAsync();
                            if (Ass is not null)
                            {
                                foreach (var itemAss in Ass)
                                {
                                    var AddMontAss = new EmployerMonthlyAssessmentHistory
                                    {
                                        EmployerId = item.EmployerId,
                                        BusinessId = item.BusinessId,
                                        EmployerRin = item.EmployeeRin,
                                        TaxYear = (int)item.TaxYear,
                                        TaxMonth = item.TaxMonth,
                                        TotalAmount = itemAss.TotalAmount,
                                        TotalAssessed = itemAss.TotalAssessed,
                                        AssessmentRefNo = itemAss.AssessmentRefNo,
                                        AssessmentRefId = itemAss.AssessmentRefId,
                                        AssCreatedBy = itemAss.CreatedBy,
                                        AssCreatedDate = itemAss.CreatedDate,
                                        CreatedBy = username ?? "TaxOfficer",
                                        CreatedDate = DateTime.Now
                                    };
                                    _repo.EmployerMonthlyAssessmentHistories.AddRange(AddMontAss);
                                    await _repo.SaveChangesAsync();
                                }
                            }

                        }
                    }


                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }

        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Revise-Submission")]
        public async Task<IActionResult> ReviseSubmission([FromBody] EmpMtAss Obj)
        {
            var r = new AssReturnObject
            {
                status = true,
                message = "Schedule Deleted Successfully"
            };
            try
            {
                if (Obj != null)
                {
                    var GetBus = _phaseIIRepo.GetAssessmentScheduleDetails2(Obj);
                    if (GetBus is not null)
                    {
                        var RemoveAss = await _repo.EmployeesMonthlySchedules
                            .Where(x => x.BusinessId == GetBus.Result.First().BusinessId &&
                                        x.EmployerId == GetBus.Result.First().EmployerId &&
                                        x.TaxMonth == GetBus.Result.First().TaxMonth &&
                                        x.TaxYear == GetBus.Result.First().TaxYear)
                            .ToListAsync();

                        if (RemoveAss.Any())
                        {
                            _repo.EmployeesMonthlySchedules.RemoveRange(RemoveAss);
                            await _repo.SaveChangesAsync();
                        }
                    }
                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }

        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Re-Assess")]
        public async Task<IActionResult> ReAssess([FromBody] EmpMtAss Obj)
        {
            var username = _httpContextAccessor.HttpContext.User.Identity?.Name ?? Environment.UserName;

            var r = new AssReturnObject
            {
                status = true,
                message = "Record Pushed Successfully"
            };
            try
            {
                if (Obj != null)
                {
                    var GetBus = _phaseIIRepo.GetAssessmentSchudeleDetails(Obj);
                    if (GetBus.Result.Any())
                    {
                        foreach (var item in GetBus.Result)
                        {
                            var Ass = _repo.EmployerMonthlyAssessments
                                        .Where(x => x.BusinessId == item.BusinessId &&
                                        x.EmployerId == item.EmployerId &&
                                        x.TaxMonth == item.TaxMonth &&
                                        x.TaxYear == item.TaxYear)
                                        .ToList();

                            if (Ass is not null)
                            {
                                foreach (var itemAss in Ass)
                                {
                                    var AddMontAss = new EmployerMonthlyAssessmentHistory
                                    {
                                        EmployerId = itemAss.EmployerId,
                                        BusinessId = itemAss.BusinessId,
                                        EmployerRin = itemAss.EmployerRin,
                                        TaxYear = (int)itemAss.TaxYear,
                                        TaxMonth = itemAss.TaxMonth,
                                        TotalAmount = itemAss.TotalAmount,
                                        TotalAssessed = itemAss.TotalAssessed,
                                        AssessmentRefNo = itemAss.AssessmentRefNo,
                                        AssessmentRefId = itemAss.AssessmentRefId,
                                        AssCreatedBy = itemAss.CreatedBy,
                                        AssCreatedDate = itemAss.CreatedDate,
                                        CreatedBy = username ?? "TaxOfficer",
                                        CreatedDate = DateTime.Now
                                    };
                                    _repo.EmployerMonthlyAssessmentHistories.Add(AddMontAss);
                                    await _repo.SaveChangesAsync();

                                    var RemoveAss = await _repo.EmployeesMonthlySchedules
                                                .Where(x => x.BusinessId == itemAss.BusinessId &&
                                                            x.EmployerId == itemAss.EmployerId &&
                                                            x.TaxMonth == itemAss.TaxMonth &&
                                                            x.TaxYear == itemAss.TaxYear)
                                                .ToListAsync();

                                    if (RemoveAss.Any())
                                    {
                                        _repo.EmployeesMonthlySchedules.RemoveRange(RemoveAss);
                                        await _repo.SaveChangesAsync();
                                    }

                                    EmpSchedule ObjBus = new EmpSchedule
                                    {
                                        BusinessId = item.BusinessId,
                                        Companyid = item.EmployerId,
                                        Month = Obj.TaxMonth,
                                        Year = Obj.TaxYear
                                    };

                                    var CheckSchedule = await _repo.EmployeesMonthlySchedules
                                        .Where(x => x.BusinessId == ObjBus.BusinessId &&
                                        x.EmployerId == ObjBus.Companyid &&
                                        x.TaxMonth == ObjBus.Month &&
                                        x.TaxYear == ObjBus.Year).ToListAsync();
                                    if (CheckSchedule != null)
                                    {
                                        return NotFound(new ReturnObject { message = "Schedule had already been forwarded for the selected Month and Year", status = false });
                                    }
                                    else
                                    {
                                        var monthlyIncome = await _phaseIIRepo.GetMonthlyIncomeAsync(ObjBus);

                                        if (monthlyIncome == null)
                                        {
                                            return NotFound(new ReturnObject { message = "BusinessId, or CompanyId Not Found", status = false });
                                        }
                                        if (monthlyIncome.Any(o => o.Status == true))
                                        {
                                            foreach (var itemInc in monthlyIncome)
                                            {
                                                var Calcu = await _phaseIIRepo.CalculateMonthScheduleAsync(ObjBus);

                                                if (Calcu != null && Calcu.Any())
                                                {
                                                    foreach (var ItemCal in Calcu)
                                                    {
                                                        var Individual = await _repo.Individuals
                                                                .Where(x => x.EmployeeId == monthlyIncome.First().EmployeeId)
                                                                .ToListAsync();
                                                        if (!Individual.Any())
                                                        {
                                                            foreach (var Ind in Individual)
                                                            {
                                                                var AddSchedule = new EmployeesMonthlySchedule
                                                                {
                                                                    BusinessId = itemInc.BusinessId,
                                                                    EmployerId = itemInc.CompanyId,
                                                                    EmployeeRin = Ind.EmployeeRin,
                                                                    TaxMonth = Obj.TaxMonth,
                                                                    TaxYear = Obj.TaxYear,
                                                                    Basic = itemInc.Basic,
                                                                    Rent = itemInc.Rent,
                                                                    Transport = itemInc.Transport,
                                                                    OtherIncome = itemInc.Others,
                                                                    Pension = itemInc.Pension,
                                                                    Nhf = itemInc.Nhf,
                                                                    Nhis = itemInc.Nhis,
                                                                    LifeAssurance = itemInc.LifeAssurance,
                                                                    Cra = ItemCal.Cra,
                                                                    Tfp = ItemCal.Tfp,
                                                                    Ci = ItemCal.Ci,
                                                                    Tax = ItemCal.Tax,
                                                                    AssessementStatusId = 4,
                                                                    CreatedBy = username,
                                                                    CreatedDate = DateTime.Now
                                                                };
                                                                _repo.EmployeesMonthlySchedules.Add(AddSchedule);
                                                                await _repo.SaveChangesAsync();

                                                            }
                                                        }
                                                    }
                                                    r.status = true;
                                                    r.message = "Successfully Compute Forward Monthly Schedule.";
                                                }
                                                else
                                                {
                                                    r.status = false;
                                                    r.message = "No Data Found For Calculation.";
                                                }
                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                    else
                    {
                        r.status = false;
                        r.message = "Record Not Found";
                    }


                }
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }

        }


        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FileContentResult))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("DownLoadPDF")]
        public async Task<IActionResult> DownLoadPDF([FromBody] EmpMtAss Obj)
        {
            var r = new AssReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };


            string htmlpath = _serviceSettings.Value.HtmlTemplatePath;
            try
            {
                // Prepare the necessary data
                List<Schedulepdf> lstSch = new List<Schedulepdf>();
                List<CompDetailsRes> lstCmp = new List<CompDetailsRes>();
                List<BusDetailsRes> lstBus = new List<BusDetailsRes>();

                if (Obj != null)
                {
                    var GetBus = _phaseIIRepo.GetAssessmentSchudeleDetailsDownLoad(Obj);
                    if (GetBus.Result.Any())
                    {
                        int serialNo = 1;
                        foreach (var item in GetBus.Result)
                        {
                            var Sch = await _repo.EmployeesMonthlySchedules
                                        .Where(x => x.BusinessId == item.BusinessId &&
                                                    x.EmployerId == item.EmployerId &&
                                                    x.EmployeeRin == item.EmployeeRin &&
                                                    x.TaxMonth == item.TaxMonth &&
                                                    x.TaxYear == item.TaxYear)
                                        .ToListAsync();
                            if (Sch is not null)
                            {
                                foreach (var itemSch in Sch)
                                {
                                    var Ind = await _repo.Individuals
                                        .Where(x => x.EmployeeRin == itemSch.EmployeeRin)
                                        .ToListAsync();
                                    if (Ind is not null)
                                    {
                                        foreach (var itemInd in Ind)
                                        {
                                            decimal? Ti = itemSch.Basic + itemSch.Rent + itemSch.Transport + itemSch.OtherIncome + itemSch.Nhf + itemSch.Nhis + itemSch.Pension + itemSch.LifeAssurance;
                                            decimal? Ni = itemSch.Nhf + itemSch.Nhis + itemSch.Pension + itemSch.LifeAssurance;
                                            decimal? SumGross = Ti - Ni;

                                            var AddMontSch = new Schedulepdf
                                            {
                                                SerialNo = serialNo++,
                                                Rin = item.EmployeeRin,
                                                Name = $"{itemInd.Firstname} {itemInd.Othername} {itemInd.Surname}",
                                                TaxMonth = itemSch.TaxMonth,
                                                TaxYear = itemSch.TaxYear,
                                                Gross = SumGross,
                                                Cra = itemSch.Cra,
                                                Pension = itemSch.Pension,
                                                Nhf = itemSch.Nhf,
                                                Nhis = itemSch.Nhis,
                                                Tfp = itemSch.Tfp,
                                                Ci = itemSch.Ci,
                                                Tax = itemSch.Tax,
                                            };
                                            lstSch.Add(AddMontSch);
                                        }
                                    }

                                    var BusCmp = await _repo.AssetTaxPayerDetailsApis
                                        .Where(x => x.TaxPayerRinnumber == Obj.CompanyRin &&
                                                    x.AssetRin == Obj.BusinessRin)
                                        .ToListAsync();
                                    if (BusCmp is not null)
                                    {
                                        foreach (var itemCmp in BusCmp)
                                        {
                                            var AddCmpDet = new CompDetailsRes
                                            {
                                                TaxpayerName = itemCmp.TaxPayerName,
                                                BusinessName = itemCmp.AssetName,
                                                BusinessAddress = itemCmp.AssetAddress,
                                            };
                                            lstCmp.Add(AddCmpDet);

                                            var AddBus = new BusDetailsRes
                                            {
                                                BusinessRin = itemCmp.AssetRin,
                                                TaxpayerRin = itemCmp.TaxPayerRinnumber,
                                                BusinessPhone = itemCmp.TaxPayerMobileNumber
                                            };
                                            lstBus.Add(AddBus);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Response.Headers.Add("X-Status", "false");
                        Response.Headers.Add("X-Message", "Employer Not Found Or Not Approved");
                    }
                }

                if (!System.IO.File.Exists(htmlpath))
                {
                    throw new FileNotFoundException($"The HTML template file was not found at: {htmlpath}");
                }
                decimal? totalGros = lstSch.Sum(s => s.Gross);
                decimal? totlTax = lstSch.Sum(s => s.Tax);
                string TotalGross = totalGros.HasValue ? $"₦{totalGros.Value:N2}" : "₦0.00";
                string TotalTax = totlTax.HasValue ? $"₦{totlTax.Value:N2}" : "₦0.00";


                string htmlTemplate = System.IO.File.ReadAllText(htmlpath);

                string generatedRows = AllFunction.GenerateTableRows(lstSch);

                string htmlContent = htmlTemplate.Replace("@@TaxPayerName", lstCmp.FirstOrDefault()?.TaxpayerName ?? string.Empty)
                                                 .Replace("@@BusinessName", lstCmp.FirstOrDefault()?.BusinessName ?? string.Empty)
                                                 .Replace("@@BusinessAddress", lstCmp.FirstOrDefault()?.BusinessAddress ?? string.Empty)
                                                 .Replace("@@TaxpayerRin", lstBus.FirstOrDefault()?.TaxpayerRin ?? string.Empty)
                                                 .Replace("@@BusinessRin", lstBus.FirstOrDefault()?.BusinessRin ?? string.Empty)
                                                 .Replace("@@BusinessPhone", lstBus.FirstOrDefault()?.BusinessPhone ?? string.Empty)
                                                 .Replace("@@CurrentYear", Obj.TaxYear.ToString())
                                                 .Replace("@@Rows", generatedRows)
                                                 .Replace("@@TotalGross", TotalGross)
                                                 .Replace("@@TotalTax", TotalTax);


                //.Replace("@Rin", lstSch.FirstOrDefault()?.Rin ?? string.Empty)
                //              .Replace("@Name", lstSch.FirstOrDefault()?.Name ?? string.Empty)
                //              .Replace("@TaxMonth", lstSch.FirstOrDefault()?.TaxMonth ?? string.Empty)
                //              .Replace("@TaxYear", lstSch.FirstOrDefault()?.TaxYear.ToString() ?? string.Empty)
                //              .Replace("@Gross", lstSch.FirstOrDefault()?.Gross.ToString() ?? string.Empty)
                //              .Replace("@Cra", lstSch.FirstOrDefault()?.Cra.ToString() ?? string.Empty)
                //              .Replace("@Pension", lstSch.FirstOrDefault()?.Pension.ToString() ?? string.Empty)
                //              .Replace("@Nhf", lstSch.FirstOrDefault()?.Nhf.ToString() ?? string.Empty)
                //              .Replace("@Nhis", lstSch.FirstOrDefault()?.Nhis.ToString() ?? string.Empty)
                //              .Replace("@Tfp", lstSch.FirstOrDefault()?.Tfp.ToString() ?? string.Empty)
                //              .Replace("@Ci", lstSch.FirstOrDefault()?.Ci.ToString() ?? string.Empty)
                //              .Replace("@Tax", lstSch.FirstOrDefault()?.Tax.ToString() ?? string.Empty);


                var browserFetcher = new BrowserFetcher();
                await browserFetcher.DownloadAsync();

                using var browser = await PuppeteerSharp.Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
                using var page = await browser.NewPageAsync();
                await page.SetContentAsync(htmlContent);
                //var pdfBytes = await page.PdfDataAsync();
                var pdfOptions = new PdfOptions
                {
                    Format = PuppeteerSharp.Media.PaperFormat.A4,
                    PrintBackground = true,
                    Landscape = true
                };

                var pdfBytes = await page.PdfDataAsync(pdfOptions);

                string jsonData = JsonConvert.SerializeObject(lstSch);
                Response.Headers.Add("X-Data", jsonData);

                return File(pdfBytes, "application/pdf", "Download_Tax_Analysis.pdf");

            }
            catch (System.Exception ex)
            {
                // Log the exception details if necessary
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetAllAssessments")]
        public async Task<IActionResult> GetAllAssessments([FromQuery] EmpMtAss Obj)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            List<AllAssessmentRess> lstAss = new();
            try
            {
                var AllSch = await _phaseIIRepo.GetAssessmentSchudeleDetailsDownLoad(Obj);
                if (AllSch.Any())
                {
                    foreach (var sch in AllSch)
                    {
                        var AllAss = await _repo.EmployerMonthlyAssessments
                                .Where(x => x.BusinessId == sch.BusinessId &&
                                x.EmployerId == sch.EmployerId &&
                                x.TaxMonth == sch.TaxMonth &&
                                x.TaxYear == sch.TaxYear)
                                .ToListAsync();
                        if (AllAss != null)
                        {
                            foreach (var ass in AllAss)
                            {
                                var Allbus = await _repo.AssetTaxPayerDetailsApis
                                    .Where(o => o.AssetRin == Obj.BusinessRin &&
                                    o.TaxPayerRinnumber == Obj.CompanyRin)
                                    .ToListAsync();
                                if (Allbus != null)
                                {
                                    decimal? totalMonthlyTax = AllAss.Sum(a => a.TotalAssessed);
                                    decimal? totalAmountPaid = AllAss.Sum(a => a.TotalAmount);
                                    int totalEmployees = AllAss.Count;

                                    foreach (var bus in Allbus)
                                    {
                                        AllAssessmentRess Addass = new();
                                        Addass.BusinessRin = Obj.BusinessRin;
                                        Addass.BusinessName = bus.AssetName;
                                        Addass.DateGenerated = ass.CreatedDate;
                                        Addass.TaxYear = ass.TaxYear;
                                        Addass.TaxMonth = ass.TaxMonth;
                                        Addass.ListofEmployees = totalEmployees;
                                        Addass.AssessmentRefNo = ass.AssessmentRefNo;
                                        Addass.AssessmentRefId = ass.AssessmentRefId;
                                        Addass.TotalMonthlyTax = totalMonthlyTax;
                                        Addass.AmountPaid += totalAmountPaid;
                                        Addass.Balance = totalMonthlyTax - totalAmountPaid;
                                        Addass.PaymentStatus = totalAmountPaid >= totalMonthlyTax ? "Settled" : totalAmountPaid < totalMonthlyTax ? "Partial" : "Assessed";

                                        lstAss.Add(Addass);
                                    }

                                }
                            }
                        }
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "Employer Not Found In Schedule";
                    return Ok(r);
                }
                r.data = lstAss;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetAssessmentistory")]
        public async Task<IActionResult> GetAssessmentistory([FromQuery] EmpMtAss Obj)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            List<AllAssessmentRess> lstAss = new();
            AllAssessmentRess Addass = new();
            try
            {
                if (Obj is not null)
                {
                    var Allbus = await _repo.AssetTaxPayerDetailsApis
                            .Where(o => o.AssetRin == Obj.BusinessRin &&
                            o.TaxPayerRinnumber == Obj.CompanyRin)
                            .ToListAsync();

                    if (Allbus.Any())
                    {
                        foreach (var bus in Allbus)
                        {
                            var AllAss = await _repo.EmployerMonthlyAssessmentHistories
                                        .Where(x => x.BusinessId == bus.AssetId.ToString() &&
                                        x.EmployerId == bus.TaxPayerId.ToString() &&
                                        x.TaxMonth == Obj.TaxMonth &&
                                        x.TaxYear == Obj.TaxYear)
                                        .ToListAsync();

                            if (AllAss.Any())
                            {
                                decimal? totalMonthlyTax = AllAss.Sum(a => a.TotalAssessed);
                                decimal? totalAmountPaid = AllAss.Sum(a => a.TotalAmount);
                                int totalEmployees = AllAss.Count;

                                foreach (var ass in AllAss)
                                {
                                    Addass.BusinessRin = Obj.BusinessRin;
                                    Addass.BusinessName = bus.AssetName;
                                    Addass.DateGenerated = ass.CreatedDate;
                                    Addass.TaxYear = ass.TaxYear;
                                    Addass.TaxMonth = ass.TaxMonth;
                                    Addass.ListofEmployees = totalEmployees;
                                    Addass.AssessmentRefNo = ass.AssessmentRefNo;
                                    Addass.AssessmentRefId = ass.AssessmentRefId;
                                    Addass.TotalMonthlyTax = totalMonthlyTax;
                                    Addass.AmountPaid = totalAmountPaid;
                                    Addass.Balance = totalMonthlyTax - totalAmountPaid;
                                    Addass.PaymentStatus = totalAmountPaid >= totalMonthlyTax ? "Settled" : totalAmountPaid < totalMonthlyTax ? "Partial" : "Assessed";
                                }
                                lstAss.Add(Addass);
                            }
                        }
                    }
                    else
                    {
                        r.status = false;
                        r.message = "Taxpayer Not Found";
                        return Ok(r);
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "BusinessRin or CompanyRin Cannot Be Null";
                    return Ok(r);
                }



                r.data = lstAss;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetFileFormH3")]
        public async Task<IActionResult> GetFileFormH3([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            List<FileFormH3Vm> lstH3 = new();
            try
            {
                var Allbus = await _repo.AssetTaxPayerDetailsApis
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                if (Allbus.Any())
                {
                    foreach (var bus in Allbus)
                    {
                        var Income = await _repo.FormH3employeeUploads
                            .Where(x => x.BusinessId == bus.AssetId.ToString() &&
                                        x.CompanyId == bus.TaxPayerId.ToString())
                            .ToListAsync();
                        if (Income.Any())
                        {
                            foreach (var inc in Income)
                            {
                                FileFormH3Vm AddH3 = new FileFormH3Vm
                                {
                                    BusinessRin = bus.AssetRin,
                                    BusinessName = bus.AssetName,
                                    TotalIncome = inc.Basic + inc.Rent + inc.Transport + inc.OtherIncome + inc.Nhis + inc.Nhf + inc.Pension + inc.Lifeassurance,
                                    NonTaxibleIncome = inc.Nhis + inc.Nhf + inc.Pension + inc.Lifeassurance
                                };
                                lstH3.Add(AddH3);
                            }
                        }
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "Taxpayer Not Found";
                    return Ok(r);
                }

                r.data = lstH3;
                //r.totalCount = await _repo.AssetTaxPayerDetailsApis.CountAsync(); // Total record count for pagination
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpPut]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Mark-FileFormH3-Inactive")]
        public async Task<IActionResult> MarkFileFormH3Inactive([FromBody] MarkH3Inactive obj)
        {
            try
            {
                if (obj.BusinessRin == null || obj.CompanyRin == null)
                {
                    return NotFound(new ReturnObject { message = "EmployeeId, BusinessId, or CompanyId Cannot Be Null", status = false });
                }
                else
                {
                    var r = new ReturnObject { message = "Successfully Marked", status = true };
                    var buss = GetBusinessCompanyId(obj.BusinessRin, obj.CompanyRin);

                    EmpSchedule ObjBus = new EmpSchedule
                    {
                        BusinessId = buss.Result.BusinessId,
                        Companyid = buss.Result.Companyid,
                    };

                    var ss = await _repo.SspfiledFormH3s
                          .Where(e => e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                          .FirstOrDefaultAsync();


                    if (ss != null)
                    {
                        r.data = await _repo.SspfiledFormH3s
                         .Where(e => e.BusinessId == ObjBus.BusinessId && e.CompanyId == ObjBus.Companyid)
                         .ExecuteUpdateAsync(setters =>
                          setters.SetProperty(b => b.FiledStatus, "0"));
                    }
                    else
                    {
                        return NotFound(new ReturnObject { message = "CompanyRin not found", status = false });
                    }

                    return Ok(r);
                }

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
        [Route("UpdateFormH3")]
        public async Task<IActionResult> UploadFormH3([FromBody] UpdateEmpIncome1 obj)
        {
            try
            {
                var r = new ReturnObject { message = "Record Updated Successfully", status = true };
                if (obj != null)
                {
                    var buss = await GetBusinessCompanyId(obj.BusinessRin, obj.CompanyRin);
                    if (buss != null)
                    {
                        var ssp = await _repo.SspfiledFormH3s.Where(x => x.Rin == obj.EmployeeRin).ToListAsync();
                        if (ssp != null)
                        {
                            foreach (var Ind in ssp)
                            {
                                var mrk = await _repo.FormH3employeeUploads
                                  .Where(e => e.BusinessId == buss.BusinessId &&
                                  e.CompanyId == buss.Companyid &&
                                  e.IndividualId == Ind.IndividalId)
                                  .ExecuteUpdateAsync(
                                        setters =>
                                            setters
                                            .SetProperty(b => b.Basic, obj.Basic)
                                            .SetProperty(b => b.Rent, Convert.ToDecimal(obj.Rent))
                                            .SetProperty(b => b.Transport, obj.Transport)
                                            .SetProperty(b => b.OtherIncome, obj.Others)
                                                .SetProperty(b => b.Nhf, obj.Nhf)
                                            .SetProperty(b => b.Pension, obj.Pension)
                                            .SetProperty(b => b.Nhis, obj.Nhis)
                                            .SetProperty(b => b.Lifeassurance, obj.LifeAssurance)
                                            );

                            }
                        }
                        r.data = ssp;

                    }
                    if (buss == null)
                    {
                        return NotFound(new ReturnObject { message = "Employee or Company Not Found", status = false });
                    }

                }
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
        [Route("GetForwardScheduleH3")]
        public async Task<IActionResult> GetForwardScheduleH3([FromQuery] ScheduleH3 Obj)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Successfully Sent To Projection"
            };

            List<Models.Projection> lstH3 = new();
            List<ProjectRes> lstProj = new();
            try
            {
                var Allbus = await _repo.AssetTaxPayerDetailsApis
                    .Where(x => x.AssetRin == Obj.BusinessRin && x.TaxPayerRinnumber == Obj.CompanyRin)
                    .FirstOrDefaultAsync();

                if (Allbus.AssetId != null)
                {
                    var Fh3 = await _repo.SspfiledFormH3s
                        .Where(o => o.BusinessId == Allbus.AssetId.ToString() &&
                        o.CompanyId == Allbus.TaxPayerId.ToString() &&
                        o.TaxYear == Obj.TaxYear &&
                        o.FiledStatus == "1")
                        .ToListAsync();

                    if (Fh3.Any(o => o.ComplianceStatus == "2"))
                    {
                        foreach (var H3 in Fh3)
                        {
                            Models.Projection AddPro = new Models.Projection
                            {
                                AnnualProjectionId = "1",
                                CorporateId = 1,
                                AppId = 1,
                                CompanyName = Allbus.AssetName,
                                TaxpayerId = H3.Rin,
                                ProjectionYear = (int)H3.TaxYear,
                                FileProjectionStatus = H3.FiledStatus == "1" ? "True" : "False",
                                ForwardedTo = "true",
                                DateForwarded = DateTime.Now.ToString(),
                                CreatedAt = H3.Datetcreated.ToString(),
                                EmployeesCount = Fh3.Count,
                                BusinessId = Allbus.AssetId.ToString(),
                                BusinessName = Allbus.AssetName,
                                BusinessPrimaryId = (int)Allbus.AssetTypeId,
                                ApprovalStatus = 1,
                                Status = true,
                                UniqueId = Guid.NewGuid().ToString(),
                                IsDeleted = false,
                                CreatedBy = 1,
                                ModifiedBy = 1,
                                ModifiedAt = DateTime.Now,
                            };
                            lstH3.Add(AddPro);
                            await _repo.Projections.AddRangeAsync(lstH3);

                            ProjectRes addProRes = new ProjectRes();
                            addProRes.BusinessRin = Allbus.AssetRin;
                            addProRes.BusinessName = Allbus.AssetName;
                            addProRes.CompanyRin = Allbus.TaxPayerRinnumber;
                            addProRes.TaxYear = (int)H3.TaxYear;
                            addProRes.EmployeeCount = Fh3.Count;

                            lstProj.Add(addProRes);
                        }
                        await _repo.SaveChangesAsync();
                    }
                    else
                    {
                        r.status = false;
                        r.message = "Projection had already been submitted for the selected Year";
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "Taxpayer Not Found";
                    return Ok(r);
                }

                r.data = lstProj;
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetTccApplication")]
        public async Task<IActionResult> GetTccApplication([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Fetched Successfully"
            };

            List<FileFormH3Vm> lstH3 = new();
            try
            {
                var Allbus = await _repo.AssetTaxPayerDetailsApis
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                if (Allbus.Any())
                {
                    foreach (var bus in Allbus)
                    {
                        var Income = await _repo.FormH1employeeUploads
                            .Where(x => x.BusinessId == bus.AssetId.ToString() &&
                                        x.CompanyId == bus.TaxPayerId.ToString())
                            .ToListAsync();
                        if (Income.Any())
                        {
                            foreach (var inc in Income)
                            {
                                FileFormH3Vm AddH3 = new FileFormH3Vm
                                {
                                    BusinessRin = bus.AssetRin,
                                    BusinessName = bus.AssetName,
                                    TotalIncome = inc.Basic + inc.Rent + inc.Transport + inc.OtherIncome + inc.Nhis + inc.Nhf + inc.Pension + inc.Lifeassurance,
                                    NonTaxibleIncome = inc.Nhis + inc.Nhf + inc.Pension + inc.Lifeassurance
                                };
                                lstH3.Add(AddH3);
                            }
                        }
                    }
                }
                else
                {
                    r.status = false;
                    r.message = "Taxpayer Not Found";
                    return Ok(r);
                }

                r.data = lstH3;
                //r.totalCount = await _repo.AssetTaxPayerDetailsApis.CountAsync(); 
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetTccApplicationView")]
        public async Task<IActionResult> GetTccApplicationView([FromQuery] TccH1 Obj)
        {
            var r = new ReturnObject
            {
                status = true,
                message = "Record Successfully Sent To Projection"
            };

            List<FormH1ScheduleViewModel> formH1Schedules = new();
            try
            {
                var Allbus = await _repo.AssetTaxPayerDetailsApis
                    .Where(x => x.AssetRin == Obj.BusinessRin && x.TaxPayerRinnumber == Obj.CompanyRin)
                    .FirstOrDefaultAsync();

                if (Allbus?.AssetId != null)
                {
                    var Fh3 = await _repo.FormH1employeeUploads
                        .Where(o => o.BusinessId == Allbus.AssetId.ToString() &&
                                    o.CompanyId == Allbus.TaxPayerId.ToString())
                        .ToListAsync();

                    if (Fh3.Any())
                    {
                        foreach (var item in Fh3)
                        {
                            var Ind = await _repo.Individuals
                                .Where(x => x.EmployeeId == item.IndividalId)
                                .ToListAsync();
                            if (Ind.Any())
                            {
                                foreach (var ss in Ind)
                                {
                                    formH1Schedules.Add(new FormH1ScheduleViewModel
                                    {
                                        EmployeeRin = ss.EmployeeRin,
                                        EmployeeName = $"{ss.Firstname} {ss.Othername} {ss.Surname}",
                                        TccStatus = item.TccStatus != "Issued" ? "Applied" : "No Action",
                                        IsSelected = false
                                    });
                                }
                            }

                        }
                    }



                    r.data = formH1Schedules;
                }
                else
                {
                    r.status = false;
                    r.message = "Taxpayer Not Found";
                }

                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                });
            }
        }









        [NonAction]
        private IList<BusinessRinVm> GetList(List<AssetTaxPayerDetailsApi> det)
        {
            var list = new List<BusinessRinVm>();
            for (int i = 0; i < det.Count(); i++)
            {
                list.Add(new BusinessRinVm
                {
                    businessRin = det[i].TaxPayerRinnumber,
                    businessName = det[i].AssetName,
                    businessAddress = det[i].AssetAddress,
                    CompanyRin = det[i].TaxPayerRinnumber

                });
            }
            return list;
        }
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
        private async Task<List<DownloadEmployeeResponse>> GetEmployeeDetailsAsync(DownloadEmployeeFm Obj)
        {
            var lstEmpDwn = new List<DownloadEmployeeResponse>();

            var GetBusId = GetBusinessCompanyId(Obj.BusinessRin, Obj.CompanyRin);
            if (GetBusId is not null)
            {
                var EmpSch = await _repo.EmployeesMonthlySchedules
                                    .Where(e => e.EmployerId == GetBusId.Result.Companyid &&
                                    e.BusinessId == GetBusId.Result.BusinessId &&
                                    e.TaxMonth == Obj.TaxMonth &&
                                    e.TaxYear == Obj.TaxYear)
                                    .ToListAsync();
                if (EmpSch != null)
                {
                    foreach (var item in EmpSch)
                    {
                        var EmpInd = GetEmployeeList(item.EmployeeRin);
                        if (EmpInd is not null)
                        {
                            foreach (var Emp in EmpInd.Result)
                            {
                                var AddDwnLd = new DownloadEmployeeResponse
                                {
                                    FullName = $"{Emp.Surname} {Emp.Firstname} {Emp.Othername}",
                                    PHONENUMBER = Emp.Phonenumber,
                                    NIN = Emp.Nin,
                                    NATIONALITY = Emp.Nationality,
                                    EmployeeRin = Emp.EmployeeRin,
                                    TaxMonth = item.TaxMonth,
                                    TaxYear = item.TaxYear,
                                    TotalIncome = (item.Basic + item.Rent + item.Transport + item.Transport + item.OtherIncome + item.Pension + item.Nhf + item.Nhis + item.LifeAssurance) ?? 0,
                                    NonTaxibleIncome = (item.Pension + item.Nhf + item.Nhis + item.LifeAssurance) ?? 0,
                                    GrossIncome = (item.Basic + item.Rent + item.Transport + item.Transport + item.OtherIncome + item.Pension + item.Nhf + item.Nhis + item.LifeAssurance) - (item.Pension + item.Nhf + item.Nhis + item.LifeAssurance) ?? 0,
                                    Cra = item.Cra ?? 0,
                                    Tfp = item.Tfp ?? 0,
                                    Ci = item.Ci ?? 0,
                                    Tax = item.Tax ?? 0,
                                };
                                lstEmpDwn.Add(AddDwnLd);
                            }
                        }
                    }
                }

            }

            return lstEmpDwn;
        }
        [NonAction]
        public async Task<BusCmp> GetBusinessCompanyId(string businessRin, string companyRin)
        {
            BusCmp bus = new BusCmp();

            var buss = await _repo.AssetTaxPayerDetailsApis
                .Where(b => b.AssetRin == businessRin && b.TaxPayerRinnumber == companyRin)
                .FirstOrDefaultAsync();

            if (buss != null)
            {
                bus.BusinessId = buss.AssetId.ToString();
                bus.Companyid = buss.TaxPayerId.ToString();
            }

            return bus;
        }

        [NonAction]
        private async Task<string> GetEmployeeRin(string taxpayerid)
        {
            var buss = await _repo.Individuals
                           .Where(e => e.EmployeeId == taxpayerid)
                           .FirstOrDefaultAsync();

            string taxRin = buss.EmployeeRin;
            return taxRin;

        }

        [NonAction]
        private async Task<string> GetEmployeeID(string taxpayerRin)
        {
            var buss = await _repo.Individuals
                           .Where(e => e.EmployeeRin == taxpayerRin)
                           .FirstOrDefaultAsync();

            string taxId = buss.EmployeeId;
            return taxId;

        }

        [NonAction]
        public async Task<List<Individual>> GetEmployeeList(string EmployeeRin)
        {
            var buss = await _repo.Individuals
                           .Where(e => e.EmployeeRin == EmployeeRin)
                           .ToListAsync();
            return buss;
        }
    }
}