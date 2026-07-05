namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateStudentInput
    {//clase para que el operador cargue datos
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public string Degree { get; private set; }
    }
}