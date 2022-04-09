using System.Linq;
public class Dice
{
    private int sides;

    public const int MinSides = 4;
    public const int MaxSides = 20;
    //default constructor picks a random number of sides
    public Dice()
    {
        Random rnd = new Random();
        //generates a number between 4 and 20
        this.sides = rnd.Next(MinSides, MaxSides + 1);
    }

    //initialized constructor
    public Dice(int sides)
    {
        this.sides = sides;
    }

    public int rollDie()
    {
        Random rnd = new Random();
        //generates a number between 1 and the max number of sides
        int dieValue = rnd.Next(1, sides + 1);
        return dieValue;
    }

    static void Main(string[] args)
    {
        //randomly declare a number of sides
        Random rnd = new Random();
        int numSides = rnd.Next(MinSides, MaxSides + 1);
        //debug
        Console.WriteLine("Number of sides: " + numSides);

        //initialize 2 dice with the same number of sides randomly determined above
        Dice die1 = new Dice(numSides);
        Dice die2 = new Dice(numSides);

        //initialize storage for rolls and counter for number of rolls
        int roll1;
        int roll2;
        int count = 0;
        //must enter loop at least one time
        do
        {
            //store rolls
            roll1 = die1.rollDie();
            roll2 = die2.rollDie();
            
            //print out rolls
            Console.WriteLine(roll1 + " " + roll2);
            //add to counter
            count += 1;
        }
        while (roll1 != 1 || roll2 != 1);
        //print count for number of rolls performed
        Console.Write("Number of rolls before snake eyes: " + count);
        //debug
        //Console.ReadLine();
    }
}