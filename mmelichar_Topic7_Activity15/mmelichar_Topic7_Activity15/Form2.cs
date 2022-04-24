using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmelichar_Topic7_Activity15
{
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            FormInput form = new FormInput();
            InitializeComponent();
            lblLuckyNumber.Text = form.getLucky().ToString();
        }

        private void lblOutputLucky_Click(object sender, EventArgs e)
        {

        }
    }
}
