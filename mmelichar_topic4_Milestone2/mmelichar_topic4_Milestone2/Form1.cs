namespace mmelichar_topic4_Milestone2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Inventory
        {
            //class properties
            public int sku;
            public int quantity;
            public string partNum;
            public string description;

            //default constructor
            public Inventory()
            {
                this.sku = 99999;
                this.quantity = 0;
                this.partNum = "";
                this.description = "";
            }

            //constructor
            public Inventory(int sku, int quantity, string partNum, string description)
            {
                this.sku = sku;
                this.quantity = quantity;
                this.partNum = partNum;
                this.description = description;
            }

            public void setSku(int sku)
            {
                this.sku = sku;
            }

            public int getSku()
            {
                return this.sku;
            }

            public void setQuantity(int quantity)
            {
                this.quantity = quantity;
            }

            public int getQuantity()
            {
                return this.quantity;
            }

            public void setPartNum(string partNum)
            {
                this.partNum = partNum;
            }

            public string getPartNum()
            {
                return this.partNum;
            }

            public void setDescription(string description)
            {
                this.description = description;
            }

            public string getDescription()
            {
                return this.description;
            }

            //add quantity to inventory without necessarily knowing exactly how many there are
            public void addInventory(int quantityToAdd)
            {
                int qty = getQuantity();
                qty += quantityToAdd;
                setQuantity(qty);
            }

            //remove quantity from inventory without having to know how many there are
            public void deleteInventory(int quantityToRemove)
            {
                int qty = getQuantity();
                qty -= quantityToRemove;
                setQuantity(qty);
            }

            //audit inventory amounts without regard to previous inventory amount
            public void editInventory(int amount)
            {
                setQuantity(amount);
            }

            //search by int = searching skus
            public Boolean searchInventory(int searchSku)
            {
                Boolean result = false;
                if (getSku() == searchSku)
                {
                    result = true;
                }
                return result;
            }

            //search by string = partnum or description
            public Boolean searchInventory(string searchString)
            {
                Boolean result = false;
                if (getPartNum() == searchString)
                {
                    result = true;
                }
                else if (getDescription() == searchString)
                {
                    result = true;
                }
                return result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize constructor and default constructor
            Inventory inv = new Inventory(58744, 6, "PVXH011SA", "Hayward Steering Bracket Roller Assembly");
            Inventory invDefault = new Inventory();
            //output values initialized into Inventory
            label1.Text = ("inv SKU: " + inv.getSku());
            label2.Text = ("inv quantity: " + inv.getQuantity());
            label3.Text = ("inv part number: " + inv.getPartNum());
            label4.Text = ("inv description: " + inv.getDescription());
            label21.Text = ("Found 58744 in sku of inv: " + inv.searchInventory(58744));
            label25.Text = ("Found PVXH011SA in part number of inv: " + inv.searchInventory("PVXH011SA"));
            label5.Text = ("=============================================");
            label6.Text = ("default SKU: " + invDefault.getSku());
            label7.Text = ("default quantity: " + invDefault.getQuantity());
            label8.Text = ("default part number: " + invDefault.getPartNum());
            label9.Text = ("default description: " + invDefault.getDescription() + "");
            label22.Text = ("Found 58744 in sku of invDefault: " + invDefault.searchInventory(58744));
            label26.Text = ("Found PVXH011SA in part number of invDefault: " + invDefault.searchInventory("PVXH011SA"));
            label10.Text = ("=============================================");
            //modify inv values
            inv.addInventory(660);
            inv.setDescription("Rolly gear thing that controls steering");
            inv.setPartNum("Overpriced");
            inv.setSku(69420);
            //print new inv values
            label11.Text = ("inv SKU: " + inv.getSku());
            label12.Text = ("inv quantity: " + inv.getQuantity());
            label13.Text = ("inv part number: " + inv.getPartNum());
            label14.Text = ("inv description: " + inv.getDescription());
            label23.Text = ("Found 58744 in sku of inv: " + inv.searchInventory(58744));
            label27.Text = ("Found PVXH011SA in part number of inv: " + inv.searchInventory("PVXH011SA"));
            label15.Text = ("=============================================");
            //modify invDefault values
            invDefault.setSku(58744);
            invDefault.setQuantity(6);
            invDefault.setPartNum("PVXH011SA");
            invDefault.setDescription("Hayward Steering Bracket Roller Assembly");
            //print new invDefault values
            label16.Text = ("default SKU: " + invDefault.getSku());
            label17.Text = ("default quantity: " + invDefault.getQuantity());
            label18.Text = ("default part number: " + invDefault.getPartNum());
            label19.Text = ("default description: " + invDefault.getDescription() + "");
            label24.Text = ("Found 58744 in sku of invDefault: " + invDefault.searchInventory(58744));
            label28.Text = ("Found PVXH011SA in part number of invDefault: " + invDefault.searchInventory("PVXH011SA"));
            label20.Text = ("=============================================");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}