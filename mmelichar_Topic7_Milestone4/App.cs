using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmelichar_Topic7_Milestone4
{
    public class App
    {
        Inventory inventory = new Inventory();
        List<Inventory> items = new List<Inventory>();

        public List<Inventory> getList()
        {
            return items;
        }
        public Inventory getInventory()
        {
            return inventory;
        }

        public App()
        {

        }
        public void addItem(Inventory item)
        {
            //if null, create list
            if (items == null)
            {
                items = new List<Inventory>();
            }
            items.Add(item);
        }
        public void removeItem (int idx)
        {
            //remove by index
            items.RemoveAt(idx); 
        }
        public void removeItem(Inventory item)
        {
            //remove by item object
            items.Remove(item);                                          
        }
            

        public void restockItem(int sku, int _quantity)
        {
            inventory.setQuantity(inventory.getQuantity() + _quantity);
            
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].getSku() == sku)
                {
                    items[i].setQuantity(items[i].getQuantity() + _quantity);
                    return;
                }
            }
            
        }
        public void displayInventory()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public Inventory search(int sku, string description)
        {
            //scan every item
            foreach (var item in items)
            {
                //if sku + description match, return item
                if (item.getSku() == sku && item.getDescription() == description)
                {
                    return item;
                }
            }
            //if item not contained in list, return null
            return null;
        }
    }
}
