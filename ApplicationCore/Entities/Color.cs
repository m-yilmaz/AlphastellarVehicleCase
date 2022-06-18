using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Color : BaseEntity
    {
        public string ColorName { get; set; }

        public List<Car> Cars { get; set; }
        public List<Bus> Buses { get; set; }
        public List<Boat> Boats { get; set; }
    }
}
