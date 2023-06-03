using Microsoft.AspNetCore.Mvc;
using ProyectoDAW__8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ProyectoDAW__8.Controllers
{
    public class ofertasController : Controller
    {
        private readonly empleosContext _empleosContext;
        private readonly ILogger<ofertasController> _logger;

        public ofertasController(ILogger<ofertasController> logger, empleosContext empleosContext)
        {
            _logger = logger;
            _empleosContext = empleosContext;
        }

            public IActionResult Index()
        {
            var OfertaGeneral = (from m in _empleosContext.ofertas
                                select new {
                                    id_ofertas = m.id_ofertas,
                                    nombrePuesto = m.nombrePuesto,
                                    descripcionOferta = m.descripcionOferta,
                                    salario = m.salario,
                                }).ToList();
            ViewData["listaOfertas"] = OfertaGeneral;

            return View();
        }

        public IActionResult GetID(int id) //agregado de ID 
        {
            var OfertaDetallada = (from m in _empleosContext.ofertas where id == m.id_ofertas
                                 select new
                                 {
                                     id_ofertas = m.id_ofertas,
                                     nombrePuesto = m.nombrePuesto,
                                     descripcionEmpleo = m.descripcionEmpleo,
                                     salario = m.salario,
                                 }).ToList();

            ViewData["detallesOferta"] = OfertaDetallada;
            return View();
        }
    }
}
