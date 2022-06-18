using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications.BussSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Service
{
    public class BussService : IBussService
    {
        private readonly IRepository<Buss> _bussRepo;

        public BussService(IRepository<Buss> bussRepo)
        {
            _bussRepo = bussRepo;
        }
        public async Task<List<Buss>> GetBussAsync()
        {
            var spec = new BussSpecification();
            return await _bussRepo.GetAllAsync(spec);
        }

        public async Task<List<Buss>> GetBussByColorAsync(string colorName)
        {
            var specBuss = new BussWithColorSpecification(colorName);
            return await _bussRepo.GetAllAsync(specBuss);
        }

        public async Task<Buss> GetBussByIdAsync(int carId)
        {
            var specId = new BussSpecification(carId);
            return await _bussRepo.GetByIdAsync(specId);
        }
    }
}
