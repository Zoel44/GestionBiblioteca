using Microsoft.AspNetCore.Mvc;
using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Aplication.Services;

namespace GestionBiblioteca.Presentation.Controllers
{
    /// <summary>
    /// Controlador para gestionar profesores y estudiantes en la biblioteca
    /// </summary>
    [ApiController]
    [Route("api/library")]
    public class AssociatedController : ControllerBase
    {
        /// <summary>
        /// Busca un profesor por su DNI
        /// </summary>
        /// <param name="dni">DNI del profesor a buscar (8 dígitos)</param>
        /// <returns>Datos del profesor encontrado</returns>
        [HttpGet("{dni:int}/search-professor")]
        [Produces("application/json")]
        public ProfessorDTO? SearchProfessorForDNI(int dni, SearchProfessorService service)
        {
            return service.ejecutar(dni);
        }

        /// <summary>
        /// Busca un estudiante por su DNI
        /// </summary>
        /// <param name="dni">DNI del estudiante a buscar (8 dígitos)</param>
        /// <returns>Datos del estudiante encontrado</returns>
        [HttpGet("{dni:int}/search-student")]
        [Produces("application/json")]
        public StudentDTO? SearchStudentForDNI(int dni, SearchStudentService service)
        {
            return service.ejecutar(dni);
        }

        /// <summary>
        /// Crea un nuevo profesor en el sistema
        /// </summary>
        /// <param name="input">Datos del profesor a crear (DNI, nombre y materia)</param>
        /// <returns>DNI del profesor creado</returns>
        [HttpPost("create-professor")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public int CreateProfessor([FromBody] CreateProfessorInput input, [FromServices] CreateProfessorService crearCuentaService)
        {
            return crearCuentaService.ejecutar(input);
        }

        /// <summary>
        /// Crea un nuevo estudiante en el sistema
        /// </summary>
        /// <param name="input">Datos del estudiante a crear (DNI, nombre y carrera)</param>
        /// <returns>DNI del estudiante creado</returns>
        [HttpPost("create-student")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public int CreateStudent([FromBody] CreateStudentInput input, [FromServices] CreateStudentService crearCuentaService)
        {
            return crearCuentaService.ejecutar(input);
        }

        /// <summary>
        /// Elimina un profesor del sistema
        /// </summary>
        /// <param name="id">DNI del profesor a eliminar</param>
        [HttpDelete("{id:int}/delete-professor")]
        public void DeleteProfessor(int id, DeleteProfessorService servicio)
        {
            servicio.ejecutar(id);
        }

        /// <summary>
        /// Elimina un estudiante del sistema
        /// </summary>
        /// <param name="id">DNI del estudiante a eliminar</param>
        [HttpDelete("{id:int}/delete-student")]
        public void DeleteStudent(int id, DeleteStudentService servicio)
        {
            servicio.ejecutar(id);
        }
    }
}