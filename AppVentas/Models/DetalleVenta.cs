namespace AppVentas.Models
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
