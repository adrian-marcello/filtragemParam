using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtragemParam
{
    public class Relatorio
    {
        public string URI = "98/1";
        public int totalEvents {  get; set; }
        public List<IED> events { get; set; }

        public Relatorio(int p_totalEvents, List<IED> p_events)
        {
            totalEvents = p_totalEvents;
            events = p_events;
        }
    }
}
