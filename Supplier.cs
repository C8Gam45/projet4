namespace projet4
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Contact { get; set; }

        public Supplier() { }

        public Supplier(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }
    }
}