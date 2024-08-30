using Microsoft.EntityFrameworkCore;
using TestCrud.Modelos;

namespace TestCrud.Datos
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        //Aqui colocar los modelos

        public DbSet<Producto> Productos { get; set; }
    }
}
