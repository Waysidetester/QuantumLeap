namespace QuantumLeap.Models
{
    public class Leapee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLeapedTo { get; set; }
        public bool HasBeenLeapedTo { get; set; }
        public Leaper CurrentLeaper { get; set; }
        public int EventId { get; set; }
    }
}