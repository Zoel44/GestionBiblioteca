using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryStudents
    {
        // Método para agregar una cuenta al repositorio
        void addStudent(Associated associated);

        // Método para obtener una cuenta por su ID
        Student? searchStudentForDNI (int dni);

        // Método para actualizar una cuenta existente
        void updateStudent(Associated Student);

        // Método para eliminar una cuenta por su ID
        void deleteStudent(int dni);
    }
}