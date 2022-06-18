using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications.CarSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Service
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _carRepo;

        public CarService(IRepository<Car> carRepo)
        {
            _carRepo = carRepo;
        }

        public async Task DeleteCarAsync(Car car)
        {
            await _carRepo.DeleteAsnyc(car);
        }

        public async Task<Car> GetCarByIdAsync(int carId)
        {
            var specId = new CarsSpecification(carId);
            return await _carRepo.GetByIdAsync(specId);
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            var spect = new CarsSpecification();
            return await _carRepo.GetAllAsync(spect);
        }

        public async Task<List<Car>> GetCarsByColorAsync(string colorName)
        {
            var specCar = new CarsWithColorSpecification(colorName);
            return await _carRepo.GetAllAsync(specCar);
        }
        public async Task<Car> Headlights(int carId)
        {
            var specId = new CarsSpecification(carId);
            var selectedCar = await _carRepo.GetByIdAsync(specId);
            if (selectedCar != null)
            {
                if (selectedCar.Headlight == Enums.HeadlightEnum.TurnOff)
                    selectedCar.Headlight = Enums.HeadlightEnum.TurnOn;
                else
                    selectedCar.Headlight = Enums.HeadlightEnum.TurnOff;
                await _carRepo.UpdateAsync(selectedCar);
                return selectedCar;
            }
            return null;
        }




    }
}
