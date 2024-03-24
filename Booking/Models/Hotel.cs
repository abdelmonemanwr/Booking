using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public int? RoomsNumber { get; set; }
        public string? Address { get; set; }
        public string? HotelName { get; set; }
        public string? HotelType { get; set; }
        public string? Description { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
