using Microsoft.EntityFrameworkCore;
using Examen.Models;


namespace Examen.Context
{
    public class AplicacionContext: DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
       : base(options) { }
        public DbSet<Avion> Avion { get; set; }
        public DbSet<Hangares> Hangares { get; set; }
        public DbSet<Piloto> Piloto { get; set; }


    }
}
