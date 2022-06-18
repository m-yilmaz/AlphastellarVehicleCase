using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBoatService
    {
        Task<List<Boat>> GetBoatsAsync();
        Task<Boat> GetBoatByIdAsync(int id);
        Task<List<Boat>> GetBoatsByColorAsync(string colorName);
    }
}
