using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class SearchBookService
    {
        IRepositoryBooks repo;
        public SearchBookService(IRepositoryBooks p_repo)
        {
            repo = p_repo;
        }
        public BookDTO? ejecutar(int p_ID)
        {
            Book? book = repo.searchBookForID(p_ID);

            if(book == null)
                return null;
            
            return new BookDTO()
            {
                Title = book.Title,
                Author = book.Author,
                Editorial = book.Editorial,
                Year = book.Year,
                Edition = book.Edition,
                BookID = book.BookID,
                IsAvailable = book.IsAvailable
        
            };
        }
    }
}