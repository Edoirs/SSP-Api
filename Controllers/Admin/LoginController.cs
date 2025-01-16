
namespace SelfPortalAPi.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly SelfServiceConnect _con;
    private readonly IIndividualRepository _repo;
    private readonly IValidator<TokenRequest> _validator;
    private readonly IOptions<ConnectionStrings> _serviceSettings;
    private string errMsg = "Unable to process request, kindly try again";
    public LoginController(IIndividualRepository repo, SelfServiceConnect con, IOptions<ConnectionStrings> serviceSettings, IValidator<TokenRequest> validator)
    {
        _repo = repo;
        _con = con;
        _serviceSettings = serviceSettings;
        _validator = validator;
    }

    [HttpGet]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("Tester")]
    public async Task<IActionResult> Tester()
    {
        var r = new ReturnObject();

        try
        {
            var ret = _con.PayeUserTypes.ToList();
            return Ok(ret);
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
    [Route("Signin")]
    public async Task<IActionResult> Signin([FromBody] TokenRequest ivm)
    {
        var r = new ReturnObject();
        if (!ivm.UserType.Equals(ivm.UserType, StringComparison.OrdinalIgnoreCase))
        {
            r.status = false;
            r.message = "Invalid User Type";
            return Ok(r);
        }

        try
        {
            var validationResult = await _validator.ValidateAsync(ivm);
            if (!validationResult.IsValid)
            {
                return (IActionResult)Results.ValidationProblem(validationResult.ToDictionary());
            }
            var ret = _repo.Login(ivm);
            return Ok(ret);
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
    [Route("CreateAccountStepThree")]
    public ActionResult CreateAccountStepThree(CompanyStep2 model)
    {
        string newP = BCrypt.Net.BCrypt.HashPassword(model.Password);
        var r = new ReturnObject();
        var checker = getComapny(model.CompanyRin, 2);
        if (checker.Values != null)
            _con.UserManagements.Where(b => b.CompanyRin == model.CompanyRin)
            .ExecuteUpdate(s => s.SetProperty(b => b.Password, newP));

        r.status = true;
        r.message = "Company Found Successfully";

        return Ok(r);
    }
    [HttpPost]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("CreateAccountStepTwo")]
    public ActionResult CreateAccountStepTwo(CompanyStep1 model)
    {
        AllFunction allFunction = new AllFunction();
        var r = new ReturnObject();
        Random ran = new Random();
        var q = ran.Next(0, 1000000);

        var checker = getComapny(model.CompanyRin, 2);
        if (checker.Values.FirstOrDefault().CompanyName != null)
            _con.UserManagements.Where(b => b.CompanyRin == model.CompanyRin)
            .ExecuteUpdate(s =>
            s.SetProperty(b => b.VerificationOtp, Convert.ToInt32(q))
            .SetProperty(b => b.PhoneNumber, model.PhoneNumber)
            );
        var blnSMSSent = allFunction.SendSMS(
           model.PhoneNumber,
           $"Dear User, Kindly Use {q} As OTP", _serviceSettings.Value.username, _serviceSettings.Value.password
       );
        r.data = q;
        r.status = true;
        r.message = "Company Found Successfully";

        return Ok(r);
    }
    [HttpPut]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    [Route("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] TokenRequest ivm)
    {
        var r = new ReturnObject();
        if (!ivm.UserType.Equals(ivm.UserType, StringComparison.OrdinalIgnoreCase))
        {
            r.status = false;
            r.message = "Invalid User Type";
            return Ok(r);
        }

        try
        {
            var validationResult = await _validator.ValidateAsync(ivm);
            if (!validationResult.IsValid)
            {
                return (IActionResult)Results.ValidationProblem(validationResult.ToDictionary());
            }
            var ret = _repo.Login(ivm);
            return Ok(ret);
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
    [Route("CreateAccountStepOne")]
    public ActionResult CreateAccountStepOne(CompanyStep model)
    {

        var r = new ReturnObject();
        r.status = false;
        r.message = "Incorrect RIN";

        var ret = _con.UserManagements.FirstOrDefault(o => o.CompanyRin.ToLower().Trim() == model.CompanyRin.ToLower().Trim());
        if (ret != null)
        {
            var getAddres = _con.CompanyListApis.FirstOrDefault(o => o.TaxPayerRin.ToLower().Trim() == model.CompanyRin.ToLower().Trim());
            r.status = false;
            if (!string.IsNullOrEmpty(ret.PhoneNumber) && !string.IsNullOrEmpty(ret.Password))
            {
                r.message = $"User: {ret.CompanyName} and Mobile Number: {ret.PhoneNumber} is already registered";
                r.data = new { CompanyName = ret.CompanyName, phoneNumber = ret.PhoneNumber, CompanyAddress = getAddres?.ContactAddress, companyRin = ret.CompanyRin, screenDet = "LOGIN" };
            }
            else
            {
                r.message = $"User: {ret.CompanyName} and Mobile Number: {ret.PhoneNumber} is already registered";
                r.data = new { CompanyName = ret.CompanyName, phoneNumber = ret.PhoneNumber, CompanyAddress = getAddres?.ContactAddress, companyRin = ret.CompanyRin, screenDet = "OTP" };
            }
        }
        else
        {
            var checker = getComapny(model.CompanyRin, 1);
            if (checker.Count > 0)
                if (checker.Keys != null)
                {
                    r.data = checker.Keys;
                    UserManagement user = new();
                    user.CompanyRin = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().TaxPayerRin : "";
                    user.CompanyName = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().TaxPayerName : "";
                    user.Email = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().EmailAddress : "";
                    user.UniqueId = Guid.NewGuid().ToString();
                    user.PhoneNumber = "";
                    user.CompanyId = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().TaxPayerId : 0;
                    user.TaxpayerTypeId = model.CompanyRin.StartsWith("CMP") ? 2 : 4;
                    _con.Add(user);
                    _con.SaveChanges();
                    r.status = true;
                    r.message = "Company Found Successfully";
                }
        }
        return Ok(r);
    }


    [NonAction]
    private Dictionary<CompanyListApi, UserManagement> getComapny(string rin, int det)
    {
        var com = new CompanyListApi();
        var um = new UserManagement();
        Dictionary<CompanyListApi, UserManagement> ret = new();
        switch (det)
        {
            case 1:
                com = _con.CompanyListApis.FirstOrDefault(o => o.TaxPayerRin.ToLower().Trim() == rin.ToLower().Trim());
                if (com != null)
                    ret.Add(com, um);
                break;
            case 2:
                um = _con.UserManagements.FirstOrDefault(o => o.CompanyRin.ToLower().Trim() == rin.ToLower().Trim());
                if (um != null)
                    ret.Add(com, um);
                break;
            default:
                ret.Add(com, um);
                break;

        }
        return ret;
    }
}
