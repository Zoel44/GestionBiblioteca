using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Aplication.Services
{
    public class CreateStudentService
    {
        IRepositoryAssociateds repository;

        public CreateStudentService(IRepositoryAssociateds p_repository)
        {
            //el constructor se usa para cargar el repositorio 
            repository = p_repository;
        }
        public int ejecutar(CreateStudentInput input)
        {
            var newAssociated = new Student(0, "a", "a"); //se le asignan datos genéricos que serán actualizados a continuación, para evitar usar un constructor sin datos
            newAssociated.setName(input.Name);
            newAssociated.setDNI(input.Dni);
            newAssociated.setDegree(input.Degree);

            repository.addAssociated(newAssociated);

            return newAssociated.Dni;
        }
    }
}