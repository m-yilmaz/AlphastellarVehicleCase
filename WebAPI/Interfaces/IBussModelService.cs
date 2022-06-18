using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IBussModelService
    {
        Task<List<BussModel>> GetBuss();

        Task<BussModel> GetBussById(int id);

        Task<List<BussModel>> GetBussByColor(string colorName);
    }
}
