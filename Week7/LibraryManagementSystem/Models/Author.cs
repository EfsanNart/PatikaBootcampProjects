using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Author(int authorId, string name, string surname)
        {
            AuthorId = authorId;
            Name = name;
            Surname = surname;
        }
    }
}
