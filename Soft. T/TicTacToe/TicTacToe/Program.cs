namespace TIC_TAC_TOE
{
    class Game
    {
        private char[,] board = new char[3, 3];
        private char player1;
        private char player2;
        private int currentPlayer = 0;
        static void Main()
        {
            Game gameObj = new Game();
            gameObj.setGame();
            while (gameObj.move()) ;
        }
        private void setGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    board[i, y] = '.';
                }
            }

            Console.Write("Player 1 select 'x' or 'o': ");
            player1 = char.Parse(Console.ReadLine());
            while (player1 != 'x' && player1 != 'o')
            {
                Console.WriteLine("Your choice shoud be either 'x' or 'o'");
                player1 = char.Parse(Console.ReadLine());
            }
            player2 = (player1 == 'x') ? 'o' : 'x';
            Console.WriteLine($"Player 2 you are '{player2}'");

            Board();

            //x -> 1 o -> -1;
            if (player1 == 'x')
            {
                currentPlayer = 1;
            }
            else
            {
                currentPlayer = -1;
            }
        }
        void Board()
        {
            Console.WriteLine("_________________");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {board[0, 0]}  |  {board[0, 1]}  |  {board[0, 2]}  |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {board[1, 0]}  |  {board[1, 1]}  |  {board[1, 2]}  |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {board[2, 0]}  |  {board[2, 1]}  |  {board[2, 2]}  |");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_________________|");
        }
        bool move()
        {
            if (!endGame())
            {
                if (currentPlayer == 1)
                {
                    Console.WriteLine("Player 1 it is your turn!");
                }
                else if (currentPlayer == -1)
                {
                    Console.WriteLine("Player 2 it is your turn!");
                }

                //Entering rc:
                //row:
                Console.Write("Make a move. (1, 2 or 3)\nRow: ");
                int row = int.Parse(Console.ReadLine());
                while (row < 1 || row > 3)
                {
                    Console.WriteLine("Try again!");
                    row = int.Parse(Console.ReadLine());
                }
                row = row - 1;

                //column:
                Console.Write("Column: ");
                int column = int.Parse(Console.ReadLine());
                while (column < 1 || column > 3)
                {
                    Console.WriteLine("Try again!");
                    column = int.Parse(Console.ReadLine());
                }
                column = column - 1;


                if (board[row, column] == 'x' || board[row, column] == 'o')
                {
                    Console.WriteLine("This scope is taken. Try another one!");
                    move();
                }
                else
                {
                    if (currentPlayer == -1)
                    {
                        board[row, column] = player2;
                        Board();
                        if (checkWin() == true)
                        {
                            return false;
                        }
                        currentPlayer = 1;
                    }
                    else
                    {
                        board[row, column] = player1;
                        Board();
                        if (checkWin() == true)
                        {
                            return false;
                        }
                        currentPlayer = -1;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("There is no winner!");
                return false;
            }
            return true;
        }

        bool endGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board[i, y] == '.')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool checkWin()
        {
            string won = (currentPlayer == 1) ? "Player 1 WON!" : "Player 2 WON!";

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == 'x' && board[i, 1] == 'x' && board[i, 2] == 'x')
                {
                    Console.WriteLine(won);
                    return true;
                }
                else if (board[i, 0] == 'o' && board[i, 1] == 'o' && board[i, 2] == 'o')
                {
                    Console.WriteLine(won);
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == 'x' && board[1, i] == 'x' && board[2, i] == 'x')
                {
                    Console.WriteLine(won);
                    return true;
                }
                else if (board[0, i] == 'o' && board[1, i] == 'o' && board[2, i] == 'o')
                {
                    Console.WriteLine(won);
                    return true;
                }
            }

            //DIAGONAL:
            if (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x')
            {
                Console.WriteLine(won);
                return true;
            }
            else if (board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o')
            {
                Console.WriteLine(won);
                return true;
            }
            else if (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x')
            {
                Console.WriteLine(won);
                return true;
            }
            else if (board[0, 2] == 'o' && board[1, 1] == 'o' && board[2, 0] == 'o')
            {
                Console.WriteLine(won);
                return true;
            }
            return false;
        }
    }
}