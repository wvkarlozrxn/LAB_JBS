
using JB_aplicaciones_Deportiva.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace JB_aplicaciones_Deportiva.interfaces
{
    public interface IConexion
    {
        DbSet<Tipos>? Tipos { get; set; }
        DbSet<Auditorias>? Auditorias { get; set; }
        DbSet<Balones>? Balones { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
