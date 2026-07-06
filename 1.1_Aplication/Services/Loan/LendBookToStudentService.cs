using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class LendBookToStudentService
    {
        IRepositoryStudents asso_repo;
        IRepositoryBooks boo_repo;
        IRepositoryLoans loa_repo;
        public LendBookToStudentService(IRepositoryStudents p_repo1, IRepositoryBooks p_repo2, IRepositoryLoans p_repo3)
        {
            asso_repo = p_repo1;
            boo_repo = p_repo2;
            loa_repo = p_repo3;
        }
        public int ejecutar(int p_DNI, int p_ID)
        {
            Student? associated = asso_repo.searchStudentForDNI(p_DNI);
            Book? book = boo_repo.searchBookForID(p_ID);

            if(associated == null && book == null)
            {
                throw new Exception ("Ingresaste mal algo papito");
            }
            else
            {

            string newID = $"{DateTime.Now.ToString("yyyyMMddhhmmss")+p_DNI.ToString()}";
            Loan newLoan = new Loan(DateTime.Now, newID, associated, book);
            loa_repo.addLoan(newLoan);
            
            return int.Parse(newID); 
            }
        }
    }
}