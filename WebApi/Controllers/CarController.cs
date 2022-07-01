using Business.P.Abstract;
using Entities.P.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
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
        public IActionResult GetByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            return Ok(result);
        }

        [HttpGet("get-by-color-id")]
        public IActionResult GetByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            try
            {
                _carService.Update(car);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            try
            {
                _carService.Delete(car);
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
