using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {

       // public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId, string title, double price) : this(itemId, title)
        {
            Price = price;
        }


        public Book(string itemId, string title) : this(itemId)
        {
            Title = title;
        }

        public Book(string itemId) : base(itemId)
        {
            ItemId = itemId;
        }

        public override string ToString()
        {
            return $"ItemId: Title: {Title}, Price: {Price}";
        }



    }
}
