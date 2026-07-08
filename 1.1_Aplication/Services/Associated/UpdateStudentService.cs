using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class UpdateStudentService
    {
        IRepositoryStudents repository;

        public UpdateStudentService(IRepositoryStudents p_repository)
        {
            repository = p_repository;
        }

        public void ejecutar(int p_dni, UpdateStudentInput input)
        {
            try
            {
                repository.updateStudent(new StudentDTO
                {
                    Dni = input.Dni,
                    Name = input.Name,
                    Degree = input.Degree
                }, p_dni);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Error al actualizar estudiante: {ex.Message}", ex);
            }
        }
    }
}
