using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class SearchLoanService
    {
         IRepositoryLoans repository;
         public SearchLoanService(IRepositoryLoans p_repo)
        {
            repository = p_repo;
        }
        public LoanDTO? ejecutar(string p_id)
        {
            Loan? loan = repository.searchLoanForID(p_id);

            if(loan != null)
            {
                LoanDTO a_loan = new LoanDTO();
                 a_loan.Id = loan.Id;
                 a_loan.RetirementDate = loan.RetirementDate;
                 //a_loan.ReturnDate = loan.ReturnDate;
                 a_loan.ABook = loan.ABook;
                 a_loan.AnAssociated = loan.AnAssociated;
                 return a_loan;
            }
            else
            {
                return null;
            }
            
        }
    }
}