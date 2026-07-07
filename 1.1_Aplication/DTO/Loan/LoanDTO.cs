using System.ComponentModel;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Aplication.DTO
{
    public class LoanDTO
    {
        [Description("ID único del préstamo (timestamp + DNI)")]
        public string Id { get; set; }

        [Description("Fecha en que se retiró el libro")]
        public DateTime RetirementDate { get; set; }

        [Description("Fecha en que se devolvió o se debe devolver el libro")]
        public DateTime ReturnDate { get; set; }

        [Description("Información del libro prestado")]
        public Book ABook { get; set; }

        [Description("Información del profesor o estudiante que tiene el préstamo")]
        public object AnAssociated { get; set; }
    }
}