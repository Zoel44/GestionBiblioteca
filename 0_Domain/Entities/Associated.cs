namespace GestionBiblioteca.Domain.Entities
{
    public abstract class Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public List<Loan> Loans { get; private set; }
        public int QuantityBooksLending { get; private set; }

        public Associated()
        {
            
        }
        public Associated(int p_dni, string p_name)
        {
            //constructor sin historial de prestamos
            setDNI (p_dni);
            setName(p_name);
            Loans = new List<Loan>();
            QuantityBooksLending = 0;
        }
        public Associated(int p_dni, string p_name,List<Loan> p_aLoan, int p_days)
        {
            //constructor con historial de prestamos para crear casos de prueba a mano
            Dni = p_dni;
            Name = p_name;
            Loans = p_aLoan;
            QuantityBooksLending = p_days;
        }
   
        public abstract string typeOfAssociated();
        public bool canLend()
        {   
            if(QuantityBooksLending > 3)
            {//si tiene mas de 2 libros no puede pedir prestado, así que tampoco hace falta ver si tiene prestamos vencidos
                foreach (Loan aLoan in Loans)
                {
                    if (aLoan.expired(aLoan.RetirementDate.AddDays(7)))
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
        public void setName(string p_name)
        {
            if (!string.IsNullOrWhiteSpace(p_name))
            {
                Name = p_name;
            }
            else
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
        public void setDNI(int p_dni)
        {
            // Validar que sea un número positivo de exactamente 8 dígitos
            // Rango válido: 10,000,000 a 99,999,999
            if(p_dni > 0)
            {
                Dni = p_dni;
            }
            else
            {
                throw new ArgumentException("El DNI debe ser un número de 8 dígitos (ej: 38456789). Recibido: " + p_dni);
            }
        }

    }
}