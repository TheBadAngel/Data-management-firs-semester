using System.Security.Claims;

namespace Datahåndtering
{
    internal class Program
    {
        class person
        {
            public int age; //int er heltal
            public string firstname; //string er tekst
            public string lastname; //string er tekst
            public bool glasses; // bool er true eller false
            public float weight; // Float er decimaltal
            private int cprnumber;

            // public kan ander se og private er skjult


        }


        class car
        {
            public string wheels;
            public int doors;
            public string engine;
            private string platenumber;
            public bool windows;

        }



        class product
        {
            public string name;



        }





    static void Main(string[] args)
    {
        Console.ReadLine();
    }
}
}