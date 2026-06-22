namespace GestionBiblioteca.Domain.Entities
{
    public class Student : Associated
    {
        public string Degree { get; private set; }
        public Student(int p_dni, string p_name, List<Loan> p_aLoan, string p_degree)
            : base(p_dni, p_name, p_aLoan, 20)
        {//constructor con historial de prestamos
            Degree = p_degree;
        }
        public Student(int p_dni, string p_name, string p_degree)
            : base(p_dni, p_name, 20)
        {
            Degree = p_degree;

        }
        public override string typeOfAssociated()
        {
            return "Student";
        }
        public override bool canLend()
        {   
            if(QuantityBooksLending > 3)
            {//si tiene mas de 2 libros no puede pedir prestado, así que tampoco hace falta ver si tiene prestamos vencidos
                foreach (Loan aLoan in Loans)
                {
                    if (aLoan.expired(aLoan.RetirementDate.AddDays(LendingDays)))
                    {
                    //preguntamos si el prestamo esta vencido, para eso comparamos la fecha de devolucion con la fecha de retiro mas los dias de prestamo
                    //si está vencido no puede pedir prestado, can ask lend? false, no
                    return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}