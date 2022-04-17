namespace mmelichar_Topic6_Activity13
{
    public partial class mmelichar_TicTacToe : Form
    {
        int player = 0;
        int position;
        int turn = 0;
        bool isCpuTurn = false;
        int playerMove;
        int firstMove;
        int secondMove;
        //bool playing = true;
        string[,] location = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };

        public mmelichar_TicTacToe()
        {
            InitializeComponent();
        }

        private void mmelichar_TicTacToe_Load(object sender, EventArgs e)
        {
            //There's only two moves that have to be hard-coded for AI to be able to
            //play tic-tac-toe near perfectly, each game /should/ result in a tie or
            //a win for the CPU. Other than that, the tryWin and tryBlock methods
            //should be able to win the game if there is an availability for that,
            //or block the opponent from winning if they cannot win quite yet.

            //I lied, this is hard. Going with a random move from a computer vs human.
            //I feel like I was really close, but couldn't finalize the last stages of bug testing
            //because this code is getting massive and changing one thing requires changing at least nine
            //and sometimes eighteen things to make one small change. It's exceedingly time consuming.
            Random rnd = new Random();



            DialogResult dialogResult = MessageBox.Show("Do you want to play as X?", "Player Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                player = 1;
            }
            else if (dialogResult == DialogResult.No)
            {
                player = 0;
                isCpuTurn = true;
            }
            cpuTurn();
        }
        private bool tryMove(int selection)
        {
            bool isValid = false;
            if (selection == 1 && button1.Text == "")
            {
                isValid = true;
            }
            if (selection == 2 && button2.Text == "")
            {
                isValid = true;
            }
            if (selection == 3 && button3.Text == "")
            {
                isValid = true;
            }
            if (selection == 4 && button4.Text == "")
            {
                isValid = true;
            }
            if (selection == 5 && button5.Text == "")
            {
                isValid = true;
            }
            if (selection == 6 && button6.Text == "")
            {
                isValid = true;
            }
            if (selection == 7 && button7.Text == "")
            {
                isValid = true;
            }
            if (selection == 8 && button8.Text == "")
            {
                isValid = true;
            }
            if (selection == 9 && button9.Text == "")
            {
                isValid = true;
            }
            return isValid; 
        }
        private void cpuTurn()
        {
            if (isCpuTurn)
            {
                randomMove();
                //player is O
                //turn 1
                //if (player == 0 && turn == 0)
                //{
                //    firstTurnCPU();
                //}
                //player is X
                //else if (player == 1 && turn == 1)
                //{
                //    firstTurnCPU();
                //}
                //else if (player == 0 && turn == 2)
                //{
                //    secondTurnCPU();
                //}
                //else if (player == 1 && turn == 3)
                //{
                //    tryBlock();
                //    secondTurnCPU();
                //}
                //else if (turn > 3)
                //{
                //    tryWin();
                //    tryBlock();
                //    isCpuTurn = false;
                //}
            }
        }
        private void randomMove()
        {
            bool isValid = false;
            Random rnd = new Random();
            while (!isValid && isCpuTurn)
            {
                int selection = rnd.Next(1, 10);

                if (tryMove(selection))
                {
                    isValid = true;
                    if (player == 0)
                    {
                        if (selection == 1)
                        {
                            button1.Text = "X";
                            location[0, 0] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 2)
                        {
                            button2.Text = "X";
                            location[0, 1] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 3)
                        {
                            button3.Text = "X";
                            location[0, 2] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 4)
                        {
                            button4.Text = "X";
                            location[1, 0] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 5)
                        {
                            button5.Text = "X";
                            location[1, 1] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 6)
                        {
                            button6.Text = "X";
                            location[1, 2] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 7)
                        {
                            button7.Text = "X";
                            location[2, 0] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 8)
                        {
                            button8.Text = "X";
                            location[2, 1] = "X";
                            isCpuTurn = false;
                        }
                        if (selection == 9)
                        {
                            button9.Text = "X";
                            location[2, 2] = "X";
                            isCpuTurn = false;
                        }
                    }
                    if (player == 1)
                    {
                        if (selection == 1)
                        {
                            button1.Text = "O";
                            location[0, 0] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 2)
                        {
                            button2.Text = "O";
                            location[0, 1] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 3)
                        {
                            button3.Text = "O";
                            location[0, 2] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 4)
                        {
                            button4.Text = "O";
                            location[1, 0] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 5)
                        {
                            button5.Text = "O";
                            location[1, 1] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 6)
                        {
                            button6.Text = "O";
                            location[1, 2] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 7)
                        {
                            button7.Text = "O";
                            location[2, 0] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 8)
                        {
                            button8.Text = "O";
                            location[2, 1] = "O";
                            isCpuTurn = false;
                        }
                        if (selection == 9)
                        {
                            button9.Text = "O";
                            location[2, 2] = "O";
                            isCpuTurn = false;
                        }
                    }
                }
            }
            check();
        }
        private void firstTurnCPU()
        {
            if (player == 0)
            {
                position = 1;
                if (tryMove(position))
                {
                    if (position == 1 && location[0, 0] == "")
                    {
                        button1.Text = "X";
                        location[0, 0] = "X";
                        firstMove = 1;
                        isCpuTurn = false;
                    }
                    turn++;
                }
            }
            else if (player == 1)
            {
                if (playerMove == 1 ||
                    playerMove == 3 ||
                    playerMove == 5 ||
                    playerMove == 7)
                {
                    position = 5;
                    if (tryMove(position))
                    {
                        if (location[1, 1] == "")
                        {
                            button5.Text = "O";
                            location[1, 1] = "O";
                            firstMove = 5;
                            isCpuTurn = false;
                        }
                    }
                }
                else
                {
                    position = 1;
                    if (tryMove(position))
                    {
                        if (location[0, 0] == "")
                        {
                            button1.Text = "O";
                            location[0, 0] = "O";
                            firstMove = 1;
                            isCpuTurn = false;
                        }
                    }
                }
            }
        }

        private void secondTurnCPU()
        {
            if (player == 0)
            {
                if (playerMove != 5)
                {
                    if (tryMove(9))
                    {
                        button9.Text = "O";
                        location[2, 2] = "O";
                        firstMove = 9;
                        isCpuTurn = false;
                    }
                    else if (tryMove(7))
                    {
                        button7.Text = "O";
                        location[2, 0] = "O";
                        firstMove = 7;
                        isCpuTurn = false;
                    }
                }
            }
        }

        private void tryWin()
        {
            //player is O
            if (player == 0)
            {
                //if 1==2(or 2==3 but not 1), but not 3,
                //and 3 is not blocked by opposite symbol,
                //try to win by placing last symbol on 3

                //1,2 win 3
                if ((location[0, 0] == location[0, 1]) 
                    && location[0,2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //2,3 win 1
                if ((location[0, 1] == location[0, 2])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //4,5 win 6
                if ((location[1, 0] == location[1, 1])
                    && location[1, 2] != "O"
                    && isCpuTurn)
                {
                    button6.Text = "X";
                    location[1, 2] = "X";
                    isCpuTurn = false;
                }
                //5,6 win 4
                if ((location[1, 1] == location[1, 2])
                    && location[1, 0] != "O"
                    && isCpuTurn)
                {
                    button4.Text = "X";
                    location[1, 0] = "X";
                    isCpuTurn = false;
                }
                //7,8 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //8,9 win 7
                if ((location[2, 1] == location[2, 2])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //1,4 win 7
                if ((location[0, 0] == location[1, 0])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[2, 0] = "X";
                    isCpuTurn = false;
                }
                //4,7 win 1
                if ((location[1, 0] == location[2, 0])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //2,5 win 8
                if ((location[0, 1] == location[1, 1])
                    && location[2, 1] != "O"
                    && isCpuTurn)
                {
                    button8.Text = "X";
                    location[2, 1] = "X";
                    isCpuTurn = false;
                }
                //5,8 win 2
                if ((location[1, 1] == location[2, 1])
                    && location[0, 1] != "O"
                    && isCpuTurn)
                {
                    button2.Text = "X";
                    location[0, 1] = "X";
                    isCpuTurn = false;
                }
                //3,6 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //6,9 win 3
                if ((location[1, 2] == location[2, 2])
                    && location[0, 2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //1,5 win 9
                if ((location[0, 0] == location[1, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //5,9 win 1
                if ((location[1, 1] == location[2, 2])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //3,5 win 7
                if ((location[0, 2] == location[1, 1])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[2, 0] = "X";
                    isCpuTurn = false;
                }
                //5,7 win 3
                if ((location[1, 1] == location[2, 0])
                    && location[0, 2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //1,3 win 2
                if ((location[0, 0] == location[0, 2])
                    && location[0, 1] != "O"
                    && isCpuTurn)
                {
                    button2.Text = "X";
                    location[0, 1] = "X";
                    isCpuTurn = false;
                }
                //4,6 win 5
                if ((location[1, 0] == location[1, 2])
                    && location[1, 1] != "O"
                    && isCpuTurn)
                {
                    button5.Text = "X";
                    location[1, 1] = "X";
                    isCpuTurn = false;
                }
                //7,9 win 8
                if ((location[2, 0] == location[2, 2])
                    && location[2, 1] != "O"
                    && isCpuTurn)
                {
                    button8.Text = "X";
                    location[2, 1] = "X";
                    isCpuTurn = false;
                }
                //1,7 win 4
                if ((location[0, 0] == location[2, 0])
                    && location[1, 0] != "O"
                    && isCpuTurn)
                {
                    button4.Text = "X";
                    location[1, 0] = "X";
                    isCpuTurn = false;
                }
                //2,8 win 5
                if ((location[0, 1] == location[2, 1])
                    && location[1, 1] != "O"
                    && isCpuTurn)
                {
                    button5.Text = "X";
                    location[1, 1] = "X";
                    isCpuTurn = false;
                }
                //3,9 win 6
                if ((location[0, 2] == location[2, 2])
                    && location[1, 2] != "O"
                    && isCpuTurn)
                {
                    button5.Text = "X";
                    location[1, 1] = "X";
                    isCpuTurn = false;
                }
                //1,9 win 5
                if ((location[0, 0] == location[2, 2])
                    && location[1, 1] != "O"
                    && isCpuTurn)
                {
                    button5.Text = "X";
                    location[1, 1] = "X";
                    isCpuTurn = false;
                }
                //3,7 win 5
                if ((location[0, 2] == location[2, 0])
                    && location[1, 1] != "O"
                    && isCpuTurn)
                {
                    button5.Text = "X";
                    location[1, 1] = "X";
                    isCpuTurn = false;
                }
            }
            //player is X
            if (player == 1)
            {
                //1,2 win 3
                if ((location[0, 0] == location[0, 1])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //2,3 win 1
                if ((location[0, 1] == location[0, 2])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //4,5 win 6
                if ((location[1, 0] == location[1, 1])
                    && location[1, 2] != "X"
                    && isCpuTurn)
                {
                    button6.Text = "O";
                    location[1, 2] = "O";
                    isCpuTurn = false;
                }
                //5,6 win 4
                if ((location[1, 1] == location[1, 2])
                    && location[1, 0] != "X"
                    && isCpuTurn)
                {
                    button4.Text = "O";
                    location[1, 0] = "O";
                    isCpuTurn = false;
                }
                //7,8 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //8,9 win 7
                if ((location[2, 1] == location[2, 2])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //1,4 win 7
                if ((location[0, 0] == location[1, 0])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[2, 0] = "O";
                    isCpuTurn = false;
                }
                //4,7 win 1
                if ((location[1, 0] == location[2, 0])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //2,5 win 8
                if ((location[0, 1] == location[1, 1])
                    && location[2, 1] != "X"
                    && isCpuTurn)
                {
                    button8.Text = "O";
                    location[2, 1] = "O";
                    isCpuTurn = false;
                }
                //5,8 win 2
                if ((location[1, 1] == location[2, 1])
                    && location[0, 1] != "X"
                    && isCpuTurn)
                {
                    button2.Text = "O";
                    location[0, 1] = "O";
                    isCpuTurn = false;
                }
                //3,6 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //6,9 win 3
                if ((location[1, 2] == location[2, 2])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //1,5 win 9
                if ((location[0, 0] == location[1, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //5,9 win 1
                if ((location[1, 1] == location[2, 2])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //3,5 win 7
                if ((location[0, 2] == location[1, 1])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[2, 0] = "O";
                    isCpuTurn = false;
                }
                //5,7 win 3
                if ((location[1, 1] == location[2, 0])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
            }
        }

        private void tryBlock()
        {
            //player is O
            if (player == 0)
            {
                //if 1==2(or 2==3 but not 1), but not 3,
                //and 3 is not blocked by opposite symbol,
                //try to block by placing last symbol on 3

                //1,2 win 3
                if ((location[0, 0] == location[0, 1])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //2,3 win 1
                if ((location[0, 1] == location[0, 2])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //4,5 win 6
                if ((location[1, 0] == location[1, 1])
                    && location[1, 2] != "X"
                    && isCpuTurn)
                {
                    button6.Text = "X";
                    location[1, 2] = "X";
                    isCpuTurn = false;
                }
                //5,6 win 4
                if ((location[1, 1] == location[1, 2])
                    && location[1, 0] != "X"
                    && isCpuTurn)
                {
                    button4.Text = "X";
                    location[1, 0] = "X";
                    isCpuTurn = false;
                }
                //7,8 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //8,9 win 7
                if ((location[2, 1] == location[2, 2])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //1,4 win 7
                if ((location[0, 0] == location[1, 0])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[2, 0] = "X";
                    isCpuTurn = false;
                }
                //4,7 win 1
                if ((location[1, 0] == location[2, 0])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //2,5 win 8
                if ((location[0, 1] == location[1, 1])
                    && location[2, 1] != "X"
                    && isCpuTurn)
                {
                    button8.Text = "X";
                    location[2, 1] = "X";
                    isCpuTurn = false;
                }
                //5,8 win 2
                if ((location[1, 1] == location[2, 1])
                    && location[0, 1] != "X"
                    && isCpuTurn)
                {
                    button2.Text = "X";
                    location[0, 1] = "X";
                    isCpuTurn = false;
                }
                //3,6 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //6,9 win 3
                if ((location[1, 2] == location[2, 2])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                //1,5 win 9
                if ((location[0, 0] == location[1, 1])
                    && location[2, 2] != "X"
                    && isCpuTurn)
                {
                    button9.Text = "X";
                    location[2, 2] = "X";
                    isCpuTurn = false;
                }
                //5,9 win 1
                if ((location[1, 1] == location[2, 2])
                    && location[0, 0] != "X"
                    && isCpuTurn)
                {
                    button1.Text = "X";
                    location[0, 0] = "X";
                    isCpuTurn = false;
                }
                //3,5 win 7
                if ((location[0, 2] == location[1, 1])
                    && location[2, 0] != "X"
                    && isCpuTurn)
                {
                    button7.Text = "X";
                    location[2, 0] = "X";
                    isCpuTurn = false;
                }
                //5,7 win 3
                if ((location[1, 1] == location[2, 0])
                    && location[0, 2] != "X"
                    && isCpuTurn)
                {
                    button3.Text = "X";
                    location[0, 2] = "X";
                    isCpuTurn = false;
                }
                else
                {
                    int selection;
                    bool validChoice = false;
                    Random rnd = new Random();
                    while (!validChoice)
                    {
                        //rand 1-9
                        selection = rnd.Next(1, 10);
                        //selection = 1
                        if (location[0, 0] == "" && selection == 1 && isCpuTurn)
                        {
                            validChoice = true;
                            button1.Text = "X";
                            location[0, 0] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 2
                        if (location[0, 1] == "" && selection == 2 && isCpuTurn)
                        {
                            validChoice = true;
                            button2.Text = "X";
                            location[0, 1] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 3
                        if (location[0, 2] == "" && selection == 3 && isCpuTurn)
                        {
                            validChoice = true;
                            button3.Text = "X";
                            location[0, 2] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 4
                        if (location[1, 0] == "" && selection == 4 && isCpuTurn)
                        {
                            validChoice = true;
                            button4.Text = "X";
                            location[1, 0] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 5
                        if (location[1, 1] == "" && selection == 5 && isCpuTurn)
                        {
                            validChoice = true;
                            button5.Text = "X";
                            location[1, 1] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 6
                        if (location[1, 2] == "" && selection == 6 && isCpuTurn)
                        {
                            validChoice = true;
                            button6.Text = "X";
                            location[1, 2] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 7
                        if (location[0, 2] == "" && selection == 7 && isCpuTurn)
                        {
                            validChoice = true;
                            button7.Text = "X";
                            location[0, 2] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 8
                        if (location[1, 2] == "" && selection == 8 && isCpuTurn)
                        {
                            validChoice = true;
                            button8.Text = "X";
                            location[1, 2] = "X";
                            isCpuTurn = false;
                        }
                        //selection = 9
                        if (location[2, 2] == "" && selection == 9 && isCpuTurn)
                        {
                            validChoice = true;
                            button9.Text = "X";
                            location[2, 2] = "X";
                            isCpuTurn = false;
                        }
                    }
                }
            }
            //player is X
            if (player == 1)
            {
                //1,2 win 3
                if ((location[0, 0] == location[0, 1])
                    && location[0, 2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //2,3 win 1
                if ((location[0, 1] == location[0, 2])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //4,5 win 6
                if ((location[1, 0] == location[1, 1])
                    && location[1, 2] != "O"
                    && isCpuTurn)
                {
                    button6.Text = "O";
                    location[1, 2] = "O";
                    isCpuTurn = false;
                }
                //5,6 win 4
                if ((location[1, 1] == location[1, 2])
                    && location[1, 0] != "O"
                    && isCpuTurn)
                {
                    button4.Text = "O";
                    location[1, 0] = "O";
                    isCpuTurn = false;
                }
                //7,8 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //8,9 win 7
                if ((location[2, 1] == location[2, 2])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //1,4 win 7
                if ((location[0, 0] == location[1, 0])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[2, 0] = "O";
                    isCpuTurn = false;
                }
                //4,7 win 1
                if ((location[1, 0] == location[2, 0])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //2,5 win 8
                if ((location[0, 1] == location[1, 1])
                    && location[2, 1] != "O"
                    && isCpuTurn)
                {
                    button8.Text = "O";
                    location[2, 1] = "O";
                    isCpuTurn = false;
                }
                //5,8 win 2
                if ((location[1, 1] == location[2, 1])
                    && location[0, 1] != "O"
                    && isCpuTurn)
                {
                    button2.Text = "O";
                    location[0, 1] = "O";
                    isCpuTurn = false;
                }
                //3,6 win 9
                if ((location[2, 0] == location[2, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //6,9 win 3
                if ((location[1, 2] == location[2, 2])
                    && location[0, 2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                //1,5 win 9
                if ((location[0, 0] == location[1, 1])
                    && location[2, 2] != "O"
                    && isCpuTurn)
                {
                    button9.Text = "O";
                    location[2, 2] = "O";
                    isCpuTurn = false;
                }
                //5,9 win 1
                if ((location[1, 1] == location[2, 2])
                    && location[0, 0] != "O"
                    && isCpuTurn)
                {
                    button1.Text = "O";
                    location[0, 0] = "O";
                    isCpuTurn = false;
                }
                //3,5 win 7
                if ((location[0, 2] == location[1, 1])
                    && location[2, 0] != "O"
                    && isCpuTurn)
                {
                    button7.Text = "O";
                    location[2, 0] = "O";
                    isCpuTurn = false;
                }
                //5,7 win 3
                if ((location[1, 1] == location[2, 0])
                    && location[0, 2] != "O"
                    && isCpuTurn)
                {
                    button3.Text = "O";
                    location[0, 2] = "O";
                    isCpuTurn = false;
                }
                else
                {
                    int selection;
                    bool validChoice = false;
                    Random rnd = new Random();
                    while (!validChoice)
                    {
                        //rand 1-9
                        selection = rnd.Next(1, 10);
                        //selection = 1
                        if (location[0, 0] == "" && selection == 1 && isCpuTurn)
                        {
                            validChoice = true;
                            button1.Text = "O";
                            location[0, 0] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 2
                        if (location[0, 1] == "" && selection == 2 && isCpuTurn)
                        {
                            validChoice = true;
                            button2.Text = "O";
                            location[0, 1] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 3
                        if (location[0, 2] == "" && selection == 3 && isCpuTurn)
                        {
                            validChoice = true;
                            button3.Text = "O";
                            location[0, 2] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 4
                        if (location[1, 0] == "" && selection == 4 && isCpuTurn)
                        {
                            validChoice = true;
                            button4.Text = "O";
                            location[1, 0] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 5
                        if (location[1, 1] == "" && selection == 5 && isCpuTurn)
                        {
                            validChoice = true;
                            button5.Text = "O";
                            location[1, 1] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 6
                        if (location[1, 2] == "" && selection == 6 && isCpuTurn)
                        {
                            validChoice = true;
                            button6.Text = "O";
                            location[1, 2] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 7
                        if (location[0, 2] == "" && selection == 7 && isCpuTurn)
                        {
                            validChoice = true;
                            button7.Text = "O";
                            location[0, 2] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 8
                        if (location[1, 2] == "" && selection == 8 && isCpuTurn)
                        {
                            validChoice = true;
                            button8.Text = "O";
                            location[1, 2] = "O";
                            isCpuTurn = false;
                        }
                        //selection = 9
                        if (location[2, 2] == "" && selection == 9 && isCpuTurn)
                        {
                            validChoice = true;
                            button9.Text = "O";
                            location[2, 2] = "O";
                            isCpuTurn = false;
                        }
                    }
                }
            }
        }
        private void check()
        {
            bool winner = false;
            //if 1,2,3
            if ((location[0, 0] == location[0, 1]) && (location[0, 1] == location[0, 2]) && location[0, 0] != "")
            {
                winner = true;
            }
            //if 4,5,6
            if ((location[1, 0] == location[1, 1]) && (location[1, 1] == location[1, 2]) && location[1, 0] != "")
            {
                winner = true;
            }
            //if 7,8,9
            if ((location[2, 0] == location[2, 1]) && (location[2, 1] == location[2, 2]) && location[2, 0] != "")
            {
                winner = true;
            }
            //if 1,4,7
            if ((location[0, 0] == location[1, 0]) && (location[1, 0] == location[2, 0]) && location[0, 0] != "")
            {
                winner = true;
            }
            //if 2,5,8
            if ((location[0, 1] == location[1, 1]) && (location[1, 1] == location[2, 1]) && location[0, 1] != "")
            {
                winner = true;
            }
            //if 3,6,9
            if ((location[0, 2] == location[1, 2]) && (location[1, 2] == location[2, 2]) && location[0, 2] != "")
            {
                winner = true;
            }
            //if 1,5,7
            if ((location[0, 0] == location[1, 1]) && (location[1, 1] == location[2, 2]) && location[0, 0] != "")
            {
                winner = true;
            }
            //if 3,5,7
            if ((location[0, 2] == location[1, 1]) && (location[1, 1] == location[2, 0]) && location[0, 2] != "")
            {
                winner = true;
            }
            if (winner)
            {
                MessageBox.Show("Winner!");
                //playing = false;
            }
            else if (turn == 9)
            {
                MessageBox.Show("Draw!");
                //playing = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button1.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button1.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button1.Text != "")
            {
                location[0, 0] = button1.Text;
                playerMove = 1;
            }
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button2.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button2.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button2.Text != "")
            {
                location[0, 1] = button2.Text;
                playerMove = 2;
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button3.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button3.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button3.Text != "")
            {
                location[0, 2] = button3.Text;
                playerMove = 3;
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button4.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button4.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button4.Text != "")
            {
                location[1, 0] = button4.Text;
                playerMove = 4;
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button5.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button5.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button5.Text != "")
            {
                location[1, 1] = button5.Text;
                playerMove = 5;
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button6.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0 )
            {
                button6.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button6.Text != "")
            {
                location[1, 2] = button6.Text;
                playerMove = 6;
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button7.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button7.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button7.Text != "")
            {
                location[2, 0] = button7.Text;
                playerMove = 7;
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button8.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button8.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button8.Text != "")
            {
                location[2, 1] = button8.Text;
                playerMove = 8;
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //alternate X or O based on player selection
            if (player == 1)
            {
                button9.Text = "X";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (player == 0)
            {
                button9.Text = "O";
                isCpuTurn = true;
                turn++;
                cpuTurn();
            }
            else if (button9.Text != "")
            {
                location[2, 2] = button9.Text;
                playerMove = 9;
            }
            check();
        }
    }
}