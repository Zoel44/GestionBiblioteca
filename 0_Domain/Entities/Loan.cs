namespace GestionBiblioteca.Domain.Entities
{
    public class Loan
    {
        public string Id { get; private set; }
        public DateTime RetirementDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        
        public Loan (DateTime p_retirementDate, string p_id)
        {
            RetirementDate = p_retirementDate;
            Id = p_id;
        }
       public void registerDateOfReturn(DateTime p_returnDate)
        {
            ReturnDate = p_returnDate;
        }
        public bool expired(DateTime dateTime)
        {
            
        }
        public string toString()
        {
            
        }
        


    }
}
