using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmelichar_Topic7_Milestone4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //pass sku back
        public int getSku ()
        {
            return Int32.Parse(textBox1.Text);
        }
        //pass count of qty to restock
        public int getCount()
        { 
            return Int32.Parse(inputTextBox.Text);
        }
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //close form, other form controls list, we get
        //what we need from getsku/getcount
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
