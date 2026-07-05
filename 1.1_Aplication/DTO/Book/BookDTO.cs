using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class BookDTO
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Editorial { get; private set; }
        public int Year { get; private set; }
        public int Edition { get; private set; }
        public List<Loan> Loans { get; private set; }
        public int BookID { get; private set; }
        public bool IsAvailable { get; private set; }
    }
}