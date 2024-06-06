namespace Exam.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; } = true;
        public List<Seat> seat { get; set; }
    }
}
