using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Nancy.Json;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.Model;
using SelfPortalAPi.NewTables;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;
using static SelfPortalAPi.AllFunction;

namespace SelfPortalAPi.Controllers.Admin
{
    // Allow CORS for all origins. (Caution!)
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FormHController : ControllerBase
    {
        //  private readonly IRepository<FormH1> _repo;
        private readonly IRepository<FiledFormH> _repof;
        private readonly IOptions<ConnectionStrings> _serviceSettings;
        private readonly PayeeContext _con;

        public FormHController(IOptions<ConnectionStrings> serviceSettings, IRepository<FiledFormH> repof, PayeeContext con)
        {
            _serviceSettings = serviceSettings;
            _repof = repof;
            _con = con;
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("UploadH1")]
        public async Task<IActionResult> UploadH1([FromForm] AddFormH obj)
        {
            var presList = _con.FormH1s.Where(o => o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId).ToList();
            var r = new ReturnObject();
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var resp = "";
            List<FormH1> lstFormH1 = new();
            Receiver rootobjectVm = new();
            try
            {
                var la = new List<FormH1FM>();
                r.status = true;
                r.message = "Record saved Successfully";
                if (obj.File != null && obj.File.Length > 0)
                {
                    var table = AllFunction.ConvertExcelToDatatable(obj.File);
                    la = AllFunction.ConvertDataTable<FormH1FM>(table);
                    if (la.Count > 0)
                    {
                        var toberemoved = la.Where(o => o.PHONENUMBER == "NULL" && o.RIN == "NULL" && o.JTBTIN == "NULL").ToList();
                        la = la.Except(toberemoved).ToList();
                        var token = GetToken();
                        if (token != null)
                        {
                            foreach (var fm in la)
                            {
                                if (fm.PHONENUMBER != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                }
                                else if (fm.RIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                }
                                else if (fm.JTBTIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
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
                                    mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                    AddTaxPayer ad = new();
                                    ad.TaxPayerTypeId = 1;
                                    ad.GenderID = 1;
                                    ad.TitleID = 2;
                                    ad.FirstName = fm.FIRSTNAME;
                                    ad.LastName = fm.SURNAME;
                                    ad.MiddleName = fm.OTHERNAME;
                                    ad.DOB = "01/01/2004";
                                    ad.TIN = fm.JTBTIN;
                                    ad.MobileNumber1 = fm.PHONENUMBER;
                                    ad.EmailAddress1 = "abc@gmail.com";
                                    ad.BiometricDetails = "";
                                    ad.TaxOfficeID = 34;
                                    ad.MaritalStatusID = 3;
                                    ad.NationalityID = 1;
                                    ad.EconomicActivitiesID = 1;
                                    ad.NotificationMethodID = 1;
                                    ad.ContactAddress = fm.HOMEADDRESS;
                                    string jsonData = js.Serialize(ad);
                                    resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (fm.PHONENUMBER != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                        }
                                        else if (fm.RIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                        }
                                        else if (fm.JTBTIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                        }
                                        else
                                        {
                                            r.status = false;
                                            r.message = "Error Occured Processing Record To ERAS";
                                            return Ok(r);
                                        }

                                        resp = await CallAPi(baseUrl, token, "get", "");
                                    }
                                }
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    lstFormH1.Add(new FormH1
                                    {
                                        BusinessId = obj.BusinessId,
                                        CompanyId = obj.CompanyId,
                                        FIRSTNAME = fm.FIRSTNAME,
                                        SURNAME = fm.SURNAME,
                                        OtherIncome = fm.OtherIncome,
                                        OTHERNAME = fm.OTHERNAME,
                                        PHONENUMBER = fm.PHONENUMBER,
                                        RIN = fm.RIN == "NULL" ? rootobjectVm.Result.FirstOrDefault().TaxPayerRIN : fm.RIN,
                                        TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                        JTBTIN = fm.JTBTIN,
                                        NIN = fm.NIN,
                                        NATIONALITY = fm.NATIONALITY,
                                        HOMEADDRESS = fm.HOMEADDRESS,
                                        Designation = fm.Designation,
                                        PENSION = fm.PENSION,
                                        NHF = fm.NHF,
                                        NHIS = fm.NHIS,
                                        LIFEASSURANCE = fm.LIFEASSURANCE,
                                        CONSOLIDATEDRELIEFALLOWANCECRA = fm.CONSOLIDATEDRELIEFALLOWANCECRA,
                                        ANNUALTAXPAID = fm.ANNUALTAXPAID,
                                        TOTALMONTHSPAID = fm.TOTALMONTHSPAID,
                                        Rent = fm.Rent,
                                        Transport = fm.Transport,
                                        Basic = fm.Basic
                                    });
                                }
                                mainBaseurl = "";
                            }
                            if (presList.Count() > 0)
                            {
                                var rem = lstFormH1.Where(itemB => !presList.Any(itemA =>
              itemA.GetType().GetProperty("FIRSTNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("FIRSTNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("SURNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("SURNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("RIN").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("RIN").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("PHONENUMBER").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("PHONENUMBER").GetValue(itemB, null)))).ToList();
                                _con.FormH1s.AddRange(rem);
                            }
                            else
                            {
                                _con.FormH1s.AddRange(lstFormH1);
                            }
                            await _con.SaveChangesAsync();
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
        [Route("UploadH3")]
        public async Task<IActionResult> UploadH3([FromForm] AddFormH obj)
        {
            var presList = _con.FormH3s.Where(o => o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId).ToList();

            var r = new ReturnObject();
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var resp = "";
            List<FormH3> lstFormH1 = new();
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
                    if (la.Count > 0)
                    {
                        var toberemoved = la.Where(o => o.PHONENUMBER == "NULL" && o.RIN == "NULL" && o.JTBTIN == "NULL").ToList();
                        la = la.Except(toberemoved).ToList();
                        var token = GetToken();
                        if (token != null)
                        {
                            foreach (var fm in la)
                            {
                                if (fm.PHONENUMBER != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                }
                                else if (fm.RIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                }
                                else if (fm.JTBTIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
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
                                    mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                    AddTaxPayer ad = new();
                                    ad.TaxPayerTypeId = 1;
                                    ad.GenderID = 1;
                                    ad.TitleID = 2;
                                    ad.FirstName = fm.FIRSTNAME;
                                    ad.LastName = fm.SURNAME;
                                    ad.MiddleName = fm.OTHERNAME;
                                    ad.DOB = "01/01/2004";
                                    ad.TIN = fm.JTBTIN;
                                    ad.MobileNumber1 = fm.PHONENUMBER;
                                    ad.EmailAddress1 = "abc@gmail.com";
                                    ad.BiometricDetails = "";
                                    ad.TaxOfficeID = 34;
                                    ad.MaritalStatusID = 3;
                                    ad.NationalityID = 1;
                                    ad.EconomicActivitiesID = 1;
                                    ad.NotificationMethodID = 1;
                                    ad.ContactAddress = fm.HOMEADDRESS;
                                    string jsonData = js.Serialize(ad);
                                    resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (fm.PHONENUMBER != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                        }
                                        else if (fm.RIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                        }
                                        else if (fm.JTBTIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                        }
                                        else
                                        {
                                            r.status = false;
                                            r.message = "Error Occured Processing Record To ERAS";
                                            return Ok(r);
                                        }

                                        resp = await CallAPi(baseUrl, token, "get", "");
                                    }
                                }
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    lstFormH1.Add(new FormH3
                                    {
                                        BusinessId = obj.BusinessId,
                                        CompanyId = obj.CompanyId,
                                        FIRSTNAME = fm.FIRSTNAME,
                                        SURNAME = fm.SURNAME,
                                        OtherIncome = fm.OtherIncome,
                                        OTHERNAME = fm.OTHERNAME,
                                        PHONENUMBER = fm.PHONENUMBER,
                                        STARTMONTH = fm.STARTMONTH,
                                        RIN = fm.RIN == "NULL" ? rootobjectVm.Result.FirstOrDefault().TaxPayerRIN : fm.RIN,
                                        TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                        JTBTIN = fm.JTBTIN,
                                        NIN = fm.NIN,
                                        NATIONALITY = fm.NATIONALITY,
                                        HOMEADDRESS = fm.HOMEADDRESS,
                                        Designation = fm.Designation,
                                        PENSION = fm.PENSION,
                                        NHF = fm.NHF,
                                        NHIS = fm.NHIS,
                                        LIFEASSURANCE = fm.LIFEASSURANCE,
                                        Rent = fm.Rent,
                                        Transport = fm.Transport,
                                        Basic = fm.Basic
                                    });
                                }
                                mainBaseurl = "";
                            }
                            if (presList.Count() > 0)
                            {
                                var rem = lstFormH1.Where(itemB => !presList.Any(itemA =>
              itemA.GetType().GetProperty("FIRSTNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("FIRSTNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("SURNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("SURNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("RIN").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("RIN").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("PHONENUMBER").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("PHONENUMBER").GetValue(itemB, null)))).ToList();
                                _con.FormH3s.AddRange(rem);
                            }
                            else
                            {
                                _con.FormH3s.AddRange(lstFormH1);
                            }
                            await _con.SaveChangesAsync();
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
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("H1WithoutUpload")]
        public async Task<IActionResult> H1WithoutUpload([FromForm] AddFormHWith obj)
        {
            // byte[] bytes = Convert.FromBase64String(obj.File);
            var formFile = new Base64FormFile(obj.File, "excel_file.xlsx");

            //System.IO.File.WriteAllBytes(filePath, bytes);

            var presList = _con.FormH1s.Where(o => o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId).ToList();
            var r = new ReturnObject();
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var resp = "";
            List<FormH1> lstFormH1 = new();
            Receiver rootobjectVm = new();
            try
            {
                var la = new List<FormH1FM>();
                r.status = true;
                r.message = "Record saved Successfully";
                if (obj.File != null && obj.File.Length > 0)
                {
                    var table = AllFunction.ConvertExcelToDatatable(formFile);
                    la = AllFunction.ConvertDataTable<FormH1FM>(table);
                    if (la.Count > 0)
                    {
                        var toberemoved = la.Where(o => o.PHONENUMBER == "NULL" && o.RIN == "NULL" && o.JTBTIN == "NULL").ToList();
                        la = la.Except(toberemoved).ToList();
                        var token = GetToken();
                        if (token != null)
                        {
                            foreach (var fm in la)
                            {
                                if (fm.PHONENUMBER != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                }
                                else if (fm.RIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                }
                                else if (fm.JTBTIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
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
                                    mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                    AddTaxPayer ad = new();
                                    ad.TaxPayerTypeId = 1;
                                    ad.GenderID = 1;
                                    ad.TitleID = 2;
                                    ad.FirstName = fm.FIRSTNAME;
                                    ad.LastName = fm.SURNAME;
                                    ad.MiddleName = fm.OTHERNAME;
                                    ad.DOB = "01/01/2004";
                                    ad.TIN = fm.JTBTIN;
                                    ad.MobileNumber1 = fm.PHONENUMBER;
                                    ad.EmailAddress1 = "abc@gmail.com";
                                    ad.BiometricDetails = "";
                                    ad.TaxOfficeID = 34;
                                    ad.MaritalStatusID = 3;
                                    ad.NationalityID = 1;
                                    ad.EconomicActivitiesID = 1;
                                    ad.NotificationMethodID = 1;
                                    ad.ContactAddress = fm.HOMEADDRESS;
                                    string jsonData = js.Serialize(ad);
                                    resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (fm.PHONENUMBER != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                        }
                                        else if (fm.RIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                        }
                                        else if (fm.JTBTIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                        }
                                        else
                                        {
                                            r.status = false;
                                            r.message = "Error Occured Processing Record To ERAS";
                                            return Ok(r);
                                        }

                                        resp = await CallAPi(baseUrl, token, "get", "");
                                    }
                                }
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    lstFormH1.Add(new FormH1
                                    {
                                        BusinessId = obj.BusinessId,
                                        CompanyId = obj.CompanyId,
                                        FIRSTNAME = fm.FIRSTNAME,
                                        SURNAME = fm.SURNAME,
                                        OtherIncome = fm.OtherIncome,
                                        OTHERNAME = fm.OTHERNAME,
                                        PHONENUMBER = fm.PHONENUMBER,
                                        RIN = fm.RIN == "NULL" ? rootobjectVm.Result.FirstOrDefault().TaxPayerRIN : fm.RIN,
                                        TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                        JTBTIN = fm.JTBTIN,
                                        NIN = fm.NIN,
                                        NATIONALITY = fm.NATIONALITY,
                                        HOMEADDRESS = fm.HOMEADDRESS,
                                        Designation = fm.Designation,
                                        PENSION = fm.PENSION,
                                        NHF = fm.NHF,
                                        NHIS = fm.NHIS,
                                        LIFEASSURANCE = fm.LIFEASSURANCE,
                                        CONSOLIDATEDRELIEFALLOWANCECRA = fm.CONSOLIDATEDRELIEFALLOWANCECRA,
                                        ANNUALTAXPAID = fm.ANNUALTAXPAID,
                                        TOTALMONTHSPAID = fm.TOTALMONTHSPAID,
                                        Rent = fm.Rent,
                                        Transport = fm.Transport,
                                        Basic = fm.Basic
                                    });
                                }
                                mainBaseurl = "";
                            }
                            if (presList.Count() > 0)
                            {
                                var rem = lstFormH1.Where(itemB => !presList.Any(itemA =>
              itemA.GetType().GetProperty("FIRSTNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("FIRSTNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("SURNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("SURNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("RIN").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("RIN").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("PHONENUMBER").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("PHONENUMBER").GetValue(itemB, null)))).ToList();
                                _con.FormH1s.AddRange(rem);
                            }
                            else
                            {
                                _con.FormH1s.AddRange(lstFormH1);
                            }
                            await _con.SaveChangesAsync();
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
                    data = ex.InnerException,
                    message = ex.Message
                };
                return Ok(res);
            }
        }
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("H3WithoutUpload")]
        public async Task<IActionResult> H3WithoutUpload([FromForm] AddFormHWith obj)
        {
            var formFile = new Base64FormFile(obj.File, "excel_file.xlsx");

            var presList = _con.FormH3s.Where(o => o.BusinessId == obj.BusinessId && o.CompanyId == obj.CompanyId).ToList();

            var r = new ReturnObject();
            var baseUrl = _serviceSettings.Value.ErasBaseUrl;
            string mainBaseurl = "";
            JavaScriptSerializer js = new();
            var resp = "";
            List<FormH3> lstFormH1 = new();
            Receiver rootobjectVm = new();
            try
            {
                var la = new List<FormH3FM>();
                r.status = true;
                r.message = "Record saved Successfully";
                if (obj.File != null && obj.File.Length > 0)
                {
                    var table = AllFunction.ConvertExcelToDatatable(formFile);
                    la = AllFunction.ConvertDataTable<FormH3FM>(table);
                    if (la.Count > 0)
                    {
                        var toberemoved = la.Where(o => o.PHONENUMBER == "NULL" && o.RIN == "NULL" && o.JTBTIN == "NULL").ToList();
                        la = la.Except(toberemoved).ToList();
                        var token = GetToken();
                        if (token != null)
                        {
                            foreach (var fm in la)
                            {
                                if (fm.PHONENUMBER != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                }
                                else if (fm.RIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                }
                                else if (fm.JTBTIN != "NULL")
                                {
                                    mainBaseurl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
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
                                    mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
                                    AddTaxPayer ad = new();
                                    ad.TaxPayerTypeId = 1;
                                    ad.GenderID = 1;
                                    ad.TitleID = 2;
                                    ad.FirstName = fm.FIRSTNAME;
                                    ad.LastName = fm.SURNAME;
                                    ad.MiddleName = fm.OTHERNAME;
                                    ad.DOB = "01/01/2004";
                                    ad.TIN = fm.JTBTIN;
                                    ad.MobileNumber1 = fm.PHONENUMBER;
                                    ad.EmailAddress1 = "abc@gmail.com";
                                    ad.BiometricDetails = "";
                                    ad.TaxOfficeID = 34;
                                    ad.MaritalStatusID = 3;
                                    ad.NationalityID = 1;
                                    ad.EconomicActivitiesID = 1;
                                    ad.NotificationMethodID = 1;
                                    ad.ContactAddress = fm.HOMEADDRESS;
                                    string jsonData = js.Serialize(ad);
                                    resp = await CallAPi(mainBaseurl, token, "post", jsonData);
                                    rootobjectVm = js.Deserialize<Receiver>(resp);
                                    if (rootobjectVm.Success == true)
                                    {
                                        if (fm.PHONENUMBER != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + fm.PHONENUMBER;
                                        }
                                        else if (fm.RIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + fm.RIN;
                                        }
                                        else if (fm.JTBTIN != "NULL")
                                        {
                                            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByTIN?TaxPayerTIN=" + fm.JTBTIN;
                                        }
                                        else
                                        {
                                            r.status = false;
                                            r.message = "Error Occured Processing Record To ERAS";
                                            return Ok(r);
                                        }

                                        resp = await CallAPi(baseUrl, token, "get", "");
                                    }
                                }
                                rootobjectVm = js.Deserialize<Receiver>(resp);
                                if (rootobjectVm.Success == true)
                                {
                                    lstFormH1.Add(new FormH3
                                    {
                                        BusinessId = obj.BusinessId,
                                        CompanyId = obj.CompanyId,
                                        FIRSTNAME = fm.FIRSTNAME,
                                        SURNAME = fm.SURNAME,
                                        OtherIncome = fm.OtherIncome,
                                        OTHERNAME = fm.OTHERNAME,
                                        PHONENUMBER = fm.PHONENUMBER,
                                        STARTMONTH = fm.STARTMONTH,
                                        RIN = fm.RIN == "NULL" ? rootobjectVm.Result.FirstOrDefault().TaxPayerRIN : fm.RIN,
                                        TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                        JTBTIN = fm.JTBTIN,
                                        NIN = fm.NIN,
                                        NATIONALITY = fm.NATIONALITY,
                                        HOMEADDRESS = fm.HOMEADDRESS,
                                        Designation = fm.Designation,
                                        PENSION = fm.PENSION,
                                        NHF = fm.NHF,
                                        NHIS = fm.NHIS,
                                        LIFEASSURANCE = fm.LIFEASSURANCE,
                                        Rent = fm.Rent,
                                        Transport = fm.Transport,
                                        Basic = fm.Basic
                                    });
                                }
                                mainBaseurl = "";
                            }
                            if (presList.Count() > 0)
                            {
                                var rem = lstFormH1.Where(itemB => !presList.Any(itemA =>
              itemA.GetType().GetProperty("FIRSTNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("FIRSTNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("SURNAME").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("SURNAME").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("RIN").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("RIN").GetValue(itemB, null)) &&
              itemA.GetType().GetProperty("PHONENUMBER").GetValue(itemA, null).Equals(itemB.GetType().GetProperty("PHONENUMBER").GetValue(itemB, null)))).ToList();
                                _con.FormH3s.AddRange(rem);
                            }
                            else
                            {
                                _con.FormH3s.AddRange(lstFormH1);
                            }
                            await _con.SaveChangesAsync();
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
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
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
                r.status = true;
                r.message = "Record saved Successfully";
                var lstFormH1 = GetListFiledFormH(obj, 1);
                _con.FiledFormH.AddRange(lstFormH1);
                await _con.SaveChangesAsync();
                return await Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
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
                r.status = true;
                r.message = "Record saved Successfully";
                var lstFormH1 = GetListFiledFormH(obj, 3);
                _con.FiledFormH.AddRange(lstFormH1);
                await _con.SaveChangesAsync();
                return await Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return await Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-uploadedH3bybusinessId{businessId}/bycompanyId{companyId}")]
        public async Task<IActionResult> getuploadedH3([FromRoute] string businessId, [FromRoute] string companyId)
        {
            try
            {
                var r = _con.FormH3s.Where(o => o.BusinessId == businessId && o.CompanyId == companyId).ToList();
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
        [Route("get-uploadedH1bybusinessId{businessId}/bycompanyId{companyId}")]
        public async Task<IActionResult> getuploadedH1([FromRoute] string businessId, [FromRoute] string companyId)
        {
            try
            {
                var r = _con.FormH1s.Where(o => o.BusinessId == businessId && o.CompanyId == companyId).ToList();
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
        [Route("get-FiledH1bybusinessId{businessId}/bycompanyId{companyId}/bytaxYear{taxyear}")]
        public async Task<IActionResult> getFiledH1([FromRoute] string businessId, [FromRoute] string companyId, [FromRoute] string taxyear)
        {
            try
            {
                var r = GetFiledRecords(businessId, companyId, taxyear, 1).ToList();
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
        [Route("get-FiledH3bybusinessId{businessId}/bycompanyId{companyId}/bytaxYear{taxyear}")]
        public async Task<IActionResult> getFiledH3([FromRoute] string businessId, [FromRoute] string companyId, [FromRoute] string taxyear)
        {
            try
            {
                var r = GetFiledRecords(businessId, companyId, taxyear, 3).ToList();
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
        public IEnumerable<FiledFormH> GetFiledRecords(string businessId, string companyId, string taxyear, int source)
        {
            return _repof.GetAll().Where(o => o.Source == source && o.BusinessId == businessId && o.CompanyId == companyId && o.TaxYear == taxyear);
        }
        [NonAction]
        public List<FiledFormH> GetListFiledFormH(FileFormH1 obj, int source)
        {
            List<FiledFormH> lstFormH1 = new();
            foreach (var fm in obj.TaxPayerIds)
            {
                FiledFormH mod = new FiledFormH
                {
                    BusinessId = obj.BusinessId,
                    CompanyId = obj.CompanyId,
                    TaxYear = obj.TaxYear.ToString(),
                    FiledStatus = "1",
                    Source = source,
                    UniqueId = Guid.NewGuid().ToString(),
                    TaxPayerId = fm.TaxPayerId
                };
                lstFormH1.Add(mod);
            }
            return lstFormH1;
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
}