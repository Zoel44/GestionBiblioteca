using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryBooks
    {
        void addBook(Book book);

        Book? searchBookForID(int id);
        void updateBook(BookDTO book, int id);

        void deleteBook(int id);
    }
}