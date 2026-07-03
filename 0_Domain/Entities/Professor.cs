namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public string Subject { get; private set; }

        public Professor(int p_dni, string p_name, List<Loan> p_aLoan, string p_subject, int p_days)
            : base(p_dni, p_name, p_aLoan, p_days)
        {//constructor con historial de prestamos
            Subject = p_subject;
        }
        public Professor(int p_dni, string p_name, string p_subject)
            : base(p_dni, p_name)
        {
            setSubject(p_subject);
        }
        public override string typeOfAssociated()
        {
            return "Professor";
        }
        public void setSubject(string p_subject)
        {
            if (!string.IsNullOrWhiteSpace(p_subject))
            {
                Subject = p_subject;
            }
            else
            {
                throw new ArgumentException("Ingresó un valor en blanco, intentelo de nuevo.");
            }
        }
    }
}