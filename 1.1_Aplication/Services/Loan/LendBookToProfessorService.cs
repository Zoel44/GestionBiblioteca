using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;
using System.Reflection;

namespace GestionBiblioteca.Aplication.Services
{
    public class LendBookToProfessorService
    {
        IRepositoryProfessors asso_repo;
        IRepositoryBooks boo_repo;
        IRepositoryLoans loa_repo;
        public LendBookToProfessorService(IRepositoryProfessors p_repo1, IRepositoryBooks p_repo2, IRepositoryLoans p_repo3)
        {
            asso_repo = p_repo1;
            boo_repo = p_repo2;
            loa_repo = p_repo3;
        }
        public string ejecutar(int p_dni, int p_id)
        {
            Professor? associated = asso_repo.searchProfessorForDNI(p_dni);
            Book? book = boo_repo.searchBookForID( p_id);

            if(associated == null && book == null)
            {
                throw new Exception ("Ingresaste mal algo papito");
            }
            else
            {
            Loan newLoan = new Loan( associated, book); //aquí tal vez debería / podría usar un DTO
            loa_repo.addLoan(newLoan);
            
            return newLoan.Id; 
            }
        }
    }
}