using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Aplication.DTO;

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
        public void updateStudent( StudentDTO p_student, int p_dni)
        {
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if(StudentsList[i].Dni == p_dni)
                {   
                    if(p_student.Dni != null)
                    {
                        StudentsList[i].setDNI(p_student.Dni.Value);
                    }
                    if(p_student.Name != null)
                    {
                        StudentsList[i].setName(p_student.Name);
                    }
                    if(p_student.Degree != null)
                    {
                        StudentsList[i].setDegree(p_student.Degree);
                        break;
                    }
                    
                }
                
            }
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