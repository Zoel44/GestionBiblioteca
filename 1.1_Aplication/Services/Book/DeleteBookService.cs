using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;

namespace GestionBiblioteca.Aplication.Services
{
    public class DeleteBookService
    {
        IRepositoryBooks repo;
        public DeleteBookService(IRepositoryBooks p_repo)
        {
            repo = p_repo;
        }
        public int ejecutar(int p_ID)
        {
            Book? book = repo.searchBookForID(p_ID);

            if(book == null)
            {
                throw new Exception ("No existe el libro");
            }
            else
            {
                repo.deleteBook(p_ID);
                return p_ID;
            }
        }
    }
}