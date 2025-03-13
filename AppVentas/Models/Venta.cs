namespace AppVentas.Models
{
    public class Venta
    {
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
    }
}
