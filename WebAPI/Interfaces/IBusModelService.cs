using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IBusModelService
    {
        Task<List<BusModel>> GetBus();

        Task<BusModel> GetBusById(int id);

        Task<List<BusModel>> GetBusByColor(string colorName);
    }
}
