using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateLoanInput
    {
        [Required(ErrorMessage = "El DNI es requerido")]
        [Description("DNI del profesor o estudiante. Debe tener 8 dígitos. Ej: 38456789")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "El ID del libro es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El ID del libro debe ser válido")]
        [Description("ID del libro a prestar. Ej: 1")]
        public int BookId { get; set; }
    }
}