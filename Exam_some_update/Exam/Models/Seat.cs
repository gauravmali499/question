namespace Exam.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int seatNumber { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        
    }
}