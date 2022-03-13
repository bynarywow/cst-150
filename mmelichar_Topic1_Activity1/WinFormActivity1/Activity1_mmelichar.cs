namespace WinFormActivity1
{
    public partial class Activity1_mmelichar : Form
    {
        public Activity1_mmelichar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare variables
            double number;
            //assign input to variable
            number = double.Parse(textBoxInput.Text);
            //change text box for output to be = double
            textBoxOutput.Text = ((number * 2).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}