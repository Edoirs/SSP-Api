using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.NewTables;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Projection> _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public ProjectionController(IMapper mapper,IRepository<Projection> repo)
        {
            _mapper = mapper;
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
            catch (Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = errMsg
                }));
            }
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Add")]
        public Task<IActionResult> Add([FromBody] ProjectionFm obj)
        {
            var emp = _mapper.Map<Projection>(obj);
            emp.UniqueId = Guid.NewGuid().ToString();
            try
            {
                _repo.Insert(emp);
               
                var r = new ReturnObject();
                r.status = true;
                r.data = null;
                r.message = "Record saved Successfully";
                return Task.FromResult<IActionResult>(Ok(r));
            }
            catch (System.Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = errMsg
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
            catch (Exception ex)
            {
                return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = errMsg
                }));
            }

        }
    }
}
