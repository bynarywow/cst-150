namespace mmelichar_Topic7_Activity15
{
    public partial class FormInput : Form
    {
        
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnGetLucky_Click(object sender, EventArgs e)
        {

            FormOutput form = new FormOutput();

            form.Show();
        }
        public int getLucky()
        {
            Random rnd = new Random();
            int luckyNum = rnd.Next(1, 32);
            return luckyNum;
        }

        private bool isLeapYear(int year)
        {
            //rule 1: divisible by 4
            if (year % 4 == 0)
            {
                //rule 2: divisible by 400
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                //rule 3: fails if divisible by 100 but not by 400
                else if (year % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private bool isLongMonth(int month)
        {
            //if jan, mar, may, jul, aug, oct, dec, 31 days
            if (month == 1 || month == 3 || month == 5
                || month == 7 || month == 8 || month == 10
                || month == 12)
            {
                return true;
            }
            return false;
        }
        private void monthDayChange()
        {
            //if month shouldn't have 31 days, remove option for 31
            if (!isLongMonth(Int32.Parse(comboBoxMonth.Text)))
            {
                comboBoxDay.Items.Remove("31");
            }
            //add back 31 if dropdown list needs it after user swaps month selections
            else if(!comboBoxDay.Items.Contains("31"))
            { 
                comboBoxDay.Items.Add("31");   
            }
        }
        private void februaryDayChange()
        {
            //if it is a leap year and the month february is selected,
            //remove 30/31
            if (isLeapYear(Int32.Parse(comboBoxYear.Text)) && comboBoxMonth.Text == "2")
            {
                comboBoxDay.Items.Remove("30");
                comboBoxDay.Items.Remove("31");
            }
            //if it isn't a leap year and february is selected,
            //remove 29/30/31
            else if (!isLeapYear(Int32.Parse(comboBoxYear.Text)) && Int32.Parse(comboBoxMonth.Text) == 2)
            {
                comboBoxDay.Items.Remove("29");
                comboBoxDay.Items.Remove("30");
                comboBoxDay.Items.Remove("31");
            }
            //add back days if selection changes off of february
            else if(!comboBoxDay.Items.Contains("30") && comboBoxMonth.Text != "2")
            {
                //make sure to add back the correct days with no duplicates
                if (!comboBoxDay.Items.Contains("29"))
                {
                    comboBoxDay.Items.Add("29");
                    comboBoxDay.Items.Add("30");
                    //check for 31
                    if (isLongMonth(Int32.Parse(comboBoxMonth.Text)))
                    {
                        comboBoxDay.Items.Add("31");
                    }
                }
                else
                {
                    comboBoxDay.Items.Add("30");
                    //check for 31
                    if (isLongMonth(Int32.Parse(comboBoxMonth.Text)))
                    {
                        comboBoxDay.Items.Add("31");
                    }
                }
            }
        }
        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //any time we change either the year or month,
            //we may need to change the amount of days in the
            //day combo box
            februaryDayChange();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //any time we change either the year or month,
            //we may need to change the amount of days in the
            //day combo box
            if (comboBoxYear.Text != "")
            {
                februaryDayChange();
            }
            //check whether the month needs 31 or not
            monthDayChange();
        }
    }
}