using System.ComponentModel;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Aplication.DTO
{
    public class ProfessorDTO
    {
        [Description("DNI del profesor")]
        public int Dni { get; set; }

        [Description("Nombre completo del profesor")]
        public string Name { get; set; }

        [Description("Materia que enseña")]
        public string Subject { get; set; }

        [Description("Historial de préstamos del profesor")]
        public List<Loan> Loans { get; set; }

        [Description("Cantidad de libros que tiene prestados actualmente")]
        public int QuantityBooksLending { get; set; }
    }
}