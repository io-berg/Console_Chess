using System;

namespace Chess
{
    public class Player
    {
        char colour;


        public Player(char colour)
        {
            this.colour = colour;
        }

        public int[] SelectPiece(Piece[,] boardState)
        {
            int row;
            int column;
            while (true)
            {
                if (this.colour == 'B') Console.WriteLine("Black's turn");
                else Console.WriteLine("White's turn");
                System.Console.WriteLine("Enter the piece you wish to select as Column Row (ex: B2)");
                char[] userInput = Console.ReadLine().ToUpper().ToCharArray();

                column = userInput[0] - 'A';
                if (column > 7 || column < 0) continue;

                row = userInput[1] - '1';
                if (row == 7) row = 0;
                else if (row == 6) row = 1;
                else if (row == 5) row = 2;
                else if (row == 4) row = 3;
                else if (row == 3) row = 4;
                else if (row == 2) row = 5;
                else if (row == 1) row = 6;
                else if (row == 0) row = 7;
                if (row > 7 || row < 0) continue;

                if (boardState[row, column] is Piece && boardState[row, column].Colour == colour)
                    break;
            }

            int[] selectedPieceIndex = { row, column };
            return selectedPieceIndex;
        }
    }
}