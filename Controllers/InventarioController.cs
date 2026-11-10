using Microsoft.AspNetCore.Mvc;
using ConectaInventory.Data;
using ConectaInventory.Models;

namespace ConectaInventory.Controllers
{
    public class InventarioController : Controller
    {
        private readonly ConectaInventoryContext _context;

        public InventarioController(ConectaInventoryContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public IActionResult Index()
        {
            return View();
        }

        // POST: Registrar Nuevo Equipo (HU-0101)
        [HttpPost]
        public IActionResult RegistrarEquipo(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                // Validar si el serial ya existe para evitar duplicados
                var existe = _context.Equipos.Find(equipo.NumSerial);
                if (existe != null)
                {
                    ModelState.AddModelError("", "El número de serial ya se encuentra registrado en el sistema.");
                    return View(equipo);
                }

                _context.Equipos.Add(equipo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(equipo);
        }
    }
}