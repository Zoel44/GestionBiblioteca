namespace GestionBiblioteca.Domain.Entities
{
    public class Loan
    {
        public string Id { get; private set; }
        public DateTime RetirementDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public Book ABook { get; private set; }
        public Associated AnAssociated { get; private set; }
        

        public Loan (Associated p_associated, Book p_book)
        {
            RetirementDate = DateTime.Now;
            Id = setID(p_associated);
            setBook(p_book);
            setAssociated(p_associated);
            ReturnDate = null;
        }
        public string setID (Associated p_associated)
        {
            return p_associated.ToString() + RetirementDate.ToString();
        }
        public void setBook(Book p_book)
        {
            ABook = p_book;
        }
        public void setAssociated(Associated p_associated)
        {
            AnAssociated = p_associated;
        }
       public void registerDateOfReturn()
        {
            ReturnDate = DateTime.Now;
        }
        public string toString()
        {
            string associatedName = "";
            if (AnAssociated is Professor professor)
                associatedName = professor.Name;
            else if (AnAssociated is Student student)
                associatedName = student.Name;

            return "Retiro: " + RetirementDate.ToString() + "- Devolucion: " + ReturnDate.ToString() + "\n"
            +"Libro: " + ABook.Title + "\n"
            +"Socio: " + associatedName;
        }
        


    }
}
