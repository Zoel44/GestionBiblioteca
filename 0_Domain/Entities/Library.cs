namespace GestionBiblioteca.Domain.Entities
{
    public class Library
    {
        public string Name { get; private set;}
        public List<Associated> Associateds { get; private set;}
        public List<Book> Books { get; private set;}

        public Library(string p_name)
        {
            Name = p_name;
            Associateds = new List<Associated>();
            Books = new List<Book>();
        }
        public void newBook(string p_title, string p_author, string p_editorial, int p_year, int p_edition)
        {
            
        }
        public void newStudent(int p_dni, string p_name, string p_degree)
        {
            
        }
        public void newProfessor(int p_dni, string p_name, string p_subject)
        {
            
        }
        public bool lendBook(Associated p_associated, Book p_book)
        {//Crea el préstamo, y lo agrega en el libro y el socio.
            string newID = $"{DateTime.Now.ToString("yyyyMMddhhmmss")+p_associated.Dni.ToString()}";
            Loan a_loan = new Loan(DateTime.Now, newID);

            foreach (var assoc in Associateds)
            {
                if ()
            }
            
        }
        public void returnBook(Book p_book)
        {
            
        }
        public int quantityAssocciatedsForType(string p_type)
        {
            
        }
        public List<Loan> expiredLoans()
        {
            
        }
        public List<Professor> responsableProfesssors()
        {
            
        }
        public string whoHaveTheBook(Book book)
        {
            
        }
        public string AssociatedsList()
        {
            
        }
        public Associated searchAssociated(int p_dni)
        {
            
        }
        public string listTitles()
        {
            
        }
        public string BookList()
        {
            
        }
        public String ResponsableProfessorsList()
        {

        }

    }
}