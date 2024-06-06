namespace Exam.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public List<Booking> MyProperty { get; set; }
    }
}
