using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public bool? Reserved { get; set; }
        public int? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public string? Description { get; set; }
        public decimal? PriceForNight { get; set; }


        [ForeignKey("Hotel")]
        public int HotelID { get; set; }
        public virtual Hotel? Hotel { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; } = new List<Booking>();
    }
}
