using System.ComponentModel.DataAnnotations;
namespace ProyectoDAW__8.Models
{
    public class Usuarios
    {
        [Key]
        public int? id_usuario { get; set; }

        public int? id_tipo_usuario { get; set; }

        public string? password { get; set; }

        public string? correoUsuario { get; set; }

        public string primerUsuario { get; set; }

        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public int Edad { get; set; }

        public string descripcion { get; set; }

        public string experiencia { get; set; }

        public string interesPersonal { get; set; }

        public string? CV { get; set; }

    }
}
