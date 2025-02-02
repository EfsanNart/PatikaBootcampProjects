using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Book(int bookId, string title, int authorId)
        {
            BookId = bookId;
            Title = title;
            AuthorId = authorId;
        }
    }
}
