using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class CreateProfessorService
    {
        IRepositoryProfessors repository;

        public CreateProfessorService(IRepositoryProfessors p_repository)
        {
            repository = p_repository;
        }
        public int ejecutar(CreateProfessorInput input)
        {
            try
            {
                Professor newAssociated = new Professor(99999999, "a", "a");
                newAssociated.setName(input.Name);
                newAssociated.setDNI(input.Dni);
                newAssociated.setSubject(input.Subject);

                repository.addProfessor(newAssociated);

                return newAssociated.Dni;
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Error al crear profesor: {ex.Message}", ex);
            }
        }
    }
}