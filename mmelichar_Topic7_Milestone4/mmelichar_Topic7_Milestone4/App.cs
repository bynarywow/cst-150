using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmelichar_Topic7_Milestone4
{
    public class App
    {
        //array declaration no longer in use, don't need size/cap variables either
        //Inventory[] inventory = new Inventory[10];
        //int capacity = 10;
        //int size = 0;
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
        /*
         * helper function for exclusively arrays
        public int getSize()
        {
            return size;
        }
        */
        public App()
        {
            /*
             * dummy data for my array
            inventory[0] = new Inventory(00001, 25, "Lego Darth Vader Bust", 59.99);
            inventory[1] = new Inventory(00002, 10, "Cool Ranch Doritos", 6.99);
            inventory[2] = new Inventory(00003, 15, "Campbells Chicken Noodle Soup", 3.99);
            size = 3;
            */
        }
        public void addItem(Inventory item)
        {
            if (items == null)
            {
                items = new List<Inventory>();
            }
            items.Add(item);
            
            
            /*
             * array, no longer in use
            if (inventory.Length >= capacity)
            {
                capacity *= 2;
                Inventory[] temp = new Inventory[capacity];
                int i = 0;
                foreach (var inv in inventory)
                {
                    temp[i] = inventory[i];
                    i++;
                }

                inventory = temp;
            }

            inventory[size] = item;
            ++size;
            return;
            */
        }
        public void removeItem (int idx)
        {
            items.RemoveAt(idx); 
        }
        public void removeItem(Inventory item)
        {

            items.Remove(item);
                            //            items.Remove(item);
            /*
            int index = Array.IndexOf(inventory, item);
            if (index != -1)
            {
                if (index != inventory.Length - 1)
                {
                    for (int i = index; i < size; i++)
                    {
                        inventory[i] = inventory[i + 1];
                    }
                }
                else if (index == inventory.Length - 1)
                {
                    inventory[index] = null;
                }
            }
            else
            {
                MessageBox.Show("Result not found.");
            }
            */                                          
        }
            /*
            List<Inventory> tmp = new List<Inventory>(inventory);
            tmp.RemoveAt(index);
            inventory = tmp.ToArray();
            */

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
            //what needs to happen: Pass in an array of inventory items to search.
            //Find all instances of the sku and the description individually, then
            //compare the two lists of indexes to see if they are the same indexes.
            //Only return the ones that are the same indexes.

            foreach (var item in items)
            {
                if (item.getSku() == sku && item.getDescription() == description)
                {
                    return item;
                }
            }
            return null;
            //  Inventory item = new Inventory();
            //  int[] skuIndex = inventory.Select((b, i) => b == sku ? i : -1).Where(i => i != -1).ToArray();
            //int[] descIndex = Array.IndexOf(this.inventoryArray, description);
            //if (index == nextIndex)
            //{
            //item = inventoryArray.ElementAt(index);
            //}
            //return item;
        }
    }
}
