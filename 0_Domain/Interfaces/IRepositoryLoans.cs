using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryLoans
    {
        void addLoan(Loan loan);

        Loan? searchLoanForID(string id);

        void deleteLoan(string id);
       // void returnLoan(string id);
    }
}