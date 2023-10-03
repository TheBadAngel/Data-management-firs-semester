using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSV_test
{
    public class Employee
    {

        public int Id;
        public string FirstName;
        public string LastName;


        public Employee(int Id, string FirstName, string LastName)
        {

            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }



    }


}

