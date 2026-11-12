using JB_aplicaciones_Deportiva.entidades;
using JB_aplicaciones_Deportiva.nucleo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JB_presentaciones_Deportiva.interfaces;

namespace JB_Front_Deportivo.Pages.Ventanas
{
    public class DeportivaModel : PageModel
    {
        private IBalonesPresentacion IBalonesPresentacion;
        private ITiposPresentacion ITiposPresentacion;

        public DeportivaModel(IBalonesPresentacion IBalonesPresentacion,
            ITiposPresentacion ITiposPresentacion)
        {
            this.IBalonesPresentacion = IBalonesPresentacion;
            this.ITiposPresentacion = ITiposPresentacion;
            this.Filtro = new Balones();
        }

        public List<SelectListItem> ListaTipos { get; set; } = new();

        private void CargarTipos()
        {
            ListaTipos = this.ITiposPresentacion.Consultar()
                .Select(x => new SelectListItem(x.Marca, x.Id.ToString()))
                .ToList();
        }

        [BindProperty] public List<Balones> Lista { get; set; }
        [BindProperty] public Balones? Filtro { get; set; }
        [BindProperty] public Balones? Actual { get; set; }
        [BindProperty] public bool Formulario { get; set; } = false;
        [BindProperty] public bool Borrar { get; set; } = false;
        
        public void OnGet() { OnPostBtConsultar(); }

        public void OnPostBtConsultar()
        {
            try
            {
                Filtro!.Nombre = Filtro!.Nombre ?? "";
                Lista = this.IBalonesPresentacion.Buscar(Filtro!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtNuevo()
        {
            try
            {
                Formulario = true;
                this.Actual = new Balones();
                this.Actual.Activa = true;
                CargarTipos();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtGuardar()
        {
            try
            {
                if (this.Actual!.Id == 0)
                    this.Actual = this.IBalonesPresentacion.Insertar(this.Actual!);
                else
                    this.Actual = this.IBalonesPresentacion.Actualizar(this.Actual!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
            finally
            {
                OnPostBtConsultar();
            }
        }

        public void OnPostBtEditar(string data)
        {
            try
            {
                Formulario = true;
                OnPostBtConsultar();
                this.Actual = this.Lista.FirstOrDefault(x => x.Id == Convert.ToInt32(data));
                CargarTipos();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtPregBorrar(string data)
        {
            try
            {
                Borrar = true;
                OnPostBtConsultar();
                this.Actual = this.Lista.FirstOrDefault(x => x.Id == Convert.ToInt32(data));
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtBorrar()
        {
            try
            {
                if (this.Actual!.Id == 0)
                    return;
                this.Actual = this.IBalonesPresentacion.Borrar(this.Actual!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
            finally
            {
                OnPostBtConsultar();
            }
        }
    }
}
