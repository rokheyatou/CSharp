﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR.MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public string Cie { get; set; }
        public string Des { get; set; }
        public DateTime Dhc { get; set; }
        public string Imm { get; set; }
        public string Lig { get; set; }
        public string Pkg { get; set; }
        public int Pax { get; set; }
    }
}
