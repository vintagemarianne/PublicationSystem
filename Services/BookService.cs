using PublicationSystem.Models;

namespace PublicationSystem.Services
{
    public class BookService
    {
        public Book[] GetBooks()
        {
            return new[]
            {
                new Book { Id = 1, Name= "Book1"},
                new Book { Id = 2, Name = "Book2"}
            };
        }
    }
}
