using GestionBiblioteca.Aplication.DTO;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryProfessors
    {
        void addProfessor( Professor  professor);

        Professor? searchProfessorForDNI(int dni);

        void updateProfessor( ProfessorDTO  Professor, int dni);

        void deleteProfessor(int dni);
    }
}