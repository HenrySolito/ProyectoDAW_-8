using System.ComponentModel.DataAnnotations;

namespace ProyectoDAW__8.Models
{
    public class empresas
    {
        [Key]
        public int id_empresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string descripcionEmpresa { get; set; }
        public string imagenEmpresa { get; set; }
        public string ubicacion { get; set; }
        public float salarioPromedio{ get; set; }
        public string perfilTrabajador { get; set; }
    }
}
