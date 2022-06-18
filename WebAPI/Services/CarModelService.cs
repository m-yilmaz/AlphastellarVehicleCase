using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarService _carService;

        public CarModelService(ICarService carService)
        {
            _carService = carService;
        }

        public async Task DeleteCar(CarModel carModel)
        {
            var car = await _carService.GetCarByIdAsync(carModel.Id);
            await _carService.DeleteCarAsync(car);
        }

        public async Task<CarModel> GetCarById(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            if (car == null)
            {
                return null;
            }
            CarModel model = new()
            {
                Id = id,
                CarName = car.CarName,
                ColorName = car.Color.ColorName,
                Headlight = car.Headlight.ToString() == "0" ? "Open" : "Close",
                Wheels = car.Wheels
            };
            return model;
        }

        public async Task<List<CarModel>> GetCars()
        {
            var carList = await _carService.GetCarsAsync();
            if (carList == null)
            {
                return null;
            }
            return carList.Select(x => new CarModel
            {
                Id = x.Id,
                CarName = x.CarName,
                ColorName = x.Color.ColorName,
                Headlight = x.Headlight == HeadlightEnum.TurnOn ? "Open" : "Close",
                Wheels = x.Wheels
            }).ToList();
        }

        public async Task<List<CarModel>> GetCarsByColor(string colorName)
        {
            var carList = await _carService.GetCarsByColorAsync(colorName);
            if (carList == null)
            {
                return null;
            }
            return carList.Select(x => new CarModel
            {
                Id = x.Id,
                CarName = x.CarName,
                ColorName = x.Color.ColorName,
                Headlight = x.Headlight == HeadlightEnum.TurnOn ? "Open" : "Close",
                Wheels = x.Wheels
            }).ToList();
        }

        public async Task<CarModel> Headligts(int id)
        {
            var car = await _carService.Headlights(id);
            if (car == null) return null;
            CarModel model = new()
            {
                Id = id,
                CarName = car.CarName,
                ColorName = car.Color.ColorName,
                Headlight = car.Headlight == HeadlightEnum.TurnOn ? "Open" : "Close",
                Wheels = car.Wheels
            };
            return model;
        }
    }
}
