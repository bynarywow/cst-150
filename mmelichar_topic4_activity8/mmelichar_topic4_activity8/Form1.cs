namespace mmelichar_topic4_activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double FatCalories(double fatGrams)
        {
            //declare variables
            const double FAT_GRAMS_TO_CALORIES = 9.0;
            double fatCals;
            //calories from fat = fat grams * 9
            fatCals = fatGrams * FAT_GRAMS_TO_CALORIES;
            return fatCals;
        }

        public double CarbCalories(double carbGrams)
        {
            //declare variables
            const double CARB_GRAMS_TO_CALORIES = 4.0;
            double carbCals;
            //calories from carbs = carb grams * 4
            carbCals = carbGrams * CARB_GRAMS_TO_CALORIES;
            return carbCals;
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            //retrieve inputs and store as double
            double fatInput = Double.Parse(fatGramsInput.Text);
            double carbInput = Double.Parse(carbGramsInput.Text);

            //set output messages
            fatCalOutput.Text = "Number of calories resulting from fat: " + FatCalories(fatInput);
            carbCalOutput.Text = "Number of calories resulting from carbs: " + CarbCalories(carbInput);
        }
    }
}