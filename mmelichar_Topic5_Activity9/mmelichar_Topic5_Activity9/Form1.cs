namespace mmelichar_Topic5_Activity9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void sum(int x, int y)
        {
            int z = x + y;
            MessageBox.Show(z.ToString());
        }
        public double average(double a, double b, double c, double d, double e)
        {
            double f = ((a + b + c + d + e) / 5);
            return f;
        }
        public int randSum()
        {
            Random rnd = new Random();
            int x = rnd.Next();
            int y = rnd.Next();
            int z = ((x + y) / 2);
            return z;
        }
        public Boolean divisibleByThree(int x, int y, int z)
        {
            int num = x + y + z;
            if (num % 3 == 0)
                return true;
            else
                return false;
        }
        public void shorter(string x, string y)
        {
            int a = x.Length;
            int b = y.Length;
            if (a > b)
                MessageBox.Show(y);
            else
                MessageBox.Show(x);
        }
        public double largest(double[] array)
        {
            return array.Max();
        }
        public int[] makeArray()
        {
            Random rnd = new Random();
            int[] array = new int[50];
            for(int i = 0; i < 50; i++)
            {
                array[i] = rnd.Next();
            }
            return array;
        }
        public Boolean isTheSame(bool x, bool y)
        {
            if (x == y)
                return true;
            return false;
        }
        public double product(int x, double y)
        {
            return x * y;
        }
        public int average(int[,] array)
        {
            int avg = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[x, i] + " ");
                    avg += array[x, i];
                }
                avg = avg / 3;

            }
            return avg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}