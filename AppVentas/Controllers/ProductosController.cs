using AppVentas.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AppVentas.Controllers
{
    public class ProductosController : Controller
    {
        private readonly VentasContext _context;

        public ProductosController(VentasContext context)
        {
            _context = context;
        }

        // Muestra los productos en la vista principal
        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
        }
    }
}
