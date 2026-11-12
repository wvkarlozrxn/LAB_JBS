using JB_presentaciones_Deportiva.interfaces;
using JB_aplicaciones_Deportiva.entidades;

namespace JB_presentaciones_Deportiva.implementaciones
{
    public class BalonesPresentacion : IBalonesPresentacion
    {
        private IComunicaciones IComunicaciones;

        public BalonesPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public Balones Actualizar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Balones/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Balones Borrar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Balones/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Balones> Buscar(Balones entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Balones>>(
                "Balones/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Balones> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Balones>>(
                "Balones/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Balones Insertar(Balones entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Balones>(
                "Balones/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        private bool Validar(Balones entidad)
        {
            // Devuelve true cuando FALTA información (por eso quien la llama lanza el error si es true)
            return string.IsNullOrEmpty(entidad.Codigo) ||
                string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Tamaño <= 0 ||
                entidad.Id_Tipo <= 0;
        }
    }
}