using System;
using System.Linq;
using System.Threading.Tasks;
using Erp.Api.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ZeMERP.DTO;
using ZeMERP.DTO.Validation;

namespace ZeMERP.API.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Get All Employees.
        /// </summary> 
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = new EmployeesResponse() { Result = null };
            try
            {

               
                var result = await _employeeService.GetAllEmployees();

                if (result == null)
                {
                    response.Messages = ResponseMessages.NotFound();
                    return NotFound(response);
                }
                response.Messages = ResponseMessages.Success();
                response.Result = result.ToList();
                return Ok(response);
            }
            catch (Exception exception)
            {

                response.Messages = ResponseMessages.InternalServerError(exception.ToString());
                return StatusCode(500, response);
            }

        }

        /// <summary>
        /// Get a specific Employee.
        /// </summary>
        /// <param name="id"></param>  
        // GET api/values/5
        [HttpGet("{id}", Name = "GetEmployees")]
        public async Task<IActionResult> Get(int id)
        {
            var response = new EmployeeResponse() { Result = null };
            try
            {
                var result = await _employeeService.GetEmployeesById(id);
                if (result == null)
                {
                    response.Messages = ResponseMessages.NotFound();
                    return NotFound(response);
                }
                response.Messages = ResponseMessages.Success();
                response.Result = result;
                return Ok(response);
            }
            catch (Exception exception)
            {
                response.Messages = ResponseMessages.InternalServerError(exception.ToString());
                return StatusCode(500, response);
            }

        }

        /// <summary>
        /// Save a specific Employee.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Employee
        ///     {
        ///        "name": "Employee1",
        ///        "code": "001"
        ///     }
        ///
        /// </remarks>
        /// <param name="employeeRequestModel"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400 Bad Request">Request object is null</response>

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeRequestDTO model)
        {
            var response = new EmployeeResponse() { Result = null };
            try
            {
                if (model == null)
                {
                    response.Messages = ResponseMessages.BadRequest();
                    return NotFound(response);
                }

                var res = new EmployeeValidator();
                if (!ModelState.IsValid)
                {

                    response.Messages = ResponseMessages.ModelValidate(ModelState);
                    return UnprocessableEntity(response);
                }

                var result = await _employeeService.AddEmployee(model);

                response.Messages = ResponseMessages.Created();
                response.Result = result;
                return CreatedAtRoute("GetEmployees",
                    new { id = result.EmployeeId },
                    response);
            }
            catch (Exception exception)
            {
                response.Messages = ResponseMessages.InternalServerError(exception.ToString());
                return StatusCode(500, response);
            }



        }
    }
}