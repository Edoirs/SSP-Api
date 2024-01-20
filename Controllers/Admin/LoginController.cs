using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.Model;
using SelfPortalAPi.NewModel;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly EirsContext _context;
        private readonly PinscherSpikeContext _con;
        private readonly IIndividualRepository _repo;
        private readonly IValidator<TokenRequest> _validator;
        private string errMsg = "Unable to process request, kindly try again";
        public LoginController(IIndividualRepository repo, PinscherSpikeContext con, EirsContext context, IValidator<TokenRequest> validator)
        {
            _repo = repo;
            _con = con;
            _context = context;
            _validator = validator;
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

            // TO DO send the OTP to the number 
            r.data = q;
            r.status = true;
            r.message = "Company Found Successfully";

            return Ok(r);
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
            var checker = getComapny(model.CompanyRin, 1);
            if (checker.Keys != null)
            {
                r.data = checker.Keys;
                UserManagement user = new();
                user.CompanyRin = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().CompanyRin : "";
                user.CompanyName = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().CompanyName : "";
                user.Email = checker.Keys.FirstOrDefault() != null ? checker.Keys.FirstOrDefault().EmailAddress1 : "";
                user.UniqueId = Guid.NewGuid().ToString();
                user.PhoneNumber = "";
                _con.Add(user);
                _con.SaveChanges();
                r.status = true;
                r.message = "Company Found Successfully";
            }
            return Ok(r);
        }


        [NonAction]
        private Dictionary<Company, UserManagement> getComapny(string rin, int det)
        {
            var com = new Company();
            var um = new UserManagement();
            Dictionary<Company, UserManagement> ret = new();
            switch (det)
            {
                case 1:
                    com = _context.Companies.FirstOrDefault(o => o.CompanyRin.ToLower().Trim() == rin.ToLower().Trim()); ;
                    ret.Add(com, um);
                    break;
                case 2:
                    um = _con.UserManagements.FirstOrDefault(o => o.CompanyRin.ToLower().Trim() == rin.ToLower().Trim()); ;
                    ret.Add(com, um);
                    break;
                default:
                    ret.Add(com, um);
                    break;

            }
            return ret;
        }
    }
}
