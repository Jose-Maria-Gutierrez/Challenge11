using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionariaMVC1.Controllers
{
    public class VehiculoController : Controller
    {
        private readonly ApplicationDbContext contexto;
        public VehiculoController(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }
        public IActionResult Index()
        {
            IEnumerable<Vehiculo> listaVehiculos = contexto.Vehiculo; 
            return View(listaVehiculos);
        }
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Vehiculo v)
        {
            if (ModelState.IsValid)
            {
                contexto.Vehiculo.Add(v);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Editar(int? id)
        {
            Vehiculo v = contexto.Vehiculo.Find(id);
            
            if (v == null)
                return NotFound();

            return View(v);
        }
        [HttpPost]
        public IActionResult Editar(Vehiculo v)
        {
            if (ModelState.IsValid)
            {
                contexto.Vehiculo.Update(v);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v);
        }

        public IActionResult Eliminar(int? id)
        {
            Vehiculo v = contexto.Vehiculo.Find(id);

            if (v == null)
                return NotFound();
            else
            {
                contexto.Vehiculo.Remove(v);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}
