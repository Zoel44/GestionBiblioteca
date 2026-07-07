using System.ComponentModel;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Aplication.DTO
{
    public class StudentDTO
    {
        [Description("DNI del estudiante")]
        public int? Dni { get; set; }

        [Description("Nombre completo del estudiante")]
        public string? Name { get; set; }

        [Description("Carrera/Grado que está cursando")]
        public string? Degree { get; set; }

        [Description("Historial de préstamos del estudiante")]
        public List<Loan>? Loans { get; set; }

        [Description("Cantidad de libros que tiene prestados actualmente")]
        public int? QuantityBooksLending { get; set; }
    }
}
  