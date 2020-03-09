using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR.MyAirport.EF
{
    public class Bagage
    {
        public int BagageId { get; set; }
        public int? VolId { get; set; }
        public Vol Vol { get; set; }
        public string CodeIATA { get; set; }
        public DateTime DateCreation { get; set; }
        public string Classe { get; set; }
        public bool Priorite { get; set; }
        public string Sta { get; set; }
        public int Ssur { get; set; }
        public string Destination { get; set; }
        public int Escale { get; set; }
    }
}
