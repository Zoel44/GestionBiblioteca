namespace GestionBiblioteca.Domain.Entities
{
    public class Loan
    {
        public DateTime RetirementDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public Book LoandedBook { get; private set; }
        public Associated AnAssociated { get; private set; }

        


    }
}
