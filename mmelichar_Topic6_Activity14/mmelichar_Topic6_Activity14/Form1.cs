namespace mmelichar_Topic6_Activity14
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dogCheckBox.Checked)
            {
                animalOutput.Items.Add(dogCheckBox.Text);
            }
            if (!dogCheckBox.Checked)
            {
                animalOutput.Items.Remove(dogCheckBox.Text);
            }
        }

        private void hotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotRadioBtn.Checked)
            {
                weatherOutput.Text = "Hot";
            }
        }

        private void catCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (catCheckBox.Checked)
            {
                animalOutput.Items.Add(catCheckBox.Text);
            }
            if (!catCheckBox.Checked)
            {
                animalOutput.Items.Remove(catCheckBox.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void coldRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (coldRadioBtn.Checked)
            {
                weatherOutput.Text = "Not hot";
            }
        }

        private void countyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Object obj in CountyListBox.SelectedItems)
            {
                outputCounty.Items.Clear();
                outputCounty.Items.Add(CountyListBox.Text);
            }
        }

        private void labelOutputDay_Click(object sender, EventArgs e)
        {

        }
    }
}