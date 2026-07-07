namespace GestionBiblioteca.Domain.Entities
{
    public class Loan
    {
        public string Id { get; private set; }
        public DateTime RetirementDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public Book ABook { get; private set; }
        public Associated AnAssociated { get; private set; }
        

        public Loan (DateTime p_retirementDate, string p_id, Associated p_associated, Book p_book)
        {
            RetirementDate = p_retirementDate;
            Id = p_id;
            ABook = p_book;
            AnAssociated = p_associated;
        }

       public void registerDateOfReturn(DateTime p_returnDate)
        {
            ReturnDate = p_returnDate;
        }
        public bool expired(DateTime correctDevolutionDay)
        {//pregunta si está expirado
            if(ReturnDate > correctDevolutionDay)
            {
                //preguntamos si el prestamo esta vencido, para eso comparamos la fecha de devolucion con la fecha de retiro mas los dias de prestamo
                return true;
            }
            return false;
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
