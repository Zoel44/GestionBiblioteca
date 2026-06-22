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

        public Book(string p_title, string p_author, string p_editorial, int p_year, int p_edition, int p_id)
        {
            Title = p_title;
            Author = p_author;
            Editorial = p_editorial;
            Year = p_year;
            Edition = p_edition;
            Loans = new List<Loan>();
            BookID = p_id;
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
                return Loans[Loans.Count^1];
            }
            
            return null;
        }

    }
}