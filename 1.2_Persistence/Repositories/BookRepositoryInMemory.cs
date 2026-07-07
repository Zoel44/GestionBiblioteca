using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;
using GestionBiblioteca.Aplication.DTO;

namespace GestionBiblioteca.Persistence.Repositores
{
    public class BookRepositoryInMemory : IRepositoryBooks
    {
        private static readonly List<Book> BookList = new List<Book>();
        public void addBook(Book p_book)
        {
            BookList.Add(p_book);
        }
        public Book? searchBookForID(int p_id)
        {
            foreach(Book book in BookList)
            {
                if(book.BookID == p_id)
                {
                    return book;
                }
            }
            return null;
        }
        public void updateBook(BookDTO p_book, int p_id)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if(BookList[i].BookID == p_id)
                {   
                    if(p_book.Author != null)
                    {
                        BookList[i].setAuthor(p_book.Author);
                    }
                    if(p_book.Title != null)
                    {
                        BookList[i].setTitle(p_book.Title);
                    }
                    if(p_book.Editorial != null)
                    {
                        BookList[i].setEditorial(p_book.Editorial);
                    }
                    if(p_book.Year != null)
                    {
                        BookList[i].setYear(p_book.Year.Value);
                    }
                    if(p_book.Year != null)
                    {
                        BookList[i].setYear(p_book.Year.Value);
                        break;
                    }
                }
                
            }
            
        }

        public void deleteBook(int p_id)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if(BookList[i].BookID == p_id)
                {
                    BookList.RemoveAt(i);
                    break;
                }
            }
        }
    }
}