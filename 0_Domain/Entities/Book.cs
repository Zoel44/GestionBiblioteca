namespace GestionBiblioteca.Domain.Entities
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Editorial { get; private set; }
        public int Year { get; private set; }
        public string Isbn { get; private set; }

        public Book(string p_title, string p_author, string p_editorial, int p_year, string p_isbn)
        {
            Title = p_title;
            Author = p_author;
            Editorial = p_editorial;
            Year = p_year;
            Isbn = p_isbn;
        }
    }
}