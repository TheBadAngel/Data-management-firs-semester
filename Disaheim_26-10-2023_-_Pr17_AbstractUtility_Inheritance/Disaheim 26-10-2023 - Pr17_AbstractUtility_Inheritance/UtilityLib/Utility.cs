using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook (Book book)
        {
            double bookValue = 0;
            if (book != null)
            {
                bookValue = book.Price;
            }

            return bookValue;
        }

        public double GetValueOfAmulet (Amulet amulet)
        {
            double amuletValue = 0;
            if (amulet != null)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        amuletValue = 12.5;
                        break;
                    case Level.medium:
                        amuletValue = 20.0;
                        break;
                    case Level.high:
                        amuletValue = 27.5;
                        break;
                }
            }
            return amuletValue;
        }

        public double GetValueOfCourse (Course course)
        {
            // Leif's version:
            //int hoursStarted = course.DurationInMinutes / 60;
            //bool anyMinutes = course.DurationInMinutes % 60 != 0;
            //return anyMinutes ? (hoursStarted + 1) * 875 : hoursStarted * 875; // ternary operator
            // ---------------

            //int excess = course.DurationInMinutes % 60;
            //int actual = course.DurationInMinutes - excess;

            // Rasmus' Method ---------------------------------------
            //Double result = 0;
            //int remainder = course.DurationInMinutes % 60;

            //if (remainder > 0)
            //{
            //    result = (course.DurationInMinutes / 60 + 1) * 875;
            //} else if (remainder == 0)
            //{
            //    result = course.DurationInMinutes / 60 * 875;
            //}
            //return result;
            // ------------------------------------------------------


            // Own method -------------------------------------------
            int hours = 0;
            int minutes = 0;
            int remaining = course.DurationInMinutes;
            while (remaining > 0)
            {
                minutes += 1;
                remaining -= 1;
                if (minutes == 60)
                {
                    hours += 1;
                    minutes = 0;
                }
            }

            // Add the most-recently started hour for billing as well
            if (minutes > 0)
            {
                hours += 1;
            }

            double valuePerHour = 875.00;
            return hours * valuePerHour;
            // ------------------------------------------------------
        }
    }
}
