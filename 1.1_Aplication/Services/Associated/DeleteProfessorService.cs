using GestionBiblioteca.Domain.Interfaces;

namespace GestionBiblioteca.Aplication.Services
{
    public class DeleteProfessorService
    {
        IRepositoryAssociateds repository;
        public DeleteProfessorService(IRepositoryAssociateds p_repostory)
        {
            repository = p_repostory;
        }
        public int ejecutar(int p_dni)
        {
            var associated = repository.searchProfessorForDNI(p_dni);

            if(associated == null)
            {
                throw new Exception ("No existe el asociado");
            }
            else
            {
                repository.deleteAssociated(p_dni);
                return p_dni;
            }
        }
    }
}