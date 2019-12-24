using Microsoft.EntityFrameworkCore;

namespace NetCore1.Models
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Centro_estudio> Centro_estudio { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options)
            : base(options)
        { }
    }
}
