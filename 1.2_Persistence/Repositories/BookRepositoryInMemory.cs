using GestionBiblioteca.Domain.Interfaces;
using GestionBiblioteca.Domain.Entities;

namespace GestionBiblioteca.Persistence.Repositores
{
    public class BookRepositoryInMemowy : IRepositoryBooks
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
        public void updateBook(Book book)
        {
            
        }

        public void deleteBook(int id)
        {
            
        }
    }
}