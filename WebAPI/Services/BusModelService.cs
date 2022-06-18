using ApplicationCore.Interfaces;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class BusModelService : IBusModelService
    {
        private readonly IBusService _busService;

        public BusModelService(IBusService busService)
        {
            _busService = busService;
        }

        public async Task<List<BusModel>> GetBus()
        {
            var busesList = await _busService.GetBusAsync();
            if (busesList == null) return null;
            return busesList.Select(x => new BusModel
            {
                Id = x.Id,
                BusName = x.BussName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<List<BusModel>> GetBusByColor(string colorName)
        {
            if(string.IsNullOrEmpty(colorName)) return null;
            var busesList = await _busService.GetBusByColorAsync(colorName);
            if (busesList == null) return null;
            return busesList.Select(x => new BusModel
            {
                Id = x.Id,
                BusName = x.BussName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<BusModel> GetBusById(int id)
        {
            var bus = await _busService.GetBusByIdAsync(id);
            if (bus == null) return null;
            BusModel model = new()
            {
                Id = bus.Id,
                BusName = bus.BussName,
                ColorName = bus.Color.ColorName,
            };
            return model;
        }

    }
}
