namespace GestionBiblioteca.Domain.Entities
{
    public class Student : Associated
    {
        public string Degree { get; private set; }
        public Student(int p_dni, string p_name, List<Loan> p_aLoan, string p_degree,int p_days)
            : base(p_dni, p_name, p_aLoan, p_days)
        {//constructor con historial de prestamos
            Degree = p_degree;
        }
        public Student(int p_dni, string p_name, string p_degree)
            : base(p_dni, p_name)
        {
            setDegree(p_degree);
        }
        public override string typeOfAssociated()
        {
            return "Student";
        }
        public void setDegree(string p_degree)
        {
            if (!string.IsNullOrWhiteSpace(p_degree))
            {
                Degree = p_degree;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor en blanco, intentelo de nuevo.");
            }
        }

    }
}