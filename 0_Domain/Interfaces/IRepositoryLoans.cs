using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryLoans
    {
        // Método para agregar una cuenta al repositorio
        void addLoan(Loan loan);

        // Método para obtener una cuenta por su ID
        Loan? searchLoanForID(string id);

        // Método para eliminar una cuenta por su ID
        void deleteLoan(string id);
        void returnLoan(string id);
    }
}