namespace mmelichar_Topic3_activity7
{
    public partial class mmelichar_Topic3_Activity7 : Form
    {
        public mmelichar_Topic3_Activity7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            //variable declaration
            const double INITIAL_VALUE = 4;
            double iterations;
            double numerator = 4;
            double denominator = 3;
            double pi;

            //try catch for string => double parse
            try
            {
                //take in input, convert from string => double
                iterations = Int32.Parse(textBoxInput.Text);
                

                pi = INITIAL_VALUE;
                for (int i = 1; i <= iterations; i++)
                {
                    //if even, add
                    if (i % 2 == 0)
                        pi += (numerator / denominator);
                    //if odd, subtract
                    else
                        pi -= (numerator / denominator);
                    //increment the denominator each iteration
                    denominator += 2;
                }
                //format and print the estimation to the label designated for output
                lblOutput.Text = $"'{pi}'";
                
            }
            catch(FormatException)
            {
                Console.WriteLine($"Unable to parse '{textBoxInput.Text}");
            }
        }
    }
}