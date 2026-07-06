using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateProfessorInput
    {
        [Required(ErrorMessage = "El DNI es requerido")]
        [Description("DNI del profesor. Debe tener 8 dígitos")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        [Description("Nombre completo del profesor")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La materia es requerida")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La materia debe tener entre 2 y 100 caracteres")]
        [Description("Materia que enseña")]
        public string Subject { get; set; }
    }
}