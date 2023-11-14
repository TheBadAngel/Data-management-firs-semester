using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }

        public int DurationInMinutes { get; set; }


        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public Course(string name) : this(name, 0)
        {
        
        }



        public static double CourseHourValue = 875.0;
    
        public double GetValue()
        {
            double result = 0;
            int remainder = DurationInMinutes % 60;

            if (remainder > 0)
            {
                result = (DurationInMinutes / 60 + 1) * CourseHourValue;
            }
            else if (remainder == 0)
            {
                result = DurationInMinutes / 60 * CourseHourValue;
            }

            return result;
        }

        public override string ToString() 
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
       

    }
}
