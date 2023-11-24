using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.NewTables;
using SelfPortalAPi;
using Swashbuckle.AspNetCore.Annotations;
using SelfPortalAPi.UnitOfWork;
using System.IO.Compression;
using SelfPortalAPi.FormModel;
using AutoMapper;
using SelfPortalAPi.Vm;

namespace SelfPortalAPi.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly PayeeContext _context; 
        private readonly IMapper _mapper;
        private readonly UnitOfWork.IRepository<employee> _repo;
        private readonly UnitOfWork.IRepository<Cooperate> _repoCop;
        private string errMsg = "Unable to process request, kindly try again";
        public EmployeeController(UnitOfWork.IRepository<employee> repo, UnitOfWork.IRepository<Cooperate> repoCop,IMapper mapper)
        {
            _repo = repo;
            _repoCop = repoCop;
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


        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("GetEmployeeByDetail")]
        public  Task<IActionResult> GetEmployeeByDetail([FromBody] GetEmployee obj)
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                r.data =  _context.employees.FromSqlRaw($"select * from employee where corporate_id ={obj.corporate_id} and business_id ={obj.business_id}");

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
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("AddEmployee")]
        public  Task<IActionResult> AddEmployee([FromBody] AddEmployee obj)
        {
            var emp = _mapper.Map<employee>(obj);
            try
            {
                _repo.Insert(emp);
                var empData = _mapper.Map<EmployeeVm>(emp);
                var com = _repoCop.Get(Convert.ToInt32(obj.corporate_id));
                empData.Cooperates = com;
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
