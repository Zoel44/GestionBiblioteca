namespace GestionBiblioteca.Domain.Entities
{
    public abstract class Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public List<Loan> Loans { get; private set; }
        public int LendingDays { get; private set; }

        public Associated(int p_dni, string p_name, List<Loan> p_aLoan, int p_lendingDays)
        {
            //constructor con historial de prestamos
            Dni = p_dni;
            Name = p_name;
            Loans = p_aLoan;
            LendingDays = p_lendingDays;
        }
        public Associated(int p_dni, string p_name, int p_lendingDays)
        {
            //constructor sin historial de prestamos
            Dni = p_dni;
            Name = p_name;
            Loans = new List<Loan>();
            LendingDays = p_lendingDays;
        }
        public int QuantityLendingBooks()
        {
            int i = 0;
            foreach (var loan in Loans)
            {
                i++;
            }
            return i;
        }
        public string ToStringF()
        {
            return $"{Dni} // {Name}, // { TypeOfAssociated()}";
        }
        public bool CanLend(){
            
            //falta implementar la logica
            return false;
        }
        public abstract string TypeOfAssociated();

        
    }
}