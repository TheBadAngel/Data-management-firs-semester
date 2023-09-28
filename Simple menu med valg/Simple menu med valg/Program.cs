namespace Simple_menu_med_valg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min fantastiske menu:");
            string a = "1. Gør dit";
            string b = "2. Gør dat";
            string c = "3. Gør noget";
            string d = "4. Få svaret på livet, universet og alting";

            string choice = Console.ReadLine();
            int choisevalue = int.Parse(choice);

            string message = "";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Tryk menupunkt 1, 2, 3 eller 4");


            if (choisevalue == 1)
                message = a;
            else if (choisevalue == 2)
                message = b;
            else if (choisevalue == 3)
                message = c;
            else if (choisevalue == 4)
                message = d;

            Console.WriteLine($"({a})Dette her er beskeden {message}{a}{b}{c}{d}"); // string interpolation
            Console.WriteLine("{0}Dette her er beskeden: {1}{2}{3}{4}{5}", a, message, a, b, c, d);
            Console.WriteLine("(" + a + ")Dette her er beskeden " + message + a + b + c + d); //concatination





            Console.ReadLine();
        }
    }
}