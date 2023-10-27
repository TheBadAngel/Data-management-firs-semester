using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            Level Quality = amulet.Quality; //Assumes amulet has a Quality value

            switch (Quality)
            {
                case Level.low:
                    return 12.5;

                case Level.medium:
                    return 20.0;

                case Level.high:
                    return 27.5;

                default:
                    return 0.0; //in case neither low, medium or high exists.
            }
        }



    }
}
