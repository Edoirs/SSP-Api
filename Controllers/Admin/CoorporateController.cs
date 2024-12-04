
namespace SelfPortalAPi.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CoorporateController : ControllerBase
{
    private readonly SelfServiceConnect _repo;
    private string errMsg = "Unable to process request, kindly try again";
    public CoorporateController(SelfServiceConnect repo)
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
            r.data = _repo.Cooperates.ToList();
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

            r.data = _repo.Cooperates.FirstOrDefault(o=>o.Id==id);
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
