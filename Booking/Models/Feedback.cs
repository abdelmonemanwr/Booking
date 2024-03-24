using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackID { get; set; }
        public string? Feed { get; set; }
        public int? Rate { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User? User { get; set; }


        [ForeignKey("Hotel")]
        public int HotelID { get; set; }
        public virtual Hotel? Hotel { get; set; }
    }
}
