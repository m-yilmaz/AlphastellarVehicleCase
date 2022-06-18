using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications.BoatSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Service
{
    public class BoatService : IBoatService
    {
        private readonly IRepository<Boat> _boatRepo;

        public BoatService(IRepository<Boat> boatRepo)
        {
            _boatRepo = boatRepo;
        }
        public async Task<Boat> GetBoatByIdAsync(int id)
        {
            var specId = new BoatSpecification(id);
            return await _boatRepo.GetByIdAsync(specId);
        }

        public async Task<List<Boat>> GetBoatsAsync()
        {
            var spec = new BoatSpecification();
            return await _boatRepo.GetAllAsync(spec);
        }

        public async Task<List<Boat>> GetBoatsByColorAsync(string colorName)
        {
            var specBoat = new BoatWithColorSpecification(colorName);
            return await _boatRepo.GetAllAsync(specBoat);
        }
    }
}
