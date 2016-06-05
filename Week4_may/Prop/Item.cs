using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop
{
    class Item
    {
        private int ItemID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int GetID() { return this.ItemID; }

        public Item(int cItemID, string cDEescription, int cPrice, int cQuantity)
        {
            this.ItemID = cItemID;
            this.Description = cDEescription;
            this.Price = cPrice;
            this.Quantity = cQuantity;
        }
        public string GetItemInfo()
        {
            return "ItemID:" + this.ItemID +
            "     Descdription:" + this.Description +
            "     Price:" + this.Price +
            "     Quantity:" + this.Quantity;
        }
    }
}
