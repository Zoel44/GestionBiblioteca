using GestionBiblioteca.Domain.Entities;

public static class TestBiblioteca
{
    public static void Ejecutar()
    {
        Library testBiblio = new Library("Don Carlitos");

        testBiblio.newProfessor();
        testBiblio.newStudent();
        testBiblio.newBook();
        testBiblio.newBook();

        Console.WriteLine(testBiblio.responsableProfessorsList());
        Console.WriteLine(testBiblio.AssociatedsList());
        Console.WriteLine(testBiblio.listTitles());
        
    }
}