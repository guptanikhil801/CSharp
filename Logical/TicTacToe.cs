namespace Logical
{
    using System;
    using System.Text;

    /// <summary>
    /// This class has code to play tictactoe game
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// This method Prints the board by using char type array.
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void PrintBoard(char[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method Place 0 from computer side using random number
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void Place0(char[,] arr)
        {
            int row = new Random().Next(3);
            int column = new Random().Next(3);

            arr[row, column] = 'o';
        }

        /// <summary>
        /// This method Place x by taking row and column number from player
        /// </summary>
        /// <param name="arr">The array.</param>
        public static void Placex(char[,] arr)
        {
            Console.WriteLine("enter row number 0 to 2");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("enter column number 0 to 2 ");
            int column = int.Parse(Console.ReadLine());

            arr[row, column] = 'x';
        }

        /// <summary>
        /// Checks the tie.
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <returns>true or false</returns>
        public static bool CheckTie(char[,] arr)
        {
            if ((arr[0, 0] != ' ') && (arr[0, 1] != ' ') && (arr[0, 2] != ' ') && (arr[1, 0] != ' ') && (arr[1, 1] != ' ')
&& (arr[1, 2] != ' ') && (arr[2, 0] != ' ') && (arr[2, 1] != ' ') && (arr[2, 2] != ' '))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks the winner.
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <returns>true if anyone wins else false</returns>
        public static bool CheckWinner(char[,] arr)
        {
            if ((arr[0, 0] != ' ') && (arr[0, 0] == arr[0, 1]) && (arr[0, 0] == arr[0, 2]))
            {
                return true;       //// 1st Row
            }
            else if ((arr[1, 0] != ' ') && (arr[1, 0] == arr[1, 1]) && (arr[1, 0] == arr[1, 2]))
            {
                return true;       //// 2nd Row
            }
            else if ((arr[2, 0] != ' ') && (arr[2, 0] == arr[2, 1]) && (arr[2, 0] == arr[2, 2]))
            {
                return true;         //// 3rd Row
            }
            else if ((arr[0, 0] != ' ') && (arr[0, 0] == arr[1, 0]) && (arr[0, 0] == arr[2, 0]))
            {
                return true;      //// 1st column
            }
            else if ((arr[0, 1] != ' ') && (arr[0, 1] == arr[1, 1]) && (arr[0, 1] == arr[2, 1]))
            {
                return true;            //// 2nd column
            }
            else if ((arr[0, 2] != ' ') && (arr[0, 2] == arr[1, 2]) && (arr[0, 2] == arr[2, 2]))
            {
                return true;           //// 3rd column
            }
            else if ((arr[0, 0] != ' ') && (arr[0, 0] == arr[1, 1]) && (arr[0, 0] == arr[2, 2]))
            {
                return true;                 //// left diagonal
            }
            else if ((arr[0, 2] != ' ') && (arr[0, 2] == arr[1, 1]) && (arr[0, 2] == arr[2, 0]))
            {
                return true;                //// right diagonal
            }

            return false;
        }

        /// <summary>
        /// Drivers  method to play tictac.
        /// </summary>
        public static void DriverMethodTictac()
        {
            char[,] board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            while (CheckWinner(board) != true)
            {
                Placex(board);
                Place0(board);
                PrintBoard(board);
                if (CheckTie(board))
                {
                    Console.WriteLine("game tie play again if yes press 1 ");
                    int read = int.Parse(Console.ReadLine());
                    if (read == 1)
                    {
                        DriverMethodTictac();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("game over ");
        }
    }
}
