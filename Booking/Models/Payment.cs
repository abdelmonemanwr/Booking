using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public decimal? Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
