using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Aplication.Services;

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
                if(loan.Id == p_id)
                {
                    return loan;
                }
            }
            return null;
        }
       /* public void returnLoan(string p_id)
        {
             for (int i = 0; i < LoanList.Count; i++)
            {
                if(LoanList[i].Id == p_id)
                {
                    LoanList[i].registerDateOfReturn();
                    break;
                }
            }
        }*/
        public void deleteLoan(string p_id)
        {
            for (int i = 0; i < LoanList.Count; i++)
            {
                if(LoanList[i].Id == p_id)
                {
                    LoanList.RemoveAt(i);
                    break;
                }
            }

        } 
    }
}


