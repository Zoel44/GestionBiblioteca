using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateLoanInput
    {
        public Book ABook { get; private set; }
        public Associated AnAssociated { get; private set; }
    }
}