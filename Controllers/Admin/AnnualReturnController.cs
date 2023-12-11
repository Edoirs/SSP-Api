using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.NewTables;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AnnualReturnController : ControllerBase
    {
        private readonly IRepository<AnnualReturn> _repo;
          private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private string errMsg = "Unable to process request, kindly try again";
        public AnnualReturnController(IMapper mapper,IHttpContextAccessor httpContextAccessor, IRepository<AnnualReturn> repo)
        {
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
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
                    message = ex.Message
                }));
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("getallbybusinessId/{busId}")]
        public Task<IActionResult> getallbybusinessId([FromRoute] string busId)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                r.data = _repo.GetAll().Where(o=>o.business_id==busId).ToList();
                return Task.FromResult<IActionResult>(Ok(r));
            }
            catch (Exception ex)
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
        [Route("AddReturn")]
        public Task<IActionResult> Add([FromBody] AnnualReturnFm obj)
        {
            AllFunction all =new AllFunction();
           var ClientCode = _httpContextAccessor.HttpContext.User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

            var emp = _mapper.Map<AnnualReturn>(obj);
          //  emp.CreatedBy =ClientCode; 
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
                    message = ex.Message
                }));
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type =typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetbyId/{id}")]
        public Task<IActionResult> GetbyId([FromRoute]int id)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
      
                r.data = _repo.Get(id);
                return Task.FromResult<IActionResult>(Ok(r));

            }catch (Exception ex)
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

