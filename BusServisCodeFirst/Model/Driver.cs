namespace CodeFirst_SchoolServise.Model
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  PhoneNum { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public string HomeAdress { get; set; }
        public string License { get; set; }
        public ICollection<Ride> Rides { get; set; }
    }
}
