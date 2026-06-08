namespace GestionBiblioteca.Domain.Entities
{
    public class Student : Associated
    {
        public string Degree { get; private set; }
        public Student(int p_dni, string p_name, Loan p_aLoan, int p_lendingDays, string p_degree)
            : base(p_dni, p_name, p_aLoan, p_lendingDays)
        {
            Degree = p_degree;
        }
    }
}