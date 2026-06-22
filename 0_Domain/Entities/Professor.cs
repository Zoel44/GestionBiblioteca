namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public string Subject { get; private set; }
        public bool Responsability { get; private set; }

        public Professor(int p_dni, string p_name, List<Loan> p_aLoan, string p_subject)
            : base(p_dni, p_name, p_aLoan, 5)
        {//constructor con historial de prestamos
            Subject = p_subject;
            Responsability = true;
        }
        public Professor(int p_dni, string p_name, string p_subject)
            : base(p_dni, p_name, 5)
        {
            Subject = p_subject;
            Responsability = true;
        }
        public override string typeOfAssociated()
        {
            return "Professor";
        }
        public bool isResponsable()
        {
            if (canLend() == true)
            {
                return true;
            }
            return Responsability = false;

        }
        public void changeLendingDays()
        {
            if(isResponsable() == true)
            {
                LendingDays ++;
            }
        }
        public override bool canLend()
        {
            if(Responsability == true)// si sabemos que no es responsable no tiene sentido analizar
            {
                
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