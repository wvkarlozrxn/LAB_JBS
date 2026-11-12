using JB_presentaciones_Deportiva.interfaces;
using JB_aplicaciones_Deportiva.entidades;

namespace JB_presentaciones_Deportiva.implementaciones
{
    public class TiposPresentacion : ITiposPresentacion
    {
        private IComunicaciones IComunicaciones;

        public TiposPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public Tipos Actualizar(Tipos entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Tipos>(
                "Tipos/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Tipos Borrar(Tipos entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Tipos>(
                "Tipos/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Tipos> Buscar(Tipos entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Tipos>>(
                "Tipos/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Tipos> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Tipos>>(
                "Tipos/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Tipos Insertar(Tipos entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Tipos>(
                "Tipos/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        private bool Validar(Tipos entidad)
        {/*
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