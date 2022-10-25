using System.ComponentModel.DataAnnotations;

namespace Sistema_Web.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Obligatorio!")]

        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo Descripcion es Obligatorio!")]
        public string? Descripcion { get; set; }

    }
}
