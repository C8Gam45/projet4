namespace projet4
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private Supplier supplier;

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}