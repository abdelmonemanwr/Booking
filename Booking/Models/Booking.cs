using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Booking.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int? Days { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckoutDate { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public virtual Room? Room { get; set; }

        [ForeignKey("NonHotel")]
        public int NonHotelID { get; set; }
        public virtual NonHotel? NonHotel { get; set; }

        [ForeignKey("Payment")]
        public int PaymentID { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
