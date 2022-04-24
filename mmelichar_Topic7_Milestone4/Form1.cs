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

        }

       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int value;
            double filler;
            //verify input before parse
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
            //refresh display
            display();
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            //refresh display
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
            //grab index of selected item
            int idx = dataGridView1.CurrentRow.Index;
            //remove it
            app.removeItem(idx);
            //refresh display
            display();
        }

        public void btnRestockItem_Click(object sender, EventArgs e)
        {
            Form2 restockDialog = new Form2();
            restockDialog.ShowDialog();
            //get sku/count from form2
            int sku = restockDialog.getSku();
            int count = restockDialog.getCount();
            //use sku/count to restock qty
            app.restockItem(sku, count);
            //refresh display
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //search for item
            Inventory item = app.search(Int32.Parse(textBoxSku.Text), textBoxDescription.Text);
            //if not found
            if(item==null)
            {
                MessageBox.Show("Not Found");
            }
            //otherwise print item
            else
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}