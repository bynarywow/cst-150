using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmelichar_Topic7_Milestone4
{
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
}
