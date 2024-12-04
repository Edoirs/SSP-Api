

namespace SelfPortalAPi.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ProjectionController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly SelfServiceConnect _repo;
    private string errMsg = "Unable to process request, kindly try again";
    public ProjectionController(IMapper mapper, SelfServiceConnect repo)
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
            r.data = _repo.Projections.ToList();
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

            r.data = _repo.Projections.Where(o => o.ApprovalStatus == (int)ApprovalStatusEnum.Pending);
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

            r.data = _repo.Projections.Where(o => o.ApprovalStatus == (int)ApprovalStatusEnum.Approved);
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
        DateTime dateTime = DateTime.UtcNow;
        string forwardedDate = Convert.ToString(dateTime);
        var emp = _mapper.Map<Projection>(obj);
        emp.UniqueId = Guid.NewGuid().ToString();
        emp.AnnualProjectionId = "0";
        emp.DateForwarded = forwardedDate;
        emp.CreatedAt = forwardedDate;
        emp.ApprovalStatus = (int)ApprovalStatusEnum.Pending;
        emp.AppId = 0;
        emp.FileProjectionStatus = "Default_value";
        try
        {
            _repo.Projections.Add(emp);
            _repo.SaveChanges();

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

            r.data = _repo.Projections.FirstOrDefault(o=>o.Id==id);
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
