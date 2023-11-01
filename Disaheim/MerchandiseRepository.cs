using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {

        private List<Merchandise> _merchandise = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            _merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merchandise = null;
            foreach (var m in _merchandise)
            {
                if (m.ItemId == itemId)
                {
                    merchandise = m;
                    break;
                }

            }
            return merchandise;

        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double total = 0.0;
            foreach (Merchandise merchandise in _merchandise)
            {
                total += utility.GetValueOfMerchandise(merchandise);
            }
            return total;

        }


    }
}
