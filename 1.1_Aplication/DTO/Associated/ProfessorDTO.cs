using GestionBiblioteca.Domain.Entities; //para que reconozcan las clases de atributo declarados en Dominio, en este caso Loan
namespace GestionBiblioteca.Aplication.DTO
{
    public class ProfessorDTO
    {//esta clase se usa para devolver el resultado
        public int Dni { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<Loan> Loans { get; set; }
        public int QuantityBooksLending { get; set; }
    }
}
  