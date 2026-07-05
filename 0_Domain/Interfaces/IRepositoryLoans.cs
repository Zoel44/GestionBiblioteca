using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryLoans
    {
        // Método para agregar una cuenta al repositorio
        void addLoan(Book book);

        // Método para obtener una cuenta por su ID
        Book? searchLoanForID(int id);

        // Método para actualizar una cuenta existente
        void updateLoan(Book book);

        // Método para eliminar una cuenta por su ID
        void deleteLoan(int id);
    }
}