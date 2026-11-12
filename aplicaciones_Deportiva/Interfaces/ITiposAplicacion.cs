using JB_aplicaciones_Deportiva.entidades;

namespace JB_aplicaciones_Deportiva.interfaces
{
    public interface ITiposAplicacion
    {
        Tipos Insertar(Tipos entidad);
        Tipos Actualizar(Tipos entidad);
        List<Tipos> Consultar();
        List<Tipos> Buscar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
    }
}