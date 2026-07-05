using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryAssociateds
    {
        // Método para agregar una cuenta al repositorio
        void addAssociated(Associated associated);

        // Método para obtener una cuenta por su ID
        Professor? searchProfessorForDNI(int dni);
        Student? searchStudentForDNI (int dni);

        // Método para actualizar una cuenta existente
        void updateAssociated(Associated associated);

        // Método para eliminar una cuenta por su ID
        void deleteAssociated(int dni);
    }
}