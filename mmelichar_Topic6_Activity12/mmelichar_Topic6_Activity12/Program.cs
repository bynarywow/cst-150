//Michael Melichar
//CST 150
//C#

public class mmelichar
{
    static void Main(string[] args)
    {
        //initialize
        int count = 0;
        int countT = 0;
        int countE = 0;
        string fileName = "";
        bool valid = false;


        //prompt user for file name
        do
        {
            Console.Write("Enter the text file name including extension: ");
            fileName = Console.ReadLine();
            if (File.Exists(fileName) && fileName.EndsWith("txt"))
            {
                valid = true;
            }
        }
        while (valid != true);

        //start streamreader to process file
        StreamReader sr = new StreamReader(fileName);

        //array of entire text file, split by spaces
        string[] words = sr.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        //debug
        //Console.Write(words[0]);

        //loop over each word
        for(int i = 0; i < words.Length; i++)
        {
            //convert to lower for easier processing
            words[i] = words[i].ToLower();

            //debug
            //Console.WriteLine(words[i]);

            //increment if the word ends with e or t
            //as well as total count
            if (words[i].EndsWith("e"))
            {
                count++;
                countE++;
            }
            else if (words[i].EndsWith("t"))
            {
                count++;
                countT++;
            }
        }

        //output results to console
        Console.WriteLine("The words in your text file ended with E " + countE + " times. ");
        Console.WriteLine("The words in your text file ended with T " + countT + " times. ");
        Console.WriteLine("Overall, that makes " + count + " times that words in your text file ended in E or T.\n");
    }
}