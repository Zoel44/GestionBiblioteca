namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public string Subject { get; private set; }

        public Professor(int p_dni, string p_name, Loan p_aLoan, int p_lendingDays, string p_subject)
            : base(p_dni, p_name, p_aLoan, p_lendingDays)
        {
            Subject = p_subject;
        }
    }
}