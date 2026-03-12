namespace projet4
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        private Customer customer;
        private List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            products = new List<Product>();
        }
    }
}