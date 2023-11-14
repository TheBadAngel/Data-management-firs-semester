using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> _valuables;
        public List<IValuable> valuables { get { return _valuables; } set { _valuables = value; } }

        public AddValuable(IValuable valuable);

        public IValuable GetValuable(string id);

        public double GetTotalValue();

        public int Count();


    }
}
