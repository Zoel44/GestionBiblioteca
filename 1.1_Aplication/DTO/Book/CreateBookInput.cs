using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateBookInput
    {
        [Required(ErrorMessage = "El título es requerido")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "El título debe tener entre 2 y 200 caracteres")]
        [Description("Título del libro. Ej: El Quijote")]
        public string Title { get; set; }

        [Required(ErrorMessage = "El autor es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El autor debe tener entre 2 y 100 caracteres")]
        [Description("Autor del libro. Ej: Miguel de Cervantes")]
        public string Author { get; set; }

        [Required(ErrorMessage = "La editorial es requerida")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La editorial debe tener entre 2 y 100 caracteres")]
        [Description("Editorial que publicó el libro. Ej: Alfaguara")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El año es requerido")]
        [Range(1000, 9999, ErrorMessage = "El año debe ser válido")]
        [Description("Año de publicación. Ej: 1605")]
        public int Year { get; set; }

        [Required(ErrorMessage = "La edición es requerida")]
        [Range(1, 999, ErrorMessage = "La edición debe ser un número positivo")]
        [Description("Número de edición del libro. Ej: 3")]
        public int Edition { get; set; }
    }
}