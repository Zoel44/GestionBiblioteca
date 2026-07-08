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
        [HttpGet("{p_id}")]
        [Produces("application/json")]
        public ActionResult<LoanDTO> ObtainForId(string p_id, SearchLoanService service)
        {
            LoanDTO? loan = service.ejecutar(p_id);

            if (loan == null)
            {
                return NotFound(new { mensaje = "Préstamo no encontrado" });
            }

            return Ok(loan);
        }

        /// <summary>
        /// Realiza un préstamo de libro a un profesor
        /// </summary>
        /// <param name="input">DNI del profesor y el ID del libro a prestar</param>
        /// <returns>ID del préstamo creado</returns>
        [HttpPost("lend-professor")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public string LendBookToProfessor([FromBody] CreateLoanInput input, [FromServices] LendBookToProfessorService lendBookService)
        {
            return  "El ID del prestamo es: " + lendBookService.ejecutar(input.Dni, input.BookId);
        }

        /// <summary>
        /// Realiza un préstamo de libro a un estudiante
        /// </summary>
        /// <param name="input">DNI del estudiante y el ID del libro a prestar</param>
        /// <returns>ID del préstamo creado</returns>
        [HttpPost("lend-student")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public string LendBookToStudent([FromBody] CreateLoanInput input, [FromServices] LendBookToStudentService lendBookService)
        {
            return "El ID del prestamo es: " + lendBookService.ejecutar(input.Dni, input.BookId);
        }

        /// <summary>
        /// Registra la devolución de un libro
        /// </summary>
        /// <param name="id">ID del préstamo a devolver</param>
       /* [HttpPatch("{id}/devolver")]
        public ActionResult<string> ReturnBook(string id, ReturnBookService returnBookService)
        {
            try
            {
                returnBookService.ejecutar(id);
                return Ok(new { mensaje = "Libro devuelto exitosamente", prestamoId = id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }*/
    }
}