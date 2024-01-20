using AutoMapper;
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
    public class ScheduleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Schedule> _repo;
        private readonly IRepository<Schedule_Record> _repoC;
        private string errMsg = "Unable to process request, kindly try again";
        public ScheduleController(IRepository<Schedule> repo, IRepository<Schedule_Record> repoC, IMapper mapper)
        {
            _repo = repo;
            _repoC = repoC;
            _mapper = mapper;
        }


        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("Add")]
        public Task<IActionResult> Add([FromBody] ScheduleFm obj)
        {
            var emp = _mapper.Map<Schedule>(obj);
            emp.UniqueId = Guid.NewGuid().ToString();
            try
            {
                var lstSR = new List<Schedule_Record>();
                _repo.Insert(emp);
                foreach (var sr in obj.schedule_records)
                {
                    var empSr = _mapper.Map<Schedule_Record>(sr);
                    empSr.UniqueId = Guid.NewGuid().ToString();
                    empSr.schedule_id = emp.Id;
                    lstSR.Add(empSr);
                }
                _repoC.Insert(lstSR);
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
            var sr = new List<Schedule_Record>();
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                var rec = _repo.Get(id);
                if (rec != null)
                    sr = _repoC.GetAll().Where(o => o.schedule_id == rec.Id).ToList();
                var res = new
                {
                    Schedule = rec,
                    Schedule_Record = sr
                };
                r.data = res;
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