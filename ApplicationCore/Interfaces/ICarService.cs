using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICarService
    {
        Task<List<Car>> GetCarsAsync();
        Task<Car> GetCarByIdAsync(int carId);
        Task<List<Car>> GetCarsByColorAsync(string colorName);
        Task DeleteCarAsync(Car car);
        Task<Car> Headlights(int carId);
    }
}