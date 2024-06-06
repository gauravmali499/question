namespace Exam.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }

    }
}
