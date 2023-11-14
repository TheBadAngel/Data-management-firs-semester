using System.Reflection.Emit;
//using Disaheim;

namespace Disaheim
{
    public class Utility
    {
        private double _LowQualityValue = 12.5;
        public double LowQualityValue
        {

            get { return _LowQualityValue; }
            set { _LowQualityValue = value; }

        }

        private double _mediumQualityValue = 20.00;
        public double MediumQualityValue
        {
            get { return _mediumQualityValue; }
            set { _mediumQualityValue = value; }
        }


        private double _highQualityValue = 27.5;
        public double HighQualityValue
        {
            get { return _highQualityValue; }
            set { _highQualityValue = value; }
        }

        private double _courseHourValue = 875;
        public double CourseHourValue
        {
            get { return _courseHourValue; }
            set { _courseHourValue = value; }
        }




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
                        return _LowQualityValue;

                    case Level.medium:
                        return _mediumQualityValue;

                    case Level.high:
                        return _highQualityValue;

                    default:
                        return 0.0; //in case neither low, medium or high exists.
                }
            }





        }

        public double GetValueOfCourse(Course course)
        {
            double result = 0;
            int remainder = course.DurationInMinutes % 60;

            if (remainder > 0)
            {
                result = (course.DurationInMinutes / 60 + 1) * _courseHourValue;
            }
            else if (remainder == 0)
            {
                result = course.DurationInMinutes / 60 * _courseHourValue;
            }

            return result;


        }

    }

}