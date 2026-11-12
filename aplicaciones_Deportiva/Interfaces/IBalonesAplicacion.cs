using JB_aplicaciones_Deportiva.entidades;

namespace JB_aplicaciones_Deportiva.interfaces
{
    public interface IBalonesAplicacion
    {
        Balones Insertar(Balones entidad);
        Balones Actualizar(Balones entidad);
        List<Balones> Consultar();
        List<Balones> Buscar(Balones entidad);
        Balones Borrar(Balones entidad);
    }
}