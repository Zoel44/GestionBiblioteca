using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryProfessors
    {
        // Método para agregar una cuenta al repositorio
        void addProfessor( Professor  professor);

        // Método para obtener una cuenta por su ID
        Professor? searchProfessorForDNI(int dni);

        // Método para actualizar una cuenta existente
        void updateProfessor( Professor  Professor);

        // Método para eliminar una cuenta por su ID
        void deleteProfessor(int dni);
    }
}