using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class CreateBookService
    {
        public static int ID = 0;
        IRepositoryBooks repository;
        public CreateBookService(IRepositoryBooks p_repo)
        {
            repository = p_repo;
        }
        public void ejecutar(CreateBookInput input)
        {
            Book newBook = new Book("a", "a", "a", 1, 1, 1);
            newBook.setTitle(input.Title);
            newBook.setAuthor(input.Author);
            newBook.setEdition(input.Edition);
            newBook.setYear(input.Year);
            newBook.setEditorial(input.Editorial);
            newBook.setBookID(ID);

            repository.addBook(newBook);
            ID ++;
        }
    }
}