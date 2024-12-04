

namespace SelfPortalAPi.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ScheduleController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly SelfServiceConnect _repo;
    private string errMsg = "Unable to process request, kindly try again";
    public ScheduleController(SelfServiceConnect repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }


    //[HttpPost]
    //[SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
    //[SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
    //[Route("Add")]
    //public Task<IActionResult> Add([FromBody] ScheduleH3 obj)
    //{
    //    var emp = _mapper.Map<Schedule>(obj);
    //    emp.UniqueId = Guid.NewGuid().ToString();
    //    try
    //    {
    //        var lstSR = new List<ScheduleRecord>();
    //        _repo.Schedules.Add(emp);
    //        foreach (var sr in obj.sc)
    //        {
    //            var empSr = _mapper.Map<Schedule_Record>(sr);
    //            empSr.UniqueId = Guid.NewGuid().ToString();
    //            empSr.schedule_id = emp.Id;
    //            lstSR.Add(empSr);
    //        }
    //        _repoC.Insert(lstSR);
    //        var r = new ReturnObject();
    //        r.status = true;
    //        r.data = null;
    //        r.message = "Record saved Successfully";
    //        return Task.FromResult<IActionResult>(Ok(r));
    //    }
    //    catch (System.Exception ex)
    //    {
    //        return Task.FromResult<IActionResult>(StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
    //        {
    //            status = false,
    //            message = ex.Message
    //        }));
    //    }
    //}

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
            r.data = _repo.Schedules.ToList();
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
        var sr = new List<ScheduleRecord>();
        var r = new ReturnObject();
        r.status = true;
        r.message = "Record Fetched Successfully";
        try
        {
            var rec = _repo.Schedules.FirstOrDefault(o=>o.Id==id);
            if (rec != null)
                sr = _repo.ScheduleRecords.ToList().Where(o => o.ScheduleId == rec.Id).ToList();
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