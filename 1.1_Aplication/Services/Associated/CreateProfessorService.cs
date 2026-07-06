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
            Professor newAssociated = new Professor(0, "a", "a"); //se le asignan datos genéricos que serán actualizados a continuación, para evitar usar un constructor sin datos
            newAssociated.setName(input.Name);
            newAssociated.setDNI(input.Dni);
            newAssociated.setSubject(input.Subject);

            repository.addProfessor(newAssociated);

            return newAssociated.Dni;
        }
    }
}