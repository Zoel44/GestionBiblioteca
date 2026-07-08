namespace GestionBiblioteca.Domain.Entities
{
    public class Loan
    {
        public string Id { get; private set; }
        public DateTime RetirementDate { get; private set; }
       // public DateTime? ReturnDate { get; private set; }
        public Book ABook { get; private set; }
        public object AnAssociated { get; private set; }
        

        public Loan (Professor p_associated, Book p_book)
        {
            RetirementDate = DateTime.Now;
            Id = setID(p_associated);
            setBook(p_book);
            setAssociated(p_associated);
           // ReturnDate = null;
        }

        public Loan (Student p_associated, Book p_book)
        {
            RetirementDate = DateTime.Now;
            Id = setID(p_associated);
            setBook(p_book);
            setAssociated(p_associated);
           // ReturnDate = null;
        }

        private string setID (Professor p_associated)
        {
            return p_associated.Dni.ToString() + RetirementDate.ToString("yyyyMMddhhmmss");
        }

        private string setID (Student p_associated)
        {
            return p_associated.Dni.ToString() + RetirementDate.ToString("yyyyMMddhhmmss");
        }

        public void setBook(Book p_book)
        {
            ABook = p_book;
        }
        public void setAssociated(object p_associated)
        {
            AnAssociated = p_associated;
        }
       /*public void registerDateOfReturn()
        {
            ReturnDate = DateTime.Now;
        }*/
        /*public string toString()//enlista todos los prestamos
        {
            string associatedName = "";
            if (AnAssociated is Professor professor)
                associatedName = professor.Name;
            else if (AnAssociated is Student student)
                associatedName = student.Name;

            return "Retiro: " + RetirementDate.ToString() + "- Devolucion: " + ReturnDate.ToString() + "\n"
            +"Libro: " + ABook.Title + "\n"
            +"Socio: " + associatedName;
        }*/
        


    }
}
