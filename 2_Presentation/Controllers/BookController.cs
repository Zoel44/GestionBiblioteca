using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Presentation.Controllers
{
    [ApiController] // Indica que es un controlador de API
    [Route("api/book")] // Define la ruta (ej: api/productos)
    public class LibraryController : ControllerBase
    {

        [HttpGet]
        public IActionResult Dummy()
        {
            return Ok(new { mensaje = "Hola BookController!!" });
        }

        [HttpGet("{id:int}/Get")]
        public BookDTO? ObtenerPorId(int id, SearchBookService service)
        {
            return service.ejecutar(id);

        }

        [HttpPost]
        public string CrearCuenta([FromBody] CreateBookInput input, CreateBookService createService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            createService.ejecutar(input);
            return "el libro se agregó correctamente";
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }

        [HttpDelete("{id:int}/Delete")]
        public void Delete(int id, DeleteBookService servicio)
        {
            servicio.ejecutar(id);
                     
        }
    }
}