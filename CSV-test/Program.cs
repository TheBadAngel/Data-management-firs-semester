using System.Data;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CSV_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indput Id, Fornavn og Efternavn.");
            Employee[] Medarbejder =
            {
             new Employee(
                 int.Parse(Console.ReadLine()),//ID number
                 Console.ReadLine(), // First Name
                 Console.ReadLine()) //Last Name
            };

            String file = "medarbejder.csv";
            String separator = ",";
            StringBuilder medarbejder = new StringBuilder();
            String[] headings = { "Medarbejder Id", "First Name", "Last Name" };
            medarbejder.Append(string.Join(separator, headings));


            foreach (Employee employee in Medarbejder)
            {
                String[] newLine = { employee.Id.ToString(), employee.FirstName, employee.LastName };
                medarbejder.Append(string.Join(separator, newLine));
            }

            try
            {
                File.AppendAllText(file, medarbejder.ToString());

            }
            catch
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }

            Console.WriteLine("The data has been successfully saved to the CSV file.");








            Console.ReadLine();
        }

    }

}
