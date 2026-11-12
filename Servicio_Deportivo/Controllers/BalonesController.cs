using JB_aplicaciones_Deportiva.entidades;
using JB_aplicaciones_Deportiva.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JB_aplicaciones_Deportiva.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BalonesController : ControllerBase
    {
        private IBalonesAplicacion IBalonesAplicacion;

        public BalonesController(IBalonesAplicacion IBalonesAplicacion)
        {
            this.IBalonesAplicacion = IBalonesAplicacion;
        }

        [HttpPost]
        public List<Balones> Consultar()
        {
            return this.IBalonesAplicacion.Consultar();
        }

        [HttpPost]
        public List<Balones> Buscar(Balones entidad)
        {
            return this.IBalonesAplicacion.Buscar(entidad);
        }

        [HttpPost]
        public Balones Insertar(Balones entidad)
        {
            return this.IBalonesAplicacion.Insertar(entidad);
        }

        [HttpPost]
        public Balones Actualizar(Balones entidad)
        {
            return this.IBalonesAplicacion.Actualizar(entidad);
        }

        [HttpPost]
        public Balones Borrar(Balones entidad)
        {
            return this.IBalonesAplicacion.Borrar(entidad);
        }
    }
}
