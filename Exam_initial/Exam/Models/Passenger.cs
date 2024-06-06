namespace Exam.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public int BusId { get; set; }
        public Bus bus { get; set; }
        public int SeatId { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
