using JB_aplicaciones_Deportiva.entidades;

namespace JB_presentaciones_Deportiva.interfaces
{
    public interface ITiposPresentacion
    {
        Tipos Insertar(Tipos entidad);
        Tipos Actualizar(Tipos entidad);
        List<Tipos> Consultar();
        List<Tipos> Buscar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
    }
}