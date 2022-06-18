using ApplicationCore.Interfaces;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class BoatModelService : IBoatModelService
    {
        private readonly IBoatService _boatService;

        public BoatModelService(IBoatService boatService)
        {
            _boatService = boatService;
        }
        public async Task<List<BoatModel>> GetBoat()
        {
            var boatList = await _boatService.GetBoatsAsync();
            if (boatList == null) return null;
            return boatList.Select(x => new BoatModel
            {
                Id = x.Id,
                BoatName = x.BoatName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<List<BoatModel>> GetBoatByColor(string colorName)
        {
            if (string.IsNullOrEmpty(colorName)) return null;
            var boatList = await _boatService.GetBoatsByColorAsync(colorName);
            if (boatList == null) return null;
            return boatList.Select(x => new BoatModel
            {
                Id = x.Id,
                BoatName = x.BoatName,
                ColorName = x.Color.ColorName,
            }).ToList();
        }

        public async Task<BoatModel> GetBoatById(int id)
        {
            var boat = await _boatService.GetBoatByIdAsync(id);
            if (boat == null) return null;
            BoatModel model = new()
            {
                Id = boat.Id,
                BoatName = boat.BoatName,
                ColorName = boat.Color.ColorName,
            };
            return model;
        }

    }
}
