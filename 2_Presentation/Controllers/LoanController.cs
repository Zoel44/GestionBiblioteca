using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;

namespace GestionBiblioteca.Presentation.Controllers
{
    /// <summary>
    /// Controlador para gestionar préstamos de libros en la biblioteca
    /// </summary>
    [ApiController]
    [Route("api/loan")]
    public class LoanController : ControllerBase
    {
        /// <summary>
        /// Busca un préstamo por su ID
        /// </summary>
        /// <param name="p_id">ID del préstamo a buscar</param>
        /// <returns>Datos del préstamo encontrado</returns>
        [HttpGet("{id}")]
        [Produces("application/json")]
        public LoanDTO? ObtainForId(string p_id, SearchLoanService service)
        {
            return service.ejecutar(p_id);
        }

        /// <summary>
        /// Realiza un préstamo de libro a un profesor
        /// </summary>
        /// <param name="input">DNI del profesor y ID del libro a prestar</param>
        /// <returns>ID del préstamo creado</returns>
        [HttpPost("lend-professor")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public int LendBookToProfessor([FromBody] CreateLoanInput input, [FromServices] LendBookToProfessorService lendBookService)
        {
            return lendBookService.ejecutar(input.Dni, input.BookId);
        }

        /// <summary>
        /// Realiza un préstamo de libro a un estudiante
        /// </summary>
        /// <param name="input">DNI del estudiante y ID del libro a prestar</param>
        /// <returns>ID del préstamo creado</returns>
        [HttpPost("lend-student")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public int LendBookToStudent([FromBody] CreateLoanInput input, [FromServices] LendBookToStudentService lendBookService)
        {
            return lendBookService.ejecutar(input.Dni, input.BookId);
        }

        /// <summary>
        /// Registra la devolución de un libro
        /// </summary>
        /// <param name="id">ID del préstamo a devolver</param>
        [HttpPatch("{id}/devolver")]
        public void Patch(string id, ReturnBookService returnBookService)
        {
            returnBookService.ejecutar(id);
        }
    }
}