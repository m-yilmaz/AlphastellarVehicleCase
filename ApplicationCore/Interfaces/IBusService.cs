using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBusService
    {
        Task<List<Bus>> GetBusAsync();
        Task<Bus> GetBusByIdAsync(int carId);
        Task<List<Bus>> GetBusByColorAsync(string colorName);
    }
}
