using System.ComponentModel.DataAnnotations.Schema;

namespace JB_aplicaciones_Deportiva.entidades
{
        public class Tipos
        {
            public int Id { get; set; }
            public string? Marca { get; set; }
            public string? Categoria { get; set; }

            public List<Balones>? Balones { get; set; }
        }
    
}