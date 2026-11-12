using System.ComponentModel.DataAnnotations.Schema;

namespace JB_aplicaciones_Deportiva.entidades
{
    public class Balones
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public Decimal Tamaño { get; set; }   
        public int Id_Tipo { get; set; }
        public bool Activa { get; set; }
        [ForeignKey("Id_Tipo")] public Tipos? _Tipo { get; set; }
    }
}