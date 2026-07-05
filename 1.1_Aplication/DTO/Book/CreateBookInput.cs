namespace GestionBiblioteca.Aplication.DTO
{
    public class CreateBookInput
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Editorial { get; private set; }
        public int Year { get; private set; }
        public int Edition { get; private set; }
    }
}