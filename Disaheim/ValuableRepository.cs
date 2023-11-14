using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> _valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            _valuables.Add(valuable);
        }


        public IValuable GetValuable(string id)
        {
            foreach (IValuable v in _valuables)
            {
                if (v is Merchandise merch && merch.ItemId == id)
                {
                    return merch;
                }

                else if (v is Course course && course.Name == id)
                {
                    return course;
                }
            }
            return null;

        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (IValuable v in _valuables)
            {
                if (v is Merchandise merch)
                {
                    total += merch.GetValue();
                }
                else if (v is Course course)
                {
                    total += course.GetValue();
                }
            }
            return total;
        }

        public int Count()
        {
            return _valuables.Count;
        }


    }
}
