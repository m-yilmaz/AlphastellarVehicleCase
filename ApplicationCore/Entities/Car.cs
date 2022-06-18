using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Car : Vehicle, IHeadlight, IWheels
    {
        public string CarName { get; set; } 
        public int Wheels { get; set; }
        public HeadlightEnum Headlight { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
