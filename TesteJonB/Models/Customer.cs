namespace TesteJonB.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Order[] Orders { get; set; }
        public Permissao permissao { get; set; }
    }
}