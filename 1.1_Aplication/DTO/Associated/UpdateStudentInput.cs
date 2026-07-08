using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionBiblioteca.Aplication.DTO
{
    public class UpdateStudentInput
    {
        [Description("DNI del estudiante (opcional para actualizar)")]
        public int? Dni { get; set; }

        [Description("Nombre del estudiante (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Name { get; set; }

        [Description("Carrera del estudiante (opcional para actualizar)")]
        [StringLength(100, MinimumLength = 1)]
        public string? Degree { get; set; }
    }
}
