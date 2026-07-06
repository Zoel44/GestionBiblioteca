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
        public BookDTO? ObtenerPorId(int id, SearchBookService service)
        {
            return service.ejecutar(id);
        }

        /// <summary>
        /// Crea un nuevo libro en el sistema
        /// </summary>
        /// <param name="input">Datos del libro a crear (título, autor, editorial, año, edición)</param>
        /// <returns>Mensaje de confirmación</returns>
        [HttpPost("create")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public string CrearCuenta([FromBody] CreateBookInput input, [FromServices] CreateBookService createService)
        {
            createService.ejecutar(input);
            return "el libro se agregó correctamente";
        }

        /// <summary>
        /// Elimina un libro del sistema
        /// </summary>
        /// <param name="id">ID del libro a eliminar</param>
        [HttpDelete("{id:int}")]
        public void Delete(int id, DeleteBookService servicio)
        {
            servicio.ejecutar(id);
        }
    }
}