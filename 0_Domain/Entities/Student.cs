namespace GestionBiblioteca.Domain.Entities
{
    public class Student : Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public List<Loan> Loans { get; private set; }
        public int QuantityBooksLending { get; private set; }
        public string Degree { get; private set; }

        public Student()
        {
            
        }

        public Student(int p_dni, string p_name, string p_degree)
        {
            // Constructor simple sin historial de préstamos
            setDNI(p_dni);
            setName(p_name);
            setDegree(p_degree);
            Loans = new List<Loan>();
            QuantityBooksLending = 0;
        }

        public Student(int p_dni, string p_name, List<Loan> p_aLoan, string p_degree, int p_days)
        {
            // Constructor con historial de préstamos para crear casos de prueba a mano
            Dni = p_dni;
            Name = p_name;
            Loans = p_aLoan;
            QuantityBooksLending = p_days;
            Degree = p_degree;
        }

        public string typeOfAssociated()
        {
            return "Student";
        }

        public bool canLend()
        {   
            if(QuantityBooksLending > 3)
            {
                // Si tiene más de 3 libros no puede pedir prestado
                foreach (Loan aLoan in Loans)
                {
                    if (aLoan.expired(aLoan.RetirementDate.AddDays(7)))
                    {
                        // Preguntamos si el préstamo está vencido
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
            if(p_dni > 0)
            {
                Dni = p_dni;
            }
            else
            {
                throw new ArgumentException("El DNI debe ser un número positivo. Recibido: " + p_dni);
            }
        }

        public void setDegree(string p_degree)
        {
            if (!string.IsNullOrWhiteSpace(p_degree))
            {
                Degree = p_degree;
            }
            else
            {
                throw new ArgumentException("La carrera no puede estar vacía.");
            }
        }
    }
}