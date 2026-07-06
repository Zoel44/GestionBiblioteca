using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;

namespace GestionBiblioteca.Presentation.Controllers
{
    [ApiController] // Indica que es un controlador de API
    [Route("api/loan")] // Define la ruta (ej: api/productos)
    public class LoanController : ControllerBase
    {

        [HttpGet]
        public IActionResult Dummy()
        {
            return Ok(new { mensaje = "Hola desde LoanController!!" });
        }

        [HttpGet("{id:string}")]
        public LoanDTO? ObtainForId(string p_id, SearchLoanService service)
        {
            return service.ejecutar(p_id);
        }

        [HttpPost]
        public int LendBookToProfessor([FromBody] int p_dni, int p_id, LendBookToProfessorService lendBookService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            return lendBookService.ejecutar(p_dni, p_id);
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }
        [HttpPost]
        public int LendBookToStudent([FromBody] int p_dni, int p_id, LendBookToStudentService lendBookService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            return lendBookService.ejecutar(p_dni, p_id);
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }

        [HttpPatch("{id:string}/devolver")]
        public void Patch(string id, ReturnBookService returnBookService)
        {
            returnBookService.ejecutar(id);
        }
    }
}