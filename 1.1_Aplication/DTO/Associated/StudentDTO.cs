using GestionBiblioteca.Domain.Entities;
namespace GestionBiblioteca.Aplication.DTO
{
    public class StudentDTO
    {//esta clase se usa para devolver el resultado
        public int Dni { get;   set; }
        public string Name { get;   set; }
        public string Degree { get;   set; }
        public List<Loan> Loans { get;   set; }
        public int QuantityBooksLending { get;   set; }
    }
}
  