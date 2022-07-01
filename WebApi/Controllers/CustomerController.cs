using Business.P.Abstract;
using Entities.P.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("get-by-brand-id")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Customer customer)
        {
            try
            {
                _customerService.Update(customer);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            try
            {
                _customerService.Delete(customer);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
