using System.Data;
namespace mmelichar_Topic7_Milestone4
{
    public partial class InventoryForm : Form
    {
        App app = new App();
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //debug show prefab items on load
            /*
            System.Data.DataTable dt = new System.Data.DataTable("inv");
            dt.Columns.Add("Sku", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Price", typeof(float));

            Inventory[] list = app.getInventory();
            for(int i=0;i<app.getSize();i++)
            {
                DataRow dr = dt.NewRow();
                dr["Sku"] = list[i].getSku();
                dr["Quantity"] = list[i].getQuantity();
                dr["Description"] = list[i].getDescription();
                dr["Price"] = list[i].getPrice();
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
            */
        }

       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int value;
            double filler;
            if (int.TryParse(textBoxSku.Text, out value) && int.TryParse(textBoxQuantity.Text, out value) && double.TryParse(textBoxPrice.Text, out filler))
            {
                //parsing successful
                Inventory item = new Inventory(int.Parse(textBoxSku.Text), int.Parse(textBoxQuantity.Text), textBoxDescription.Text, double.Parse(textBoxPrice.Text));
                app.addItem(item); 
            }
            else
            {
                //parsing failed. 
                MessageBox.Show("Invalid input. Please check that SKU, Quantity, and Price only contain numbers.");
            }
            display();
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        { 
            //make datatable object to handle array
            System.Data.DataTable dt = new System.Data.DataTable("inv");
            //init columns for sku/quant/desc/price
            dt.Columns.Add("Sku", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Price", typeof(float));

            //pass inventory to array to be used in display
            List<Inventory> list = app.getList();
            //display each item
            for (int i = 0; i < list.Count(); i++)
            {
                DataRow dr = dt.NewRow();
                dr["Sku"] = list[i].getSku();
                dr["Quantity"] = list[i].getQuantity();
                dr["Description"] = list[i].getDescription();
                dr["Price"] = list[i].getPrice();
                dt.Rows.Add(dr);
            }
            //declare data source for table
            dataGridView1.DataSource = dt;
        }

   
        private void btnRemoveItem_Click(object sender, EventArgs e) { 
            int value;
            double filler;

            int idx = dataGridView1.CurrentRow.Index;
            app.removeItem(idx);
            display();

/*  

            if (int.TryParse(textBoxSku.Text, out value) && int.TryParse(textBoxQuantity.Text, out value) && double.TryParse(textBoxPrice.Text, out filler))
            {
                //parsing successful
                Inventory item = new Inventory(int.Parse(textBoxSku.Text), int.Parse(textBoxQuantity.Text), textBoxDescription.Text, double.Parse(textBoxPrice.Text));
                MessageBox.Show(item.ToString());
                app.removeItem(item);

                //debug reload table on addition
                System.Data.DataTable dt = new System.Data.DataTable("inv");
                dt.Columns.Remove("Sku");
                dt.Columns.Remove("Quantity");
                dt.Columns.Remove("Description");
                dt.Columns.Remove("Price");

                List<Inventory> list = app.getList();
                for (int i = 0; i < list.Count(); i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Sku"] = list[i].getSku();
                    dr["Quantity"] = list[i].getQuantity();
                    dr["Description"] = list[i].getDescription();
                    dr["Price"] = list[i].getPrice();
                    dt.Rows.Add(dr);

                }
                dataGridView1.DataSource = dt;
                   
            }
            else
            {
                //parsing failed. 
                MessageBox.Show("Invalid input. Please check that SKU, Quantity, and Price only contain numbers.");
            }
*/
        }

        public void btnRestockItem_Click(object sender, EventArgs e)
        {
            Form2 restockDialog = new Form2();
            restockDialog.ShowDialog();
            int sku = restockDialog.getSku();
            int count = restockDialog.getCount();
            app.restockItem(sku, count);
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventory item = app.search(Int32.Parse(textBoxSku.Text), textBoxDescription.Text);
            if(item==null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}