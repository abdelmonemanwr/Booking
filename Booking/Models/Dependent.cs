using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Dependent
    {
        [Key]
        public int DeptID { get; set; }
        public string? Gender { get; set; }
        public string? DeptName { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User? User { get; set; }
    }
}
