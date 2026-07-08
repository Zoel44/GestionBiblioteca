using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionBiblioteca.Aplication.DTO
{
    public class UpdateProfessorInput
    {
        [Description("DNI del profesor (opcional para actualizar)")]
        public int? Dni { get; set; }

        [Description("Nombre del profesor (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Name { get; set; }

        [Description("Materia del profesor (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Subject { get; set; }
    }
}
