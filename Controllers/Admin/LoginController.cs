using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IIndividualRepository _repo;
        private readonly IValidator<TokenRequest> _validator;
        private string errMsg = "Unable to process request, kindly try again";
        public LoginController(IIndividualRepository repo, IValidator<TokenRequest> validator)
        {
            _repo = repo;
            _validator = validator;
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Signin")]
        public async Task<IActionResult> Signin([FromBody] TokenRequest ivm)
        {
            var r = new ReturnObject();
            if(!ivm.UserType.Equals(ivm.UserType, StringComparison.OrdinalIgnoreCase)) 
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
                return await  Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = errMsg
                }));
            }
        }
    }
}
