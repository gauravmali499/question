//using Exam.Data;
//using Exam.Models.DTOs;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Exam.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BookingController : ControllerBase
//    {
//        private readonly BusBookingContext context;
//        public BookingController(BusBookingContext context)
//        {
//            this.context = context;
//        }
//        // POST api/<BookingController>
//        [HttpPost]
//        public ActionResult<Guid> Post(int busId, [FromBody] BookingSeatDTO seat)
//        {
//            var bus = context.buses.FirstOrDefault(x => x.Id == busId);
//            if (bus != null)
//            {
//                foreach (var Aseat in context.seats)
//                {
//                    if (Aseat.seatNumber == seat.seatNumber)
//                    {
//                        if (Aseat.IsAvailable)
//                        {
//                            Aseat.IsAvailable = false;
//                            context.seats.Update(Aseat);
//                            context.SaveChanges();
//                            return Ok($"Your Seat is Booked and Your PNR No. is {Guid.NewGuid()}.");
//                        }
//                        return StatusCode(StatusCodes.Status204NoContent, "seat is not available, it's Booked.");
//                    }                    
//                }              
//            }
//            return StatusCode(StatusCodes.Status404NotFound, "Bus is not available.");    
//        }
//    }
//}