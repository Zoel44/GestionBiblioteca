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
        public int BookID { get; private set; }
        public bool IsAvailable { get; private set; }


        public Book(string p_title, string p_author, string p_editorial, List<Loan> p_loan, int p_year, int p_edition, int p_id)
        {
            Title = p_title;
            Author = p_author;
            Editorial = p_editorial;
            Year = p_year;
            Edition = p_edition;
            Loans = p_loan;
            BookID = p_id;
            IsAvailable = true;
        }
        public Book(string p_title, string p_author, string p_editorial, int p_year, int p_edition, int p_id)
        {
            setTitle(p_title);
            setAuthor(p_author);
            setEditorial(p_editorial);
            setYear(p_year);
            setEdition(p_edition);
            Loans = new List<Loan>();
            setBookID(p_id);
            IsAvailable = true;
        }
        public bool AvailableStatus(bool status)
        {
            return IsAvailable = status;
        }
        public Loan? lastLoan()
        {   
            if(Loans.Count > 0)
            {
                return Loans[Loans.Count - 1];
            }
            
            return null;
        }

        public void setTitle(string p_title)
        {
            if (!string.IsNullOrWhiteSpace(p_title))
            {
                Title = p_title;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor en blanco, intentelo de nuevo.");
            }
        }
        public void setAuthor(string p_author)
        {
            if (!string.IsNullOrWhiteSpace(p_author))
            {
                Author = p_author;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor en blanco, intentelo de nuevo.");
            }
        }
        public void setEditorial(string p_editorial)
        {
            if (!string.IsNullOrWhiteSpace(p_editorial))
            {
                Editorial = p_editorial;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor en blanco, intentelo de nuevo.");
            }
        }
        public void setYear(int p_year)
        {
            if (p_year > 0)
            {
                Year = p_year;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor inválido para el año, intentelo de nuevo.");
            }
        }
        public void setEdition(int p_edition)
        {
            if (p_edition > 0)
            {
                Edition = p_edition;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor inválido para la edición, intentelo de nuevo.");
            }
        }
        public void setBookID(int p_id)
        {
            if (p_id > 0)
            {
                BookID = p_id;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor inválido para el ID del libro, intentelo de nuevo.");
            }
        }

    }
}