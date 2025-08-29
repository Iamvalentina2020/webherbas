using Microsoft.EntityFrameworkCore;
using cruds.Models; 

namespace cruds.Data
{
    public class TareaDBContext : DbContext
    {
        public TareaDBContext(DbContextOptions<TareaDBContext> options) : base(options)
        {
            //tarea
        }
        public DbSet<Tarea> Tareas { get; set; } //tarea
        protected TareaDBContext()
        {
        }
    }
}
