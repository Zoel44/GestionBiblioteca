using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class BookDTO
    {
        public string Title { get;   set; }
        public string Author { get;   set; }
        public string Editorial { get;   set; }
        public int Year { get;   set; }
        public int Edition { get;   set; }
        public List<Loan> Loans { get;   set; }
        public int BookID { get;   set; }
        public bool IsAvailable { get;   set; }
    }
}