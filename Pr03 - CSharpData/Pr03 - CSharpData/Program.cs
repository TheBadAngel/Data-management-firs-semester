using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Pr03___CSharpData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lommeregner");

            
            
            //Beregn arealet af en rektangel a=l*b.
            Console.WriteLine("Beregn areal af en rektangel.");
            Console.WriteLine("Indsæt højde: ");

            double height= double.Parse(Console.ReadLine());
            Console.WriteLine("Indsæt bredde: ");
            double width= double.Parse(Console.ReadLine());

            Console.WriteLine("Arealet er: " + (height * width) + "\n");
            


            //Beregning af hældning med (x1,y1) og (x2,y2).
            Console.WriteLine("Beregning af hældning.");
            Console.WriteLine("Indtast x1 og y1 parameter: ");
            Console.WriteLine("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast x2 og y2 parameter: ");
            Console.WriteLine("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultat: " + (y2 - y1) / (x2 - x1) + "\n");

            
            
            //Tæller længden af en sætning.
            Console.WriteLine("Skriv en tekst og få talt antal tegn: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("Antal af tegn i din tekst er: " + tekst.Length + "\n");



            //Udtræk af substring af en tekst.







            //Find et bogstav i en tekst og udskriv UNIcode.
            string streng = "Hej med dig, Karsten";
            Console.WriteLine(streng);
            Console.Write("Indtast bogstav for at finde UNIcode: ");
            char bogstav = char.Parse(Console.ReadLine());

            if (streng.Contains(bogstav))
                Console.WriteLine(streng.IndexOf(bogstav));

            else
                Console.WriteLine("Denne karakter eksiterer ikke i teksten. \n");



            Console.ReadLine();
        }
    }
}