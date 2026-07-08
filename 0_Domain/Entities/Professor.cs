namespace GestionBiblioteca.Domain.Entities
{
    public class Professor : Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
        public int QuantityBooksLending { get; private set; }
        public string Subject { get; private set; }

        public Professor()
        {
            
        }

        public Professor(int p_dni, string p_name, string p_subject)
        {
            // Constructor simple sin historial de préstamos
            setDNI(p_dni);
            setName(p_name);
            setSubject(p_subject);
        }

        public Professor(int p_dni, string p_name, List<Loan> p_aLoan, string p_subject, int p_days)
        {
            // Constructor con historial de préstamos para crear casos de prueba a mano
            Dni = p_dni;
            Name = p_name;
            Subject = p_subject;
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

        public void setSubject(string p_subject)
        {
            if (!string.IsNullOrWhiteSpace(p_subject))
            {
                Subject = p_subject;
            }
            else
            {
                throw new ArgumentException("El asunto no puede estar vacío.");
            }
        }
    }
}