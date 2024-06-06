namespace Exam.Models
{
    public class busDTO
    {
        public string BusName { get; set; }
        public string Image { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public bool Status { get; set; } = true;
        public List<seatDTO> seat { get; set; }
    }
}
