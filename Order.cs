namespace projet4
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Order() { }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
    }
}