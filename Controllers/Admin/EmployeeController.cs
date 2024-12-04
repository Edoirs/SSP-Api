
namespace SelfPortalAPi.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EmployeeController : ControllerBase
{
    private readonly SelfServiceConnect _context;
    private readonly IOptions<ConnectionStrings> _serviceSettings;
    private readonly IMapper _mapper;
    private readonly SelfServiceConnect _repo;
    private string errMsg = "Unable to process request, kindly try again";
    public EmployeeController(SelfServiceConnect repo, IOptions<ConnectionStrings> serviceSettings,  IMapper mapper, SelfServiceConnect context)
    {
        _serviceSettings = serviceSettings;
        _repo = repo;
        _mapper = mapper;
        _context = context;
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getall")]
    public Task<IActionResult> GetAll()
    {
        var r = new ReturnObject();
        r.status = true;
        r.message = "Record Fetched Successfully";
        try
        {
            r.data = _repo.Employees.Where(o => o.IsDeleted == false).ToList();
            return Task.FromResult<IActionResult>(Ok(r));
        }
        catch (System.Exception ex)
        {
            return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("getalldeleted")]
    public Task<IActionResult> GetAllDeleted()
    {
        var r = new ReturnObject();
        r.status = true;
        r.message = "Record Fetched Successfully";
        try
        {
            r.data = _repo.Employees.Where(o => o.IsDeleted == true).ToList();
            return Task.FromResult<IActionResult>(Ok(r));
        }
        catch (System.Exception ex)
        {
            return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }


    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("GetEmployeeByDetail")]
    public Task<IActionResult> GetEmployeeByDetail([FromBody] GetEmployee obj)
    {
        var r = new ReturnObject();
        r.status = true;
        r.message = "Record Fetched Successfully";
        try
        {
            r.data = _context.Employees.FromSqlRaw($"select * from employees where corporate_id ={obj.corporate_id} and business_id ={obj.business_id}");

            return Task.FromResult<IActionResult>(Ok(r));
        }
        catch (System.Exception ex)
        {
            return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }
    }
    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("AddEmployee")]
    public async Task<IActionResult> AddEmployee([FromBody] AddEmployee obj)
    {
        var emp = _mapper.Map<Employee>(obj);
        var r = new ReturnObject();
        AllFunction al = new();
        JavaScriptSerializer js = new();
        string baseUrl = _serviceSettings.Value.ErasBaseUrl;
        string mainBaseurl = _serviceSettings.Value.ErasBaseUrl + "TaxPayer/Individual/Insert";
        if (!string.IsNullOrEmpty(obj.phone))
        {
            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByMobileNumber?MobileNumber=" + obj.phone;
        }
        else if (!string.IsNullOrEmpty(obj.tin))
        {
            baseUrl = baseUrl + "TaxPayer/SearchTaxPayerByRIN?TaxPayerRIN=" + obj.tin;
        }
        else
        {
            r.status = false;
            r.message = "Error Occured Phone Number and TIN cant be null";
            return Ok(r);
        }
        AddTaxPayer ad = new();
        ad.TaxPayerTypeId = 1;
        ad.GenderID = 1;
        ad.TitleID = 2;
        ad.FirstName = obj.first_name;
        ad.LastName = obj.last_name;
        ad.MiddleName = obj.other_name;
        ad.DOB = "01/01/2004";
        ad.TIN = obj.tin;
        ad.MobileNumber1 = obj.phone;
        ad.EmailAddress1 = "abc@gmail.com";
        ad.BiometricDetails = "";
        ad.TaxOfficeID = 34;
        ad.NewTaxOfficeID = 34;
        ad.PresentTaxOfficeID = 34;
        ad.MaritalStatusID = 3;
        ad.NationalityID = 1;
        ad.EconomicActivitiesID = 1;
        ad.NotificationMethodID = 1;
        ad.ContactAddress = obj.home_address;
        string jsonData = js.Serialize(ad);


        var token = al.GetToken(_serviceSettings.Value.ErasBaseUrl, _serviceSettings.Value.eirsusername, _serviceSettings.Value.eirspassword);
        if (token != null)
        {
            var resp = await al.CallAPi(baseUrl, token, "get", "");
            var rootobjectVm = js.Deserialize<Receiver>(resp);
            if (rootobjectVm.Result.Count <= 0)
            {
                resp = await al.CallAPi(mainBaseurl, token, "post", jsonData);
                rootobjectVm = js.Deserialize<Receiver>(resp);
                if (rootobjectVm.Success == true)
                {
                    resp = await al.CallAPi(baseUrl, token, "get", "");
                    rootobjectVm = js.Deserialize<Receiver>(resp);
                    if (rootobjectVm.Success == true)
                    {
                        var sp = new Individual
                        {
                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                            Firstname = obj.first_name,
                            Surname = obj.last_name,
                            Othername = obj.other_name,
                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                            Jtbtin = obj.tin,
                            Nin = obj.nin,
                            Bvn = obj.bvn,
                            ZipCode = obj.zip_code,
                            LgaCode = obj.lga_code,
                            Nationality = obj.nationality,
                            Homeaddress = obj.home_address,
                            Designation = obj.designation
                        };
                        _context.Individuals.Add(sp);
                        if (obj.source.ToLower() == "monthly")
                        {
                            var mon = new EmployeesMonthlyIncome
                            {
                                Pension = obj.pension,
                                Nhf = obj.nhf,
                                Nhis = obj.nhis,
                                LifeAssurance = obj.life_assurance,
                                Rent = obj.rent,
                                Transport = obj.transport,
                                Basic = obj.basic,
                                Others = obj.other_income,
                                EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                BusinessId = obj.business_id.ToString(),
                                CompanyId = obj.corporate_id.ToString(),
                                CreatedDate = DateTime.UtcNow,
                                ModifiedDate = DateTime.UtcNow,
                                Status = true
                            };

                            _context.EmployeesMonthlyIncomes.Add(mon);

                        }
                        else if (obj.source.ToLower() == "formh3")
                        {
                            var sspFm = new SspformH3
                            {
                                Datetcreated = DateTime.UtcNow,
                                Datemodified = DateTime.UtcNow,
                                BusinessId = obj.business_id.ToString(),
                                CompanyId = obj.corporate_id.ToString(),
                                TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                IndividualId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                Rin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                Pension = obj.pension,
                                Nhf = obj.nhf,
                                Nhis = obj.nhis,
                                Lifeassurance = obj.life_assurance,
                                Rent = obj.rent,
                                Startmonth = obj.start_month,
                                Transport = obj.transport,
                                Basic = obj.basic,
                                OtherIncome = obj.other_income

                            };
                            _context.SspformH3s.Add(sspFm);
                        }
                    }
                    else
                    {
                        r.status = false;
                        r.message = $"Error Occured Processing Record To ERAS, What I got From ERAS{resp}";
                        return Ok(r);
                    }

                }
                else
                {
                    r.status = false;
                    r.message = $"Error Occured Processing Record To ERAS, What I got From ERAS{resp}";
                    return Ok(r);
                }

            }
            else
            {

                if (rootobjectVm.Success == true)
                {
                    var res = _context.Individuals.FirstOrDefault(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() && o.EmployeeRin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString());
                    if (res != null)
                    {
                        _context.Individuals.Where(
                        o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                        .ExecuteUpdate(dd => dd
                        .SetProperty(b => b.Firstname, obj.first_name)
                        .SetProperty(b => b.Surname, obj.last_name)
                        .SetProperty(b => b.Othername, obj.other_name)
                        .SetProperty(b => b.Phonenumber, rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString())
                        .SetProperty(b => b.EmployeeRin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                        .SetProperty(b => b.Jtbtin, obj.tin)
                        .SetProperty(b => b.Nin, obj.nin)
                        .SetProperty(b => b.Nationality, obj.nationality)
                        .SetProperty(b => b.Homeaddress, obj.home_address)
                        .SetProperty(b => b.Designation, obj.designation)
                        );
                    }
                    else
                    {
                        var sp = new Individual
                        {
                            EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                            Firstname = obj.first_name,
                            Surname = obj.last_name,
                            Othername = obj.other_name,
                            Phonenumber = rootobjectVm.Result.FirstOrDefault().TaxPayerMobileNumber.ToString(),
                            EmployeeRin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                            Jtbtin = obj.tin,
                            Nin = obj.nin,
                            Bvn = obj.bvn,
                            ZipCode = obj.zip_code,
                            LgaCode = obj.lga_code,
                            Nationality = obj.nationality,
                            Homeaddress = obj.home_address,
                            Designation = obj.designation
                        };
                        _context.Individuals.Add(sp);
                    }
                    if (obj.source.ToLower() == "monthly")
                    {
                        var resForm = _context.SspformH3s.FirstOrDefault(o => o.IndividualId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                    && o.Rin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString() && o.BusinessId == obj.business_id.ToString() && o.CompanyId == obj.corporate_id.ToString());
                        if (resForm != null)
                        {
                            _context.EmployeesMonthlyIncomes.Where(o => o.EmployeeId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                          .ExecuteUpdate(dd => dd
                          .SetProperty(b => b.EmployeeId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                          //.SetProperty(b => b.Rin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                          //.SetProperty(b => b.Startmonth, obj.start_month)
                          .SetProperty(b => b.Pension, obj.pension)
                          .SetProperty(b => b.Nhf, obj.nhf)
                          .SetProperty(b => b.Nhis, obj.nhis)
                          .SetProperty(b => b.LifeAssurance, obj.life_assurance)
                          .SetProperty(b => b.Rent, obj.rent)
                          .SetProperty(b => b.Transport, obj.transport)
                          .SetProperty(b => b.Basic, obj.basic)
                          .SetProperty(b => b.Others, obj.other_income)

                          );
                        }
                        else
                        {
                            var mon = new EmployeesMonthlyIncome
                            {
                                Pension = obj.pension,
                                Nhf = obj.nhf,
                                Nhis = obj.nhis,
                                LifeAssurance = obj.life_assurance,
                                Rent = obj.rent,
                                Transport = obj.transport,
                                Basic = obj.basic,
                                Others = obj.other_income,
                                EmployeeId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                BusinessId = obj.business_id.ToString(),
                                CompanyId = obj.corporate_id.ToString(),
                                CreatedDate = DateTime.UtcNow,
                                ModifiedDate = DateTime.UtcNow,
                                Status = true
                            };

                            _context.EmployeesMonthlyIncomes.Add(mon);
                        }

                    }
                    else if (obj.source.ToLower() == "formh3")
                    {
                        var resForm = _context.SspformH3s.FirstOrDefault(o => o.IndividualId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString()
                    && o.Rin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString() && o.BusinessId == obj.business_id.ToString() && o.CompanyId == obj.corporate_id.ToString());
                        if (resForm != null)
                        {
                            _context.SspformH3s.Where(o => o.IndividualId == rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString() && o.Rin == rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                          .ExecuteUpdate(dd => dd
                          .SetProperty(b => b.TaxPayerId, rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString())
                          .SetProperty(b => b.Rin, rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString())
                          .SetProperty(b => b.Startmonth, obj.start_month)
                          .SetProperty(b => b.Pension, obj.pension)
                          .SetProperty(b => b.Nhf, obj.nhf)
                          .SetProperty(b => b.Nhis, obj.nhis)
                          .SetProperty(b => b.Lifeassurance, obj.life_assurance)
                          .SetProperty(b => b.Rent, obj.rent)
                          .SetProperty(b => b.Transport, obj.transport)
                          .SetProperty(b => b.Basic, obj.basic)
                          .SetProperty(b => b.OtherIncome, obj.other_income)

                          );
                        }
                        else
                        {
                            var sspFm = new SspformH3
                            {
                                Datetcreated = DateTime.UtcNow,
                                Datemodified = DateTime.UtcNow,
                                BusinessId = obj.business_id.ToString(),
                                CompanyId = obj.corporate_id.ToString(),
                                TaxPayerId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                IndividualId = rootobjectVm.Result.FirstOrDefault().TaxPayerID.ToString(),
                                Rin = rootobjectVm.Result.FirstOrDefault().TaxPayerRIN.ToString(),
                                Pension = obj.pension,
                                Nhf = obj.nhf,
                                Nhis = obj.nhis,
                                Lifeassurance = obj.life_assurance,
                                Rent = obj.rent,
                                Startmonth = obj.start_month,
                                Transport = obj.transport,
                                Basic = obj.basic,
                                OtherIncome = obj.other_income

                            };
                            _context.SspformH3s.Add(sspFm);
                        }

                    }


                }
                else
                {
                    string jsonDataErr = js.Serialize(rootobjectVm);
                    r.status = false;
                    r.message = $"Error Occured Processing Record To ERAS, What I got From ERAS{resp}";
                    return Ok(r);
                }
            }
            try
            {
                _context.SaveChanges(); r.status = true;
                r.message = "Record saved Successfully";
                return (Ok(r));
            }
            catch (System.Exception ex)
            {
                AllFunction.SendErrorToText(ex);
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message

                }));
            }
        }
        else
        {
            r.status = false;
            r.message = "Error Occured Processing Token";
            return Ok(r);
        }
    }

    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("GetbyId/{id}")]
    public Task<IActionResult> GetbyId([FromRoute] int id)
    {
        var r = new ReturnObject();
        r.status = true;
        r.message = "Record Fetched Successfully";
        try
        {

            r.data = _repo.Employees.FirstOrDefault(o=>o.Id == id);
            return Task.FromResult<IActionResult>(Ok(r));

        }
        catch (System.Exception ex)
        {
            return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
            {
                status = false,
                message = ex.Message
            }));
        }

    }
}
