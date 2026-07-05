namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateProfessorInput
    {//clase para que el operador cargue datos
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public string Subject { get; private set; }
    }
}