namespace mmelichar_Topic6_Milestone3
{
    public class Inventory
    {
        int sku;
        int quantity;
        string description;
        double price;
        Inventory[] inventoryArray = new Inventory[100];

        public Inventory(int sku, int quantity, string description, double price)
        {
            this.sku = sku;
            this.quantity = quantity;
            this.description = description;
            this.price = price;
        }

        public static Inventory[] addItem(this Inventory[] array, Inventory item)
        {
            if (array == null)
            {
                return new Inventory[]
                {
                    item
                };
            }
            Inventory[] result = new Inventory[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;
            return result;
        }
        public void removeItem()
        {

        }
        public void restockItem(int quantity)
        {
            this.quantity += quantity;
        }
        public void displayInventory()
        {

        }
        public Inventory search(int sku)
        {

        }
        public Inventory search(string description)
        {

        }
        public Inventory search(int sku, string description)
        {

        }
        public Inventory search(int sku, double price)
        {

        }
    }
}