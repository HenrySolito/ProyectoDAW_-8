using Microsoft.AspNetCore.Mvc;
using ProyectoDAW__8.Models;

namespace ProyectoDAW__8.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly empleosContext _empleosContext;

        public EmpresasController(empleosContext empleosContext)
        {
            _empleosContext = empleosContext;
        }
        // GET: Empresas
        public IActionResult Index()
        {
            var empresas = _empleosContext.empresas.ToList();
            return View(empresas);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(empresas empresa)
        {
            if (ModelState.IsValid)
            {
                _empleosContext.empresas.Add(empresa);
                _empleosContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // Otras acciones como Edit, Delete, etc.
    }
}
