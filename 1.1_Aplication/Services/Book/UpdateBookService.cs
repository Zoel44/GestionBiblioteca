using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class UpdateBookService
    {
        IRepositoryBooks repository;

        public UpdateBookService(IRepositoryBooks p_repository)
        {
            repository = p_repository;
        }

        public void ejecutar(int p_id, UpdateBookInput input)
        {
            try
            {
                repository.updateBook(new BookDTO
                {
                    Title = input.Title,
                    Author = input.Author,
                    Editorial = input.Editorial,
                    Year = input.Year,
                    Edition = input.Edition
                }, p_id);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Error al actualizar libro: {ex.Message}", ex);
            }
        }
    }
}
