using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class CreateStudentService
    {
        IRepositoryStudents repository;

        public CreateStudentService(IRepositoryStudents p_repository)
        {
            //el constructor se usa para cargar el repositorio 
            repository = p_repository;
        }
        public string ejecutar(CreateStudentInput input)
        {
            try
            {
                Student newAssociated = new Student(99999999, "a", "a");
                newAssociated.setName(input.Name);
                newAssociated.setDNI(input.Dni);
                newAssociated.setDegree(input.Degree);

                repository.addStudent(newAssociated);

                return "Se ha agregado a: " + newAssociated.Dni.ToString();
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Error al crear estudiante: {ex.Message}", ex);
            }
        }
    }
}