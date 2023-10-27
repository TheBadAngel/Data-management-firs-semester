using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string _itemId;
        public string ItemId { get { return _itemId; } set { _itemId = value; } }
        private string _design;
        public string Design { get { return _design; } set { _design = value; } }
        private Level _quality;
        public Level Quality { get { return _quality; } set { _quality = value; } }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet (string itemId, Level quality) : this(itemId, quality, "")
        {
        }

        public Amulet (string itemId) : this(itemId, Level.medium)
        {
        }


        public override string ToString ()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }


    }
}
