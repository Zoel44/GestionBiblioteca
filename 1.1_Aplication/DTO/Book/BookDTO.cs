using System.ComponentModel;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Aplication.DTO
{
    public class BookDTO
    {
        [Description("Título del libro")]
        public string? Title { get; set; }

        [Description("Autor del libro")]
        public string? Author { get; set; }

        [Description("Editorial que publicó el libro")]
        public string? Editorial { get; set; }

        [Description("Año de publicación")]
        public int ? Year { get; set; }

        [Description("Número de edición")]
        public int? Edition { get; set; }

        [Description("ID único del libro en el sistema")]
        public int? BookID { get; set; }

        [Description("Indica si el libro está disponible para prestar")]
        public bool? IsAvailable { get; set; }
    }
}