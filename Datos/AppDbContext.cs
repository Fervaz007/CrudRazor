using Microsoft.EntityFrameworkCore;

namespace TestCrud.Datos
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        //Aqui colocar los modelos
    }
}
