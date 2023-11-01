using System.Reflection.Emit;
//using Disaheim;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfMerchandise(Merchandise merchandise)
        {

            if (merchandise is Book)
            {
                Book book = (Book)merchandise;

                return book.Price;
            }

            else
            {
                Amulet amulet = (Amulet)merchandise;


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
                return amulet.Quality;
            }


            */


        }

        public double GetValueOfCourse(Course course)
        {
            double result = 0;
            int hourePrice = 875;
            int remainder = course.DurationInMinutes % 60;

            if (remainder > 0)
            {
                result = (course.DurationInMinutes / 60 + 1) * hourePrice;
            }
            else if (remainder == 0)
            {
                result = course.DurationInMinutes / 60 * hourePrice;
            }

            return result;


        }

    }

}