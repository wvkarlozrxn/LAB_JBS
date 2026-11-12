using JB_presentaciones_Deportiva.interfaces;
using JB_aplicaciones_Deportiva.entidades;

namespace JB_presentaciones_Deportiva.implementaciones
{
    public class AuditoriasPresentacion : IAuditoriasPresentacion
    {
        private IComunicaciones IComunicaciones;

        public AuditoriasPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public Auditorias Actualizar(Auditorias entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Auditorias>(
                "Auditorias/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Auditorias Borrar(Auditorias entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Auditorias>(
                "Auditorias/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Auditorias> Buscar(Auditorias entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Auditorias>>(
                "Auditorias/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Auditorias> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Auditorias>>(
                "Auditorias/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Auditorias Insertar(Auditorias entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Auditorias>(
                "Auditorias/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        private bool Validar(Auditorias entidad)
        {
            /*
             return string.IsNullOrEmpty(entidad.Codigo) ||
                 string.IsNullOrEmpty(entidad.Nombre) ||
                 string.IsNullOrEmpty(entidad.Lugar) ||
                 entidad.Inicio == null ||
                 entidad.Final == null ||
                 string.IsNullOrEmpty(entidad.Notas);
             */

            return true;
        }
    }
}