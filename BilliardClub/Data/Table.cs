using System.ComponentModel.DataAnnotations;

namespace BilliardClub.Data
{
    public class Table
    {
        public int TableId { get; set; }
        public int AvalibePlaces { get; set; }
        public bool Smokers { get; set; }
    }
}
