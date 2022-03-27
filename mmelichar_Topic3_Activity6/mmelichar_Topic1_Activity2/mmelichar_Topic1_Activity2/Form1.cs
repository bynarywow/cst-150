namespace mmelichar_Topic1_Activity2
{
    public partial class Activity2_mmelichar : Form
    {
        public Activity2_mmelichar()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            //Declare variables
            double number;
            double weight;
            //Per Google, gravity on Earth = 9.807m/s^2
            const double GravityEarth = 9.807;
            //Per Google, gravity on Mars = 3.721m/s^2
            const double GravityMars = 3.721;
            //prompt user for input
            try
            {
                //assign input to variable
                number = double.Parse(textBoxInput.Text);
            
                //calculate weight on mars by dividing Earth's gravitational pull
                //and multiplying by mars' gravitational pull, then round at 3 digits
                //per example shown for rubric
                weight = Math.Round(((number / GravityEarth) * GravityMars), 3);
                textBoxOutput.Text = weight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter your weight to have it converted to your weight on Mars.", "Data Validation Error", MessageBoxButtons.OK);
            }
        }
    }
}