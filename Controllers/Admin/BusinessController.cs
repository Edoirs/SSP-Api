using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.NewTables;
using SelfPortalAPi;
using Swashbuckle.AspNetCore.Annotations;
using SelfPortalAPi.UnitOfWork;
using SelfPortalAPi.FormModel;
using AutoMapper;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Business> _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public BusinessController(IMapper mapper, IRepository<Business> repo)
        {
            _repo = repo;
            _mapper = mapper;
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

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("AddBusiness")]
        public Task<IActionResult> AddEmployee([FromBody] BusinessViewModel obj)
        {
            var emp = _mapper.Map<Business>(obj);
            try
            {
                _repo.Insert(emp);
                var empData = _mapper.Map<BusinessFormModel>(emp);
                var com = _repo.Get(Convert.ToInt32(obj.BusinessOperationID));
                empData.BusinessId = Convert.ToInt32(obj.BusinessOperationID);
                var r = new ReturnObject();
                r.status = true;
                r.data = empData;
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
    }
}
