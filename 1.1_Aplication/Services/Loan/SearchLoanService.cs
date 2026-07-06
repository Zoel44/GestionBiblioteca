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
        public LoanDTO? ejecutar(string p_dni)
        {
            Loan? loan = repository.searchLoanForID(p_dni);

            if(loan == null)
                return null;

            return new LoanDTO()
            {
                Id = loan.Id,
                RetirementDate = loan.RetirementDate,
                ReturnDate = loan.ReturnDate,
                ABook = loan.ABook,
                AnAssociated = loan.AnAssociated,
            };
        }
    }
}