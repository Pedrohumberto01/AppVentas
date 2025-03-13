namespace AppVentas.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Tipo { get; set; } // "Cliente" o "Administrador"
        public string Email { get; set; } // Añadido para cumplir con la expectativa
        public string UserName { get; set; } // Añadido para cumplir con la expectativa
    }
}
    