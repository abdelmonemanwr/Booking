using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }

        public virtual ICollection<Hotel>? Hotels { get; set; } = new List<Hotel>();
        public virtual ICollection<NonHotel>? NonHotels { get; set; } = new List<NonHotel>();
    }
}
