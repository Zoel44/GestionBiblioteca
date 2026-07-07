using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Domain.Interfaces
{
    public interface IRepositoryProfessors
    {
        void addProfessor( Professor  professor);

        Professor? searchProfessorForDNI(int dni);

        void updateProfessor( Professor  Professor);

        void deleteProfessor(int dni);
    }
}