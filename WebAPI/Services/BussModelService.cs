using ApplicationCore.Interfaces;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class BussModelService : IBussModelService
    {
        private readonly IBussService _bussService;

        public BussModelService(IBussService bussService)
        {
            _bussService = bussService;
        }

        public async Task<List<BussModel>> GetBuss()
        {
            var bussList = await _bussService.GetBussAsync();
            if (bussList == null) return null;
            return bussList.Select(x => new BussModel
            {
                Id = x.Id,
                BussName = x.BussName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<List<BussModel>> GetBussByColor(string colorName)
        {
            var bussList = await _bussService.GetBussByColorAsync(colorName);
            if (bussList == null) return null;
            return bussList.Select(x => new BussModel
            {
                Id = x.Id,
                BussName = x.BussName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<BussModel> GetBussById(int id)
        {
            var buss = await _bussService.GetBussByIdAsync(id);
            if (buss == null) return null;
            BussModel model = new()
            {
                Id = buss.Id,
                BussName = buss.BussName,
                ColorName = buss.Color.ColorName,
            };
            return model;
        }

    }
}
