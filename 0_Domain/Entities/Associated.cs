namespace GestionBiblioteca.Domain.Entities
{
    public abstract class Associated
    {
        public int Dni { get; private set; }
        public string Name { get; private set; }
    }
}