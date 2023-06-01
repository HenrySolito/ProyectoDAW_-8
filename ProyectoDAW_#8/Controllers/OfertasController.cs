using Microsoft.AspNetCore.Mvc;
using ProyectoDAW__8.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDAW__8.Controllers
{
    public class ofertasController : Controller
    {
        private readonly empleosContext _empleosContext;

        public ofertasController(empleosContext empleosContext)
        {
            _empleosContext = empleosContext;
        }
        public IActionResult Index()
        {
            var OrfetaGeneral = (from m in _empleosContext.ofertas
                                select new {
                                    id_ofertas = m.id_ofertas,
                                    nombrePuesto = m.nombrePuesto,
                                    descripcionOferta = m.descripcionOferta,
                                    salario = m.salario,
                                }).ToList();

            return View();
        }
    }
}
