using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateStudentInput
    {
        [Required(ErrorMessage = "El DNI es requerido")]
        [Description("DNI del estudiante. Debe tener 8 dígitos. Ej: 45123789")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        [Description("Nombre completo del estudiante. Ej: María Rodríguez López")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La carrera es requerida")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La carrera debe tener entre 2 y 100 caracteres")]
        [Description("Carrera/Grado que está cursando. Ej: Ingeniería en Sistemas")]
        public string Degree { get; set; }
    }
}