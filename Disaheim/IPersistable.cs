using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Disaheim
{
    internal interface IPersistable
    {


        void Save()
        {
            StreamWriter valuableRepository = new StreamWriter("C:\\valuableRepository.txt");
            valuableRepository.WriteLine();
            valuableRepository.Close();
        }


        void Save(string valuableRepository)
        {

        }

        void Load()
        {
            string line;
            StreamReader valuableRepository = new StreamReader("C:\\valuableRepository.txt");
            line = valuableRepository.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = valuableRepository.ReadLine();
            }
            valuableRepository.Close ();
            Console.ReadLine();
        }


        void Load(string valuableRepository)
        {

        }






    }
}
