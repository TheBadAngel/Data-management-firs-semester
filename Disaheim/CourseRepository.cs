using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> _course = new List<Course>();

        public void AddCourse(Course course)
        {
            _course.Add(course);
        }

        public Course GetCourse(string name)
        {

            Course course = null;
            foreach (var c in _course)
            {
                if (c.Name == name)
                {
                    course = c;
                    break;
                }
            }
            return course;

        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double total = 0.0;
            foreach (Course course in _course)
            {
                total += utility.GetValueOfCourse(course);
            }
            return total;

        }


    }
}
