using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class SearchProfessorService
    {
         IRepositoryProfessors repository;
         public SearchProfessorService(IRepositoryProfessors p_repo)
        {
            repository = p_repo;
        }
        public ProfessorDTO? ejecutar(int p_dni)
        {
            Professor? associated = repository.searchProfessorForDNI(p_dni);

            if(associated == null)
                return null;

            return new ProfessorDTO()
            {
                Dni = associated.Dni,
                Name = associated.Name,
                Subject = associated.Subject,
                Loans = associated.Loans,
                QuantityBooksLending = associated.QuantityBooksLending
                
            };
        }
    }
}