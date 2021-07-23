namespace Day_35
{
    public class Company : Model
    {
        private static int _objectsCreated = 0;
        // ეს სოლუშენი არც მე მომწონს, rails-ზე orm-ს დახმარებით ვაკეთებ ხოლმე ინკრემენტს
        // აქაც იმედია ენთითის ექნება სპეციალური თული

        public string Name { get; set; }
        public string Domain { get; set; }
        public Company(string name, string domain) : base(_objectsCreated++)
        {
            Name = name;
            Domain = domain;
        }
    }
}