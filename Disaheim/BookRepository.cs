using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>();


        public void AddBook (Book book)
        {
            _books.Add(book);
        }



        public Book GetBook(string itemId)
        {

            Book book = null; 
            foreach (Book b in _books)
            {
                if (b.ItemId == itemId)
                {
                    book = b;
                    break;
                }
            }
            return book;

        }

        public double GetTotalValue()
        {
            Utility utility=new Utility();
            double total = 0.0;

            foreach (Book book in _books)
            {
                total += utility.GetValueOfMerchandise(book);
            }

            return total;
        }



    }
}
