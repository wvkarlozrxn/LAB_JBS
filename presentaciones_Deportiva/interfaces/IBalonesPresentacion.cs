using JB_aplicaciones_Deportiva.entidades;

namespace JB_presentaciones_Deportiva.interfaces
{
    public interface IBalonesPresentacion
    {
        Balones Insertar(Balones entidad);
        Balones Actualizar(Balones entidad);
        List<Balones> Consultar();
        List<Balones> Buscar(Balones entidad);
        Balones Borrar(Balones entidad);
    }
}