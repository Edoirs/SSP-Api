using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfPortalAPi.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;

namespace SelfPortalAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private readonly IUtilityRepository _repo;
        private string errMsg = "Unable to process request, kindly try again";
        public UtilityController(IUtilityRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-category")]
        public async Task<IActionResult> getbusinesscategory()
        {
            try
            {
                var r = await _repo.GetBusinessCategory();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-Sector")]
        public async Task<IActionResult> GetBusinessSectorr()
        {
            try
            {
                var r = await _repo.GetBusinessSector();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-operation")]
        public async Task<IActionResult> getbusinessoperation()
        {
            try
            {
                var r = await _repo.GetBusinessOperation();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        //[HttpGet]
        //[SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        //[Route("get-business-sector")]
        //public async Task<IActionResult> getbusinesssector()
        //{
        //    try
        //    {
        //        var r = _repo.GetBusinessSector();
        //        return Ok(r);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
        //        {
        //            status = false,
        //            message = ex.Message
        //        }));
        //    }
        //}

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-structure")]
        public async Task<IActionResult> getbusinessstructuree()
        {
            try
            {
                var r = await _repo.GetBusinessStructure();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-subsector")]
        public async Task<IActionResult> getbusinesssubsector()
        {
            try
            {
              var r =await _repo.GetBusinessSubSector();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-business-type")]
        public async Task<IActionResult> getbusinesstype()
        {
            try
            {
                var r =await _repo.GetBusinessType();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-economic-activity")]
        public async Task<IActionResult> geteconomicactivity()
        {
            try
            {
               var r =await _repo.GetEconomicActivity();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-gender")]
        public async Task<IActionResult> getgender()
        {
            try
            {
              var r =await _repo.GetGender();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-lga")]
        public  async Task<IActionResult> getlga()
        {
            try
            {var r =await _repo.GetLGA();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-nationality")]
        public async Task<IActionResult> getnationality()
        {
            var r = new ReturnObject();
            r.status = true;
            r.message = "Record Fetched Successfully";
            try
            {
                r.data = await _repo.GetNationality();
               return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-tax-office")]
        public async Task<IActionResult> gettaxoffice()
        {
            try
            {
               var r =await _repo.GetTaxOffice(); return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-title")]
        public async Task<IActionResult> gettitle()
        {
            try
            {
               var r =await _repo.GetTitle();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ReturnObject))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(ReturnObject))]
        [Route("get-zone")]
        public async Task<IActionResult> getzone()
        {
            try
            {
                var r =await _repo.GetZone();
                return Ok(r);
            }
            catch (System.Exception ex)
            {
                return (StatusCode(StatusCodes.Status500InternalServerError, new ReturnObject
                {
                    status = false,
                    message = ex.Message
                }));
            }
        }
    }
}
