using JB_aplicaciones_Deportiva.entidades;
using JB_aplicaciones_Deportiva.interfaces;
using JB_aplicaciones_Deportiva.nucleo;
using Microsoft.EntityFrameworkCore;

namespace JB_aplicaciones_Deportiva.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Auditorias>? Auditorias { get; set; }
        public DbSet<Balones>? Balones { get; set; }
        public DbSet<Tipos>? Tipos { get; set; }
    }
}
