using System;

namespace QuantumLeap.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string TimePeriod { get; set; }
    }
}