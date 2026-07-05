using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class SearchStudentService
    {
         IRepositoryAssociateds repository;
         public SearchStudentService(IRepositoryAssociateds p_repo)
        {
            repository = p_repo;
        }
        public StudentDTO? ejecutar(int p_dni)
        {
            Student? associated = repository.searchStudentForDNI(p_dni);

            if(associated == null)
                return null;

            return new StudentDTO()
            {
                Dni = associated.Dni,
                Name = associated.Name,
                Degree = associated.Degree,
                Loans = associated.Loans,
                QuantityBooksLending = associated.QuantityBooksLending
                
            };
        }
    }
}