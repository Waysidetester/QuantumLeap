using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantumLeap.Models
{
    public class LeapeeBasic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentLeaper { get; set; }
        public string TimePeriod { get; set; }
    }
}
