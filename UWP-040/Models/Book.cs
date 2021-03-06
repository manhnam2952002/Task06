using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_040.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vupate", Author = "Futurum", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "Mazin", Author = "Sequiter", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/1.jpg" });

            return books;
        }
    }
}
