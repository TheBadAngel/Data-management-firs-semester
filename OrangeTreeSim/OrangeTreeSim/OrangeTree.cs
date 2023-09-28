using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {

        private int age; /* Angiver træets alder*/
        public int Age
        {
            get 
            {
                return age;
            }
            set
            {
                if (value > 0)
                { age = value; }
                else 
                { age = 0; }
            }
        }

        private int height; /* Angiver træts højde*/
        public int Height
        {
            get;set;   
        }

        private bool treeAlive; /* Sandt eller falsk, om træet er i live*/
        public bool TreeAlive
        {
            get { return treeAlive;}
            set { treeAlive = value;}
        }

        private int numOranges; /* Antal af apelsiner der er på træet*/
        public int NumOranges
        {
            get { return numOranges;}
        }

        private int orangesEaten; /* Antal spidste apelsiner fra træet*/
        public int OrangesEaten
        {
            get { return orangesEaten; }
        }
     

        /*  Træets alder øges med 1 (age-feltet)
            Træet højde øges med 2, hvis træets alder er under 80, ellers ikke (height-feltet)
            Træet er i live, hvis træets alder er under 80, ellers dødt (treeAlive)
            Træet giver ikke frugt første år, men derefter øges dets produktion med 5 appelsiner for hvert år 
            (dvs. 5 appelsiner 2. år, 10 appelsiner det 3. år, 15 appelsiner det 4. år osv.). 
            Frugt fra forrige år føres ikke med over til et nyt år (numOranges-feltet)
        */
        public void OneYearPasses()
        {
            numOranges = 0;
            orangesEaten = 0;
            age++;
            if (age < 80)
            {
                Height += 2;
                TreeAlive = true;
                if (age > 1)
                {
                    numOranges += 5 * (age - 1);

                }
            }
            else
            {
                TreeAlive = false;
            }
        }
        public void EatOrange(int count)
        {
            if (count < numOranges)
            {
                orangesEaten += count;
                numOranges = numOranges - count;
            }
            else
            {
                orangesEaten = 0;
            }

        }
    }
}
