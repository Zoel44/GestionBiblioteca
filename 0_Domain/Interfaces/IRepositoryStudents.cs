using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryStudents
    {
        void addStudent(Student student);
        Student? searchStudentForDNI (int dni);
        void updateStudent(StudentDTO student, int dni);
        void deleteStudent(int dni);
    }
}