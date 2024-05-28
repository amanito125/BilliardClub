using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilliardClub.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationData { get; set; }
        public int TableId { get; set; }
        [ForeignKey("TableId")]
        public virtual Table? Table { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public string Description { get; set; }

    }
}
