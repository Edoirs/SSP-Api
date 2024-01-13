using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi;
using SelfPortalAPi.testingModel;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalGovernmentAreaController : ControllerBase
    {
        // private readonly PayeeContext _context;
        private readonly IRepository<LocalGovernment> _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public LocalGovernmentAreaController(IRepository<LocalGovernment> repo)
        {
            _repo = repo;
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
                r.data = _repo.GetAll();
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
        [Route("GetbyId/{id}")]

        public Task<IActionResult> GetbyId([FromRoute] int id)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {

                r.data = _repo.Get(id);
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
}
