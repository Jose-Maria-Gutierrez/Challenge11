using ConcesionariaMVC1.DAL;
using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionariaMVC1.Controllers
{
    public class VehiculoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiculoController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Vehiculo> listaVehiculos = this._unitOfWork.VehiculoRepository.obtenerTodos(); 
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
                this._unitOfWork.VehiculoRepository.agregar(v);
                this._unitOfWork.guardar();
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Editar(int? id)
        {
            Vehiculo v = this._unitOfWork.VehiculoRepository.obtenerId(id);
            if (v == null)
                return NotFound();

            return View(v);
        }
        [HttpPost]
        public IActionResult Editar(Vehiculo v)
        {
            if (ModelState.IsValid)
            {
                this._unitOfWork.VehiculoRepository.actualizar(v);
                this._unitOfWork.guardar();
                return RedirectToAction("Index");
            }

            return View(v);
        }

        public IActionResult Eliminar(int? id)
        {
            this._unitOfWork.VehiculoRepository.eliminar(id);
            this._unitOfWork.guardar();
            return RedirectToAction("Index");
        }

    }
}
