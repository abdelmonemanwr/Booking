using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class NonHotel
    {
        [Key]
        public int NonHotelID { get; set; }
        public string? Type { get; set; }
        public bool? Reserved { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? NonHotelName { get; set; }


        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location? Location { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; } = new List<Booking>();
    }
}
