using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;

namespace GestionBiblioteca.Aplication.Services
{
    public class DeleteProfessorService
    {
        IRepositoryProfessors repository;
        public DeleteProfessorService(IRepositoryProfessors p_repostory)
        {
            repository = p_repostory;
        }
        public int ejecutar(int p_dni)
        {
            Professor? associated = repository.searchProfessorForDNI(p_dni);

            if(associated == null)
            {
                throw new Exception ("No existe el asociado");
            }
            else
            {
                repository.deleteProfessor(p_dni);
                return p_dni;
            }
        }
    }
}