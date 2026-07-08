using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Presentation.Controllers
{
    /// <summary>
    /// Controlador para gestionar libros en la biblioteca
    /// </summary>
    [ApiController]
    [Route("api/book")]
    public class LibraryController : ControllerBase
    {
        /// <summary>
        /// Busca un libro por su ID
        /// </summary>
        /// <param name="id">ID del libro a buscar</param>
        /// <returns>Datos del libro encontrado</returns>
        [HttpGet("{id:int}")]
        [Produces("application/json")]
        public BookDTO? SearchForId(int id, SearchBookService service)
        {
            return service.ejecutar(id);
        }

        /// <summary>
        /// Crea un nuevo libro en el sistema, la ID es un contador que inicia en 0 y se asigna uno automáticamente 
        /// </summary>
        /// <param name="input">Datos del libro a crear (título, autor, editorial, año, edición)</param>
        /// <returns>Mensaje de confirmación</returns>
        [HttpPost("create")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public string CreateBook([FromBody] CreateBookInput input, [FromServices] CreateBookService createService)
        {
            return "el libro se agregó correctamente, el ID es: " + createService.ejecutar(input);
            
        }

        /// <summary>
        /// Elimina un libro del sistema
        /// </summary>
        /// <param name="id">ID del libro a eliminar</param>
        [HttpDelete("{id:int}")]
        public void DeleteBook(int id, DeleteBookService servicio)
        {
            servicio.ejecutar(id);
        }

        /// <summary>
        /// Actualiza los datos de un libro
        /// </summary>
        /// <param name="id">ID del libro a actualizar</param>
        /// <param name="input">Datos del libro a actualizar (todos los campos son opcionales)</param>
        [HttpPut("{id:int}/update")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ActionResult<string> UpdateBook(int id, [FromBody] UpdateBookInput input, [FromServices] UpdateBookService service)
        {
            try
            {
                service.ejecutar(id, input);
                return Ok(new { mensaje = "Libro actualizado exitosamente", id = id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}