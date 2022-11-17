namespace TesteJonB.Models
{
    public class SomeEntity
    {
        public SomeEntity()
        {
            DataCadastro = DateTime.UtcNow;//new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DataAlterado = DateTime.Now;
            DataTeste = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
        }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlterado { get; set; }
        public DateTime DataTeste { get; set; }
        public DateTime DataTeste2 { get; set; }
        public DateTime DataAutomatico { get; set; }
        public DateTime DataAutomaticoUtc { get; set; }
        public Customer Customer { get; set; }
    }
}