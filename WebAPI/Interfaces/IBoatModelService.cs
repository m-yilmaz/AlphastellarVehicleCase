using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IBoatModelService
    {
        Task<List<BoatModel>> GetBoat();

        Task<BoatModel> GetBoatById(int id);

        Task<List<BoatModel>> GetBoatByColor(string colorName);
    }
}
