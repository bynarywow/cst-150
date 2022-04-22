
public class App
{
    Inventory[] inventory = new Inventory[10];
    int capacity = 10;
    int size = 0;
    static void Main(string[] args)
    {
        App app = new App();
        app.start();
    }
    public Inventory[] getInventory()
    {
        return inventory;
    }
    public void start()
    {
        inventory[0] = new Inventory(00001, 25, "Lego Darth Vader Bust", 59.99);

        inventory[1] = new Inventory(00002, 10, "Cool Ranch Doritos", 6.99);
        inventory[2] = new Inventory(00003, 15, "Campbells Chicken Noodle Soup", 3.99);
    }
    public void addItem(Inventory item)
    {
        if(inventory.Length>=capacity)
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
    }
    public void removeItem( Inventory item)
    {
        int index = Array.IndexOf(inventory, item);
        for (int i=index;i<size;i++)
        {
            inventory[i] = inventory[i + 1];
        }
        /*
        List<Inventory> tmp = new List<Inventory>(inventory);
        tmp.RemoveAt(index);
        inventory = tmp.ToArray();
        */
    }
    public void restockItem(int sku, int _quantity)
    {
        for (int i = 0; i < size; i++)
        {
            if(inventory[i].getSku()==sku)
            {
                inventory[i].setQuantity(inventory[i].getQuantity() + _quantity);
                return;
            }
        }
    }
    public void displayInventory()
    {
        foreach (var item in inventory)
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

        foreach (var item in inventory)
        {
            if(item.getSku()==sku && item.getDescription()==description)
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
public class Inventory
{
    int sku;
    int quantity;
    string description;
    double price;
   
    public Inventory(int _sku, int _quantity, string _description, double _price)
    {
        sku = _sku;
        quantity = _quantity;
        description = _description;
        price = _price;
    }
    public Inventory()
    {
        sku = 0;
        quantity = 0;
        description = "Item not found.";
        price = 0;
    }
    
    public override string ToString()
    {
        return string.Format("Sku: {0}, Quantity: {1}, Description: {2}, Price: {3}", sku, quantity, description, price);
    }
    public int getSku()
    {
        return sku;
    }
    public int getQuantity()
    {
        return quantity;
    }
    public string getDescription()
    {
        return description;
    }
    public double getPrice()
    {
        return price;
    }
    public void setSku(int _sku)
    {
        sku = _sku;
    }
    public void setQuantity(int _quantity)
    {
        quantity = _quantity;
    }
    public void setDescription(string _description)
    {
        description = _description;
    }
    public void setPrice(double _price)
    {
        price = _price;
    }

   
}