namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public string Subject { get; private set; }

        public Professor(int p_dni, string p_name, List<Loan> p_aLoan, string p_subject)
            : base(p_dni, p_name, p_aLoan, 5)
<<<<<<< HEAD
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


=======
        {
            Subject = p_subject;
        }
        public Professor(int p_dni, string p_name, string p_subject)
            : base(p_dni, p_name, 5)
        {
            Subject = p_subject;
        }
        public override string TypeOfAssociated()
        {
            return "Professor";
        }
    
>>>>>>> a50fcbf1f4418dba8e21a757e3c6c1176787b952
    }
}