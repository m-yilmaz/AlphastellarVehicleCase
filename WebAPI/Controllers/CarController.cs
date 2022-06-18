using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarModelService _carModelService;

        public CarController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpGet]
        public async Task<List<CarModel>> Get()
        {
            return await _carModelService.GetCars();
        }

        [HttpGet("{colorName}")]
        public async Task<ActionResult<List<CarModel>>> Get(string colorName)
        {
            List<CarModel> carList = await _carModelService.GetCarsByColor(colorName);
            if (carList.Count == 0) return NotFound();
            return carList;
        }

        [HttpPost("{changeHeadligtsCarById}")]
        public async Task<ActionResult<CarModel>> Post(int changeHeadligtsCarById)
        {
            CarModel car = await _carModelService.Headligts(changeHeadligtsCarById);
            if (car == null) NotFound();
            return car;
        }

        [HttpDelete]
        public async Task<ActionResult<CarModel>> Delete(CarModel carModel)
        {
            await _carModelService.DeleteCar(carModel);
            return Ok();
        }
    }
}
