using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class BusBookingContext: DbContext
    {
        public BusBookingContext(DbContextOptions<BusBookingContext> options): base(options)
        {
            
        }

        public DbSet<Bus> buses { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<Seat> seats { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Place> places { get; set; }
    }
}
