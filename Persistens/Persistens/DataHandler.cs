using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }

        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;

        }
        



    }
}
