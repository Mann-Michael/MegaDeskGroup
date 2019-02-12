﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_OHaraMannAndrade
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int CountDrawer { get; set; }
        public string SurfaceMaterial { get; set; }

        //Surface material enum
        public enum SurfaceMaterials { Oak, Laminate, Pine, Rosewood, Veneer }

    }

    /*struct Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int CountDrawer { get; set; }
        public string SurfaceMaterial { get; set; }

        //Surface material enum
        public enum SurfaceMaterials { Oak, Laminate, Pine, Rosewood, Veneer }
    }*/
}
