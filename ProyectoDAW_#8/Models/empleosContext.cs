using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace ProyectoDAW__8.Models
{
    public class empleosContext : DbContext
    {
        public empleosContext(DbContextOptions<empleosContext> options) : base(options) 
        {

        }
    }
}
