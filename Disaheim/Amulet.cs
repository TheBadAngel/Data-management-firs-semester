using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
       // private string itemId;
        //public string ItemId { get; set; }

        private string design;
        public string Design { get; set; }

        private Level quality = Level.medium;
        public Level Quality { get; set; }
        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            this.design = design;
        }

        public Amulet(string itemId, Level quality) : this(itemId)
        {
            this.quality = quality;
        }

        public Amulet(string itemId) : base(itemId)
        {
            ItemId = itemId;

        }


        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }



    }
}
