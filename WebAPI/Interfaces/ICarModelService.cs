using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ICarModelService
    {
        Task<List<CarModel>> GetCars();

        Task<CarModel> GetCarById(int id);

        Task<List<CarModel>> GetCarsByColor(string colorName);

        Task<CarModel> Headligts(int id);

        Task DeleteCar(CarModel carModel);

    }
}
