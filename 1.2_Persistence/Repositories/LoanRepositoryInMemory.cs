using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Persistence.Repositores
{
    public class LoanRepositoryInMemory : IRepositoryLoans
    {
        private static readonly List<Loan> LoanList = new List<Loan>();
        public void addLoan(Loan p_loan)
        {
            LoanList.Add(p_loan);
        }
        public Loan? searchLoanForID(string p_id)
        {
            foreach(Loan loan in LoanList)
            {
                if(loan.Id.Equals(p_id))
                {
                    return loan;
                }
            }
            return null;
        }
        public void returnLoan(string p_id)
        {
            Loan? loan = searchLoanForID(p_id);
            if(loan != null)
            {
                loan.registerDateOfReturn(DateTime.Now);
            }
        }
        public void updateLoan(Loan loan)
        {
            
        }

        public void deleteLoan(string id)
        {
            
        }
    }
}


