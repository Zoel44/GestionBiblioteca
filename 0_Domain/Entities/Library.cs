namespace GestionBiblioteca.Domain.Entities
{
    public class Library
    {
        public string Name { get; private set;}
        public List<Associated> Associateds { get; private set;}
        public List<Book> Books { get; private set;}
        public int IDCounter {get; private set; }

        public Library(string p_name)
        {
            Name = p_name;
            Associateds = new List<Associated>();
            Books = new List<Book>();
            IDCounter = 0;
        }
        public void newBook()
        {
            //habrìa que agregar algo que asegure que no se envíen valores incorrectos / vacíos
           bool A = false;
           int p_year = 0; int p_edition = 0;

            Console.Write ("Ingrese el Título del libro: ");
            string? p_title = Console.ReadLine();

            Console.Write ("Ingrese el Autor: ");
            string? p_author = Console.ReadLine();

            Console.Write ("Ingrese la editorial: ");
            string? p_editorial = Console.ReadLine();

            Console.Write("Ingrese el año de publicación: "); 
            while (A == false){
    
                if (int.TryParse(Console.ReadLine(), out int i_year)) //esto intenta convertir el string en int y luego guardarlo, si puede da true
                { 
                    p_year = i_year;
                    A = true;
                } 
                else 
                {
                    Console.WriteLine("Valor inválido, intentelo de nuevo"); 
                }
            }

            Console.Write ("Ingrese el número de edición: ");
            A = false;
            while (A == false)
            {
                if(int.TryParse(Console.ReadLine(), out int i_edition))
                {
                    p_edition = i_edition;
                    A = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido, intentelo de nuevo");
                }
            }
            
            IDCounter ++;
            Book ABook = new Book(p_title, p_author, p_editorial, p_year, p_edition, IDCounter); //el new se puede simpificara Book.Book, pero asì se entiende mejor al leer
            Books.Add(ABook);
        }
        public void newStudent()
        {
            //habrìa que agregar algo que asegure que no se envíen valores incorrectos / vacíos
            int p_dni = 0; 
            string? p_name; string? p_degree;
            bool A = false;

            Console.Write("Ingrese el DNI del estudiante: ");
            while (A == false)
            {
                if(int.TryParse(Console.ReadLine(), out int i_dni))
                {
                    p_dni = i_dni;
                    A = true;
                }
                else
                {
                    Console.WriteLine("Valor ingresado es inválido");

                }

            }

            Console.Write("Ingrese el nombre del alumno: ");
            p_name  = Console.ReadLine();

            Console.Write("Ingrese la carrera del alumno: ");
            p_degree = Console.ReadLine();

            Student AStudent = new Student(p_dni, p_name, p_degree);
        }
        public void newProfessor()
        {
            //habrìa que agregar algo que asegure que no se envíen valores incorrectos / vacíos
            int p_dni = 0; 
            string? p_name; string? p_subject;
            bool A = false;

            Console.Write("Ingrese el DNI del profesor: ");
            while (A == false)
            {
                if(int.TryParse(Console.ReadLine(), out int i_dni))
                {
                    p_dni = i_dni;
                    A = true;
                }
                else
                {
                    Console.WriteLine("Valor ingresado es inválido");

                }

            }

            Console.Write("Ingrese el nombre del profesor: ");
            p_name  = Console.ReadLine();

            Console.Write("Ingrese la materia del profesor: ");
            p_subject = Console.ReadLine();

            Professor AProfessor = new Professor(p_dni, p_name, p_subject);  
        }
        public void lendBook(Associated p_associated, Book p_book)
        {//Crea el préstamo, y lo agrega en el libro y el socio.
            string newID = $"{DateTime.Now.ToString("yyyyMMddhhmmss")+p_associated.Dni.ToString()}";
            Loan a_loan = new Loan(DateTime.Now, newID, p_associated, p_book);

            //acá habría que comprobar que se encuentren tanto el asociado cómo el libro antes de agregar el préstamo

            foreach (Associated assoc in Associateds)
            {
                if (assoc.Dni == p_associated.Dni)
                {
                    assoc.Loans.Add(a_loan);
                }
            }

            foreach (Book book in Books)
            {
                if(book.BookID == p_book.BookID)
                {
                    book.Loans.Add(a_loan);
                }
            }

            Console.WriteLine("Se ha agendado el préstamo correctamente. . . tal vez");
        }
        public void returnBook(int  ID_book)
        {
            foreach(Book book in Books)
            {
                if (book.BookID == ID_book)
                {
                    book.Loans[^1].registerDateOfReturn(DateTime.Now);
                }
            }
        }
        public void quantityAssocciatedsForType()
        {
            int prf_counter = 0; int st_counter = 0; 

            foreach(Associated associated in Associateds)
            {
                if(associated.typeOfAssociated().Equals("Student"))
                {
                    st_counter ++;
                }
                else if (associated.typeOfAssociated().Equals("Professor"))
                {
                    prf_counter ++;
                }
            }

            Console.WriteLine("Hay "+st_counter+" estudiantes y "+prf_counter+" profesores asociados");
        }
        public List<Associated> responsableProfessors()
        {
            List<Associated> responsables = new List<Associated>();
            foreach(Associated associated in Associateds)
            {
                if(associated.typeOfAssociated().Equals("Professor"))
                {
                    responsables.Add(associated);
                }
                
            }
            return responsables;
        }
        public string responsableProfessorsList()
        {
            string lista = "";
            foreach(Associated prof in responsableProfessors())
            {
                lista = lista + prof.Name+ "\n"; 
            }
            return lista;
        }
        public string whoHaveTheBook(int id_book)
        {
            foreach (Associated associated in Associateds)
            {
                foreach(Loan loan in associated.Loans)
                {
                    if(loan.ABook.BookID == id_book)
                    return associated.Name+" "+associated.Dni;
                }
            }
            return "No encontrado";
        }
        public string AssociatedsList()
        {
            string lista = "";
            foreach (Associated associated in Associateds)
            {
                lista = lista + associated.Name + "\n";
            }
            return lista;
        }
        public Associated? searchAssociated(int p_dni)
        {
            foreach (Associated associated in Associateds)
            {
                if(associated.Dni == p_dni)
                {
                    return associated;    
                }
            }
            return null;
        }
        public string listTitles()
        {
            string lista = "";
            foreach(Book book in Books)
            {
                lista = lista + book.Title + "\n";
            }
            return lista;
        }

    }
}