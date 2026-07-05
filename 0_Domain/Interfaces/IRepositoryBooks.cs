using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryBooks
    {
        // Método para agregar una cuenta al repositorio
        void addBook(Book book);

        // Método para obtener una cuenta por su ID
        Book? searchBookForID(int id);

        // Método para actualizar una cuenta existente
        void updateBook(Book book);

        // Método para eliminar una cuenta por su ID
        void deleteBook(int id);
    }
}