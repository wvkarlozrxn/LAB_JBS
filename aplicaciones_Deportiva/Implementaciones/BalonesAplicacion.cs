using JB_aplicaciones_Deportiva.entidades;
using Microsoft.EntityFrameworkCore;

namespace JB_aplicaciones_Deportiva.interfaces
{
    public class BalonesAplicacion : IBalonesAplicacion
    {
        private IConexion IConexion;

        public BalonesAplicacion(IConexion IConexion)
        {
            this.IConexion = IConexion;
        }

        public Balones Actualizar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.IConexion!.Entry<Balones>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return entidad;
        }

        public Balones Borrar(Balones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            this.IConexion.Balones!.Remove(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Balones> Buscar(Balones entidad)
        {
            return this.IConexion.Balones!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<Balones> Consultar()
        {
            return this.IConexion.Balones!.Take(5).ToList();
        }

        public Balones Insertar(Balones entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.IConexion.Balones!.Add(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Balones entidad)
        {
            return string.IsNullOrEmpty(entidad.Codigo) ||
                string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Tamaño <= 0 ||
                entidad.Id_Tipo <= 0;
        }

    }
}