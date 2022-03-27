namespace mmelichar_Topic3_Activity5
{
    public partial class mmelichar_topic3_activity56 : Form
    {
        string winDir = System.Environment.GetEnvironmentVariable("windir");
        public mmelichar_topic3_activity56()
        {
            InitializeComponent();
        }

        private async void btnClickThis_Click(object sender, EventArgs e)
        {
            //using example code from: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog?view=windowsdesktop-6.0
            //to open a file dialog box and allow selection

            //variable declaration by section
            //file processing
            var fileContent = string.Empty;
            var filePath = string.Empty;
            //counting vowels and storing the word
            int vowelMax = 0;
            int vowelCount = 0;
            String maxVowels = "";
            //finding length and storing longest word
            int length = 0;
            int lengthMax = 0;
            //for storing first and last words alphabetically
            String first = "z";
            String last = "a";
            var maxLength = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using StreamWriter file = new("Stats.txt", append: true);
                    //using StreamWriter test = new("testoutput.txt", append: true);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        //read the file, converting it to lower case to start
                        fileContent = reader.ReadToEnd();
                        fileContent = fileContent.ToLower();
                        //split file into words, separating by spaces and new lines
                        var words = fileContent.Split(' ', '\n');
                        //await test.WriteLineAsync("words: " + words + "\n");
                        //get longest word of file
                        maxLength = words.OrderBy(n => n.Length).Last();
                        
                        try
                            {
                                if (words != null)
                                {
                                    foreach (var word in words)
                                    {
                                        //await test.WriteLineAsync("current word: " + word + "\n");
                                        
                                        //if word < first, store word as first
                                        if (String.Compare(word, first) <= 0)
                                        {
                                            first = word;
                                        }
                                        
                                        //if word > last, store word as last
                                        else if (String.Compare(word, last) > 0)
                                        {
                                            last = word;
                                        }
                                        length = word.Length;
                                        //iterate over each letter to check for vowels and total them up
                                        vowelCount = 0;
                                        for (int i = 0; i < length; i++)
                                        {
                                            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                                            {
                                                vowelCount++;
                                                //await test.WriteLineAsync(word[i] + "\n");
                                                //await test.WriteLineAsync(vowelCount + "\n");
                                                //if vowelCount is greater than max, store word as new max
                                                if (vowelCount > vowelMax)
                                                {
                                                    vowelMax = vowelCount;
                                                    maxVowels = word;
                                                }
                                            }
                                        }
                                        
                                        //await file.WriteLineAsync(word);
                                    }
                                }
                            } catch (IOException error)
                            {
                                Console.WriteLine("IOException source: {0}", error.Source);
                            }
                        //append file stats after processing is complete
                        await file.WriteLineAsync("First word(Alphabetically): " + first + "\n");
                        await file.WriteLineAsync("Last word(Alphabetically): " + last + "\n");
                        await file.WriteLineAsync("Longest word: " + maxLength + "\n");
                        await file.WriteLineAsync("Word with the most vowels: " + maxVowels + "\n");
                    }
                }
            }
            MessageBox.Show("First word alphabetically: " + first + "\n" + "Last word alphabetically: " + last + "\n" + "Longest word: " + maxLength + "\n" + "Word with the most vowels: " + maxVowels + "\n", "After processing stats:", MessageBoxButtons.OK);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}