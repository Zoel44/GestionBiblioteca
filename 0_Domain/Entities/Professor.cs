namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public string Subject { get; private set; }

        public Professor(int p_dni, string p_name, List<Loan> p_aLoan, string p_subject)
            : base(p_dni, p_name, p_aLoan, 5)
        {//constructor con historial de prestamos
            Subject = p_subject;
        }
        public Professor(int p_dni, string p_name, string p_subject)
            : base(p_dni, p_name, 5)
        {
            Subject = p_subject;
        }
        public override string typeOfAssociated()
        {
            return "Professor";
        }


    }
}