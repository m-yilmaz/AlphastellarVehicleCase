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
    public class BusService : IBusService
    {
        private readonly IRepository<Bus> _busRepo;

        public BusService(IRepository<Bus> busRepo)
        {
            _busRepo = busRepo;
        }
        public async Task<List<Bus>> GetBusAsync()
        {
            var spec = new BusSpecification();
            return await _busRepo.GetAllAsync(spec);
        }

        public async Task<List<Bus>> GetBusByColorAsync(string colorName)
        {
            var specBuss = new BusWithColorSpecification(colorName);
            return await _busRepo.GetAllAsync(specBuss);
        }

        public async Task<Bus> GetBusByIdAsync(int bussId)
        {
            var specId = new BusSpecification(bussId);
            return await _busRepo.GetByIdAsync(specId);
        }
    }
}
