using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryStudents
    {
        void addStudent(Student student);
        Student? searchStudentForDNI (int dni);
        void updateStudent(Student student);
        void deleteStudent(int dni);
    }
}