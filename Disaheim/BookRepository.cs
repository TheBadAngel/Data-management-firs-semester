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



        public string GetBook(Book book)
        {

          
            if (_books.Contains(itemId))
            {
                return book.ItemId;
            }
            return;


        }

        public double GetTotalValue(Book book)
        {
            return book.Price;
        }



    }
}
