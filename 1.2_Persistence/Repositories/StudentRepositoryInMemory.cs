using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Persistence.Repositores
{
    public class StudentRepositoryInMemory : IRepositoryStudents
    {
        private static readonly List<Student> StudentsList = new List<Student>();
        public void addStudent(Student p_student)
        {
            StudentsList.Add(p_student);
        } 
        public Student? searchStudentForDNI(int p_dni)
        {
            foreach(Student student in StudentsList)
            {
                if(student.Dni == p_dni)
                {
                    return student;
                }
            }
            return null;
        }
        public void updateStudent( Student p_student)
        {
            
        }
        public void deleteStudent(int p_dni)
        {
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if(StudentsList[i].Dni == p_dni)
                {
                    StudentsList.RemoveAt(i);
                    break;
                }
            }
        }

    }
}