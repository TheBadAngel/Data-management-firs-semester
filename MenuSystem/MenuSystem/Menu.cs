using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    internal class Menu
    {
        public string Title = "Min fantastiske menu";
        private menuItem[] MenuItems;
        private int itemCount = 0;
       
        public void Show()
        {

            Console.WriteLine(Title + "\n");

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(MenuItems[i].Title);
            }

            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }


    }
}
