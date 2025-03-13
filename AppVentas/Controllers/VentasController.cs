using AppVentas.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppVentas.Controllers
{
    public class VentasController : Controller
    {
        private readonly VentasContext _context;

        public VentasController(VentasContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Comprar(int idProducto)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.ID == idProducto);

            if (producto != null && producto.Stock > 0)
            {
                producto.Stock -= 1;
                _context.SaveChanges();
                TempData["Mensaje"] = $"¡Has comprado {producto.Nombre} exitosamente!";
            }
            else
            {
                TempData["Error"] = "Producto no disponible.";
            }

            return RedirectToAction("Index", "Productos");
        }
    }
}
