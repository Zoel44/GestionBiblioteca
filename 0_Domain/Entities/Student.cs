namespace GestionBiblioteca.Domain.Entities
{
    public class Student : Associated
    {
        public string Degree { get; private set; }
        public Student(int p_dni, string p_name, List<Loan> p_aLoan, int p_lendingDays, string p_degree)
            : base(p_dni, p_name, p_aLoan, 20)
<<<<<<< HEAD
        {//constructor con historial de prestamos
            Degree = p_degree;
        }
        public Student(int p_dni, string p_name, int p_lendingDays, string p_degree)
            : base(p_dni, p_name,20)
        {
            Degree = p_degree;
        }
        public override string typeOfAssociated()
=======
        {
            Degree = p_degree;
        }
        public Student(int p_dni, string p_name, int p_lendingDays, string p_degree)
            : base(p_dni, p_name,20)
        {
            Degree = p_degree;
        }
        public override string TypeOfAssociated()
>>>>>>> a50fcbf1f4418dba8e21a757e3c6c1176787b952
        {
            return "Student";
        }
    }
}