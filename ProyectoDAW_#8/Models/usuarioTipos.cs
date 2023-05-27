using System.ComponentModel.DataAnnotations;
namespace ProyectoDAW__8.Models
{
    public class usuarioTipos
    {
        [Key]
        public int? id_tipo_usuario { get; set; }

        public string User_type { get; set; }
    }
}
