namespace GestionBiblioteca.Domain.Entities
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Editorial { get; private set; }
        public int Year { get; private set; }
<<<<<<< HEAD
        public int Edition { get; private set; }
        public List<Loan> Loans { get; private set; }

        public Book(string p_title, string p_author, string p_editorial, int p_year, int p_edition)
=======
        public string Isbn { get; private set; }

        public Book(string p_title, string p_author, string p_editorial, int p_year, string p_isbn)
>>>>>>> a50fcbf1f4418dba8e21a757e3c6c1176787b952
        {
            Title = p_title;
            Author = p_author;
            Editorial = p_editorial;
            Year = p_year;
<<<<<<< HEAD
            edition = p_edition;
            Loans = new List<Loan>();
=======
            Isbn = p_isbn;
>>>>>>> a50fcbf1f4418dba8e21a757e3c6c1176787b952
        }
    }
}