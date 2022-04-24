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
       // List<Inventory> inventory = null;

        public Form2()
        {
            InitializeComponent();

           // inventory = list;
        }
        public int getSku ()
        {
            return Int32.Parse(textBox1.Text);
        }
        public int getCount()
        { 
            return Int32.Parse(inputTextBox.Text);
        }
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          //  int[] val= { 1, 2 };
           // return val;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
