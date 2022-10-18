using System.ComponentModel.DataAnnotations;

namespace Sistema_Web.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Descripcion { get; set; }

    }
}
