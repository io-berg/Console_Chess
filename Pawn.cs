using System;
using System.Collections.Generic;

namespace Chess
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }

        public Pawn(char colour) : base(colour)
        {
            this.HasMoved = false;
        }

        public override List<string> GetLegalMoves(int[] position, Piece[,] board)
        {
            List<string> legalMoves = new();
            int x = position[0];
            int y = position[1];

            // check down
            if (Colour == 'B')
                if (x + 1 < 8)
                {
                    if (board[x + 1, y] == null || board[x + 1, y].Colour != Colour)
                        legalMoves.Add(Convert.ToString(x + 1) + y.ToString());
                    if (HasMoved == false)
                        if (board[x + 2, y] == null || board[x + 2, y].Colour != Colour)
                            legalMoves.Add(Convert.ToString(x + 2) + y.ToString());

                    // check if pawn can take a piece
                    if (board[x + 1, y + 1] is Piece)
                    {
                        if (board[x + 1, y + 1].Colour != this.Colour)
                        {
                            legalMoves.Add(Convert.ToString(x + 1) + Convert.ToString(y + 1));
                        }
                    }
                    if (board[x + 1, y - 1] is Piece)
                    {
                        if (board[x + 1, y - 1].Colour != this.Colour)
                        {
                            legalMoves.Add(Convert.ToString(x + 1) + Convert.ToString(y - 1));
                        }
                    }
                }

            // check up
            if (Colour == 'W')
                if (x - 1 > 0)
                {
                    if (board[x - 1, y] == null || board[x - 1, y].Colour != Colour)
                        legalMoves.Add(Convert.ToString(x - 1) + y.ToString());
                    if (HasMoved == false)
                        if (board[x - 2, y] == null || board[x - 2, y].Colour != Colour)
                            legalMoves.Add(Convert.ToString(x - 2) + y.ToString());

                    // check if pawn can take a piece
                    if (board[x - 1, y + 1] is Piece)
                    {
                        if (board[x - 1, y + 1].Colour != this.Colour)
                        {
                            legalMoves.Add(Convert.ToString(x - 1) + Convert.ToString(y + 1));
                        }
                    }
                    if (board[x - 1, y - 1] is Piece)
                    {
                        if (board[x - 1, y - 1].Colour != this.Colour)
                        {
                            legalMoves.Add(Convert.ToString(x - 1) + Convert.ToString(y - 1));
                        }
                    }
                }

            return legalMoves;
        }

        public override string ToString()
        {
            if (Colour == 'W') return "P";
            else return "p";
        }
    }
}