namespace mmelichar_Topic2_Activity4
{
    public partial class mmelichar_activity4 : Form
    {
        public mmelichar_activity4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //get input in number of seconds
            int seconds = int.Parse(textBoxInput.Text);

            //if seconds are greater than or equal to 1 minute, but less than 1 hour
            if(seconds >= 60 && seconds < 3600)
            {
                lblOutput.Text = "There are " + (seconds / 60) + " minute(s) in " + seconds + " seconds.";
            }
            //if seconds are greater than or equal to 1 hour, but less than 1 day
            else if(seconds >= 3600 && seconds < 86400)
            {
                lblOutput.Text = "There are " + (seconds / 3600) + " hour(s) in " + seconds + " seconds.";
            }
            //if seconds are greater than or equal to 1 day
            else if(seconds >= 86400)
            {
                lblOutput.Text = "There are " + (seconds / 86400) + " day(s) in " + seconds + " seconds.";
            }
            //if all else fails, input is less than 60 seconds.
            //reprompt user for higher number.
            else
            {
                lblOutput.Text = "You input " + seconds + " seconds. Input a higher number!";
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}