using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;

namespace GestionBiblioteca.Presentation.Controllers
{
    [ApiController] // Indica que es un controlador de API
    [Route("api/library")] // Define la ruta (ej: api/productos)
    public class AssociatedController : ControllerBase
    {

        [HttpGet]
        public IActionResult Dummy()
        {
            return Ok(new { mensaje = "Hola AssociatedController" });
        }

        [HttpGet("{dni:int}/Search Professor")]
        public ProfessorDTO? SearchProfessorForDNI(int id, SearchProfessorService service)
        {
            return service.ejecutar(id);
        }
        [HttpGet("{dni:int}/Search Student")]
        public StudentDTO? SearchStudentForDNI(int id, SearchStudentService service)
        {
            return service.ejecutar(id);
        }

        [HttpPost]
        public int CreateProfessor([FromBody] CreateProfessorInput input, CreateProfessorService crearCuentaService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            return crearCuentaService.ejecutar(input);
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }
        [HttpPost]
        public int CreateStudent([FromBody] CreateStudentInput input, CreateStudentService crearCuentaService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            return crearCuentaService.ejecutar(input);
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }
        [HttpDelete("{id:int}/Delete Professor")]
        public void DeleteProfessor(int id, DeleteProfessorService servicio)
        {
            servicio.ejecutar(id);
        }
        [HttpDelete("{id:int}/Delete Student")]
        public void DeleteStudent(int id, DeleteStudentService servicio)
        {
            servicio.ejecutar(id);
        }
    }
}