using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Persistence.Repositores
{
    public class ProfessorRepositoryInMemory : IRepositoryProfessors
    {
        private static readonly List<Professor> ProfessorsList = new List<Professor>();
        public void addProfessor(Professor p_professor)
        {
            ProfessorsList.Add(p_professor);
        } 
        public Professor? searchProfessorForDNI(int p_dni)
        {
            foreach(Professor professor in ProfessorsList)
            {
                if(professor.Dni == p_dni)
                {
                    return professor;
                }
            }
            return null;
        }
        public void updateProfessor( Professor p_professor)
        {
            
        }
        public void deleteProfessor(int p_dni)
        {
            
        }

    }
}