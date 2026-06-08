namespace GestionBiblioteca.Domain.Entities
{
    public abstract class Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public List<Loan> ALoan { get; private set; }
        public int LendingDays { get; private set; }

        public Associated(int p_dni, string p_name, List<Loan> p_aLoan, int p_lendingDays)
        {
            Dni = p_dni;
            Name = p_name;
            ALoan = p_aLoan;
            LendingDays = p_lendingDays;
        }

        public int QuantityLendingBooks()
        {
            
        }
    }
}