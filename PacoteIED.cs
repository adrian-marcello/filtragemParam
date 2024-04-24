using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtragemParam
{
    public class PacoteIED
    {
        public string URI { get; set; }
        public int Ia { get; set; }
        public int Ib { get; set; }
        public int Ic { get; set; }
        public int numPacote { get; set; }
        public int idDispositivo { get; set; }

        public override string ToString()
        {
            return idDispositivo+"-"+numPacote+": Ia="+Ia+";Ib="+Ib+";Ic="+Ic+".";
        }
    }
}
