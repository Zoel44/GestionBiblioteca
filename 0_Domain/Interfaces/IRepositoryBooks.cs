using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryBooks
    {
        void addBook(Book book);

        Book? searchBookForID(int id);


        void updateBook(Book book);

        void deleteBook(int id);
    }
}