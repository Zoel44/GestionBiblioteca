using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;

namespace GestionBiblioteca.Aplication.Services
{
    public class DeleteStudentService
    {
        IRepositoryAssociateds repository;
        public DeleteStudentService(IRepositoryAssociateds p_repostory)
        {
            repository = p_repostory;
        }
        public int ejecutar(int p_dni)
        {
            Student? associated = repository.searchStudentForDNI(p_dni);

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