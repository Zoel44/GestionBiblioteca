using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class LoanDTO
    {
        public string Id { get;   set; }
        public DateTime RetirementDate { get;   set; }
        public DateTime ReturnDate { get;   set; }
        public Book ABook { get;   set; }
        public Associated AnAssociated { get;   set; }
    }
}