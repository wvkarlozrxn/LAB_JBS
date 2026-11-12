using JB_aplicaciones_Deportiva.entidades;

namespace JB_aplicaciones_Deportiva.interfaces
{
    public interface IAuditoriasAplicacion
    {
        Auditorias Insertar(Auditorias entidad);
        Auditorias Actualizar(Auditorias entidad);
        List<Auditorias> Consultar();
        List<Auditorias> Buscar(Auditorias entidad);
        Auditorias Borrar(Auditorias entidad);
    }
}