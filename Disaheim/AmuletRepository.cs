using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> _amulet = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            _amulet.Add(amulet);

        }


        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet = null;
            foreach (Amulet a in _amulet)
            {
                if (a.ItemId == itemId)
                {
                    amulet = a;
                    break;
                }
            }
            return amulet;
        }

        public double GetTotalValue()
        { 
        Utility utility = new Utility();
            double total = 0.0;
            foreach (Amulet amulet in _amulet)
            {
                total += utility.GetValueOfAmulet(amulet);
            }

            return total;

        }


    }
}
