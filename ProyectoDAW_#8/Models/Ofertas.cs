using System.ComponentModel.DataAnnotations;

namespace ProyectoDAW__8.Models
{
    public class Ofertas
    {
        [Key]
        public int id_ofertas { get; set; }

        public string nombrePuesto { get; set; }

        public string descripcionOferta { get; set; }

        public string salario { get; set; }

        public string? imagenPuesto { get; set; }

        public int? id_empresa { get; set; }

        public string descripcionEmpleo { get; set; }

        public string perfilTrabajador { get; set; }
    }
}
