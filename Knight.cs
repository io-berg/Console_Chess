using System;
using System.Collections.Generic;

namespace Chess
{
    public class Knight : Piece
    {
        public Knight(char colour) : base(colour)
        {

        }

        public override List<string> GetLegalMoves(int[] position, Piece[,] board)
        {
            List<string> legalMoves = new();
            int x = position[0];
            int y = position[1];



            if (x + 1 < 8 && y + 2 < 8)
                if (board[x + 1, y + 2] == null || board[x + 1, y + 2].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x + 1) + Convert.ToString(y + 2));


            if (x + 1 < 8 && y - 2 >= 0)
                if (board[x + 1, y - 2] == null || board[x + 1, y - 2].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x + 1) + Convert.ToString(y - 2));


            if (x - 1 >= 0 && y + 2 < 8)
                if (board[x - 1, y + 2] == null || board[x - 1, y + 2].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x - 1) + Convert.ToString(y + 2));


            if (x - 1 >= 0 && y - 2 >= 0)
                if (board[x - 1, y - 2] == null || board[x - 1, y - 2].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x - 1) + Convert.ToString(y - 2));



            if (x + 2 < 8 && y + 1 < 8)
                if (board[x + 2, y + 1] == null || board[x + 1, y + 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x + 2) + Convert.ToString(y + 1));


            if (x + 2 < 8 && y - 1 >= 0)
                if (board[x + 2, y - 1] == null || board[x + 2, y - 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x + 2) + Convert.ToString(y - 1));


            if (x - 2 >= 0 && y + 1 < 8)
                if (board[x - 2, y + 1] == null || board[x - 2, y + 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x - 2) + Convert.ToString(y + 1));


            if (x - 2 >= 0 && y - 1 >= 0)
                if (board[x - 2, y - 1] == null || board[x - 2, y - 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x - 2) + Convert.ToString(y - 1));


            return legalMoves;
        }

        public override string ToString()
        {
            if (Colour == 'W') return "N";
            else return "n";
        }


    }
}