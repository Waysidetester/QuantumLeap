using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantumLeap.Models
{
    public class Leaper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentLeap { get; set; }
        public List<Leapee> PastLeapees { get; set; }
        public List<Event> PastEvents { get; set; }
        public Leapee CurrentLeapee { get; set; }
    }
}
