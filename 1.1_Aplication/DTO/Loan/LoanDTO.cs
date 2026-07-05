using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class LoanDTO
    {
        public string Id { get; private set; }
        public DateTime RetirementDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public Book ABook { get; private set; }
        public Associated AnAssociated { get; private set; }
    }
}