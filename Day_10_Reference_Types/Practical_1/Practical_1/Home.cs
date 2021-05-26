namespace Practical_1
{
    public class Home
    {
        public string Address { get; set; }
        public string City { get; set; }
        public Home(string address, string city)
        {
            Address = address;
            City = city;
        }
    }
}