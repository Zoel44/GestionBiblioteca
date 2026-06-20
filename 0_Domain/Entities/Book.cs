namespace GestionBiblioteca.Domain.Entities
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Editorial { get; private set; }
        public int Year { get; private set; }
        public int Edition { get; private set; }
        public List<Loan> Loans { get; private set; }

        public Book(string p_title, string p_author, string p_editorial, int p_year, int p_edition)
        {
            Title = p_title;
            Author = p_author;
            Editorial = p_editorial;
            Year = p_year;
            edition = p_edition;
            Loans = new List<Loan>();
        }
    }
}