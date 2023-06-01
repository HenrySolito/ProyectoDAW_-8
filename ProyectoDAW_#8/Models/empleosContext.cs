using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Identity.Client;

namespace ProyectoDAW__8.Models
{
    public class empleosContext : DbContext
    {
        public empleosContext(DbContextOptions<empleosContext> options) : base(options) 
        {
           
        }
        public DbSet<empresas> empresas{ get; set; }
        public DbSet<Ofertas> ofertas { get; set; }
        public DbSet<Usuarios> usas { get; set; }
        public DbSet<usuarioTipos> usuarioTipos { get; set; }
    }
}
