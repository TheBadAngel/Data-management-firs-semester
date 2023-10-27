using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private List<Book> books;
        public List<Book> Books { get; set; }

        private List<Amulet> amulets;
        public List<Amulet> Amulets { get; set; }

        
        public Controller() 
        { 
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            
        }

        public void AddToList(Book book) 
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
