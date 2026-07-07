using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Aplication.DTO;

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
        public void updateProfessor( ProfessorDTO p_professor, int p_dni)
        {
            for (int i = 0; i < ProfessorsList.Count; i++)
            {
                if(ProfessorsList[i].Dni == p_dni)
                {   
                    if(p_professor.Dni != null)
                    {
                        ProfessorsList[i].setDNI(p_professor.Dni.Value);
                    }
                    if(p_professor.Name != null)
                    {
                        ProfessorsList[i].setName(p_professor.Name);
                    }
                    if(p_professor.Subject != null)
                    {
                        ProfessorsList[i].setSubject(p_professor.Subject);
                        break;
                    }
                    
                }
                
            }
            
        }
        public void deleteProfessor(int p_dni)
        {

            for (int i = 0; i < ProfessorsList.Count; i++)
            {
                if(ProfessorsList[i].Dni == p_dni)
                {
                    ProfessorsList.RemoveAt(i);
                    break;
                }
            }

        }
    }

}