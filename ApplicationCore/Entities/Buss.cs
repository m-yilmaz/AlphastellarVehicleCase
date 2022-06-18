﻿using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Buss : Vehicle
    {
        public string BussName { get; set; }

        #region Relation With Color
        public int ColorId { get; set; }
        public Color Color { get; set; } 
        #endregion
    }
}
