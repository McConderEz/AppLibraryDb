using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibraryAppCore
{
    public class Book
    {
        public int Id { get; set; }
        public int PagesCount { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } = "Отсутствует";
        public string? Author { get; set; }
        public string? Genre { get; set; }

        public Book() { }
        
    }
}
