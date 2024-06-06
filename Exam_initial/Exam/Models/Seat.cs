namespace Exam.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int seatNumber { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
