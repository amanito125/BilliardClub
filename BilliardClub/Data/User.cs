namespace BilliardClub.Data
{
    public class User
    {
        public User()
        {
            Reservations = new List<Reservation>();
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
