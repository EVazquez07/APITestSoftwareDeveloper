namespace TestSoftwareDeveloper.Models
{
    public class Factura
    {
        public int Id { get; set; }

        public DateTime fecha { get; set; }

        public double monto { get; set; }

        public int IdPersona { get; set; }
    }
}
