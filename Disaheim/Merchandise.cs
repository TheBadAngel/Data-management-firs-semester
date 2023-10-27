using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {
        private string itemId;
        public string ItemId { get; set; }

        public Merchandise (string itemId) {  this.itemId = itemId; }

        public override string ToString()
        {
            return $"ItemId: {itemId}";
        }


    }
}
