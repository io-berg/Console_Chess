using System;
using System.Collections.Generic;

namespace Chess
{
    public class King : Piece
    {
        public bool HasMoved { get; set; }


        public King(char colour) : base(colour)
        {
            this.HasMoved = false;
        }

        public override string ToString()
        {
            if (Colour == 'W') return "K";
            else return "k";
        }

        public override List<string> GetLegalMoves(int[] position, Piece[,] board)
        {
            List<string> legalMoves = new();
            int x = position[0];
            int y = position[1];

            // check down
            if (x + 1 < 8)
                if (board[x + 1, y] == null || board[x + 1, y].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x + 1) + y.ToString());

            // check up
            if (x - 1 > 0)
                if (board[x - 1, y] == null || board[x - 1, y].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x - 1) + y.ToString());

            // check right
            if (y + 1 < 8)
                if (board[x, y + 1] == null || board[x, y + 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x) + Convert.ToString(y + 1));

            // check left
            if (y - 1 > 0)
                if (board[x, y - 1] == null || board[x, y - 1].Colour != Colour)
                    legalMoves.Add(Convert.ToString(x) + Convert.ToString(y - 1));

            if (Colour == 'W' && HasMoved == false)
            {

            }

            return legalMoves;
        }
    }
}