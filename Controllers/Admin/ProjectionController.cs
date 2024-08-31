using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.FormModel;
using SelfPortalAPi.NewModel;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;
using static SelfPortalAPi.AllFunction;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Projection> _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public ProjectionController(IMapper mapper, IRepository<Projection> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetProjectionApprovalStatus")]
        public Task<IActionResult> GetProjectionApprovalStatus()
        {
            var res = new Dictionary<int, string>();
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                foreach (var value in Enum.GetValues(typeof(ApprovalStatusEnum)))
                {
                    res.Add((int)value, ((ApprovalStatusEnum)value).ToString());
                }
                r.data = res.ToList();
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
        [Route("getallUnApprovedRecord")]
        public Task<IActionResult> GetAllUnApprovedRecord()
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {

                r.data = _repo.GetAll().Where(o => o.approval_status == (int)ApprovalStatusEnum.Pending);
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
        [Route("getallApproved")]
        public Task<IActionResult> GetAllApproved()
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {

                r.data = _repo.GetAll().Where(o => o.approval_status == (int)ApprovalStatusEnum.Approved);
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
        [Route("Add")]
        public Task<IActionResult> Add([FromBody] ProjectionFm obj)
        {
            DateTime dateTime = DateTime.Now;
            string forwardedDate = Convert.ToString(dateTime);
            var emp = _mapper.Map<Projection>(obj);
            emp.UniqueId = Guid.NewGuid().ToString();
            emp.annual_projection_id = "0";
            emp.date_forwarded = forwardedDate;
            emp.created_at = forwardedDate;
            emp.approval_status = (int)ApprovalStatusEnum.Pending;
            emp.app_id = 0;
            emp.file_projection_status = "Default_value";
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
