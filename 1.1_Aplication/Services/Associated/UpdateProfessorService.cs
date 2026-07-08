using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class UpdateProfessorService
    {
        IRepositoryProfessors repository;

        public UpdateProfessorService(IRepositoryProfessors p_repository)
        {
            repository = p_repository;
        }

        public void ejecutar(int p_dni, UpdateProfessorInput input)
        {
            try
            {
                repository.updateProfessor(new ProfessorDTO
                {
                    Dni = input.Dni,
                    Name = input.Name,
                    Subject = input.Subject
                }, p_dni);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Error al actualizar profesor: {ex.Message}", ex);
            }
        }
    }
}
