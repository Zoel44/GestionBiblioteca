using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionBiblioteca.Aplication.DTO
{
    public class UpdateBookInput
    {
        [Description("Título del libro (opcional para actualizar)")]
        [StringLength(200, MinimumLength = 1)]
        public string? Title { get; set; }

        [Description("Autor del libro (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Author { get; set; }

        [Description("Editorial del libro (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Editorial { get; set; }

        [Description("Año de publicación del libro (opcional para actualizar)")]
        [Range(1450, 2100)]
        public int? Year { get; set; }

        [Description("Edición del libro (opcional para actualizar)")]
        public int? Edition { get; set; }
    }
}
