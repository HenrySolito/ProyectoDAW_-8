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
            var OfertaGeneral = (from m in _empleosContext.ofertas
                                 join e in _empleosContext.empresas on m.id_empresa equals e.id_empresa
                                 where m.id_ofertas == id
                                 select new
                                 {
                                     nombre = m.nombrePuesto,
                                     descripcion = m.descripcionOferta,
                                     nombreEmpresa = e.nombreEmpresa,
                                     DescripcionEmpresa = e.descripcionEmpresa,
                                     ubicacion = e.ubicacion

                                 }).ToList();
                                
            ViewData["listaOfertas"] = OfertaGeneral;

            return View();
        }
        public IActionResult detalleW()
        {
            return View();
        }
    }
}
