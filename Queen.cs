using System;
using System.Collections.Generic;

namespace Chess
{
    public class Queen : Piece
    {
        public Queen(char colour) : base(colour)
        {

        }

        public override List<string> GetLegalMoves(int[] position, Piece[,] board)
        {
            List<string> legalMoves = new();
            int x = position[0];
            int y = position[1];

            // Bishop movement
            for (int i = 1; i < 8; i++)
                // Check diagonal down right
                if (x + i < 8 && y + i < 8)
                {
                    if (board[x + i, y + i] is Piece && board[x + i, y + i].Colour == this.Colour) break;

                    legalMoves.Add(Convert.ToString(x + i) + Convert.ToString(y + i));

                    if (board[x + i, y + i] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                // check diagonal top left
                if (x - i >= 0 && y - i >= 0)
                {
                    if (board[x - i, y - i] is Piece && board[x - i, y - i].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x - i) + Convert.ToString(y - i));
                    if (board[x - i, y - i] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                // Check diagonal down left
                if (x + i < 8 && y - i >= 0)
                {
                    if (board[x + i, y - i] is Piece && board[x + i, y - i].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x + i) + Convert.ToString(y - i));

                    if (board[x + i, y - i] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                // check diagonal top right
                if (x - i >= 0 && y + i < 8)
                {
                    if (board[x - i, y + i] is Piece && board[x - i, y + i].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x - i) + Convert.ToString(y + i));

                    if (board[x - i, y + i] is Piece) break;
                }

            // Rook movement
            for (int i = 1; i < 8; i++)
                if (x + i < 8)
                {
                    if (board[x + i, y] is Piece && board[x + i, y].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x + i) + Convert.ToString(y));

                    if (board[x + i, y] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                if (y + i < 8)
                {
                    if (board[x, y + i] is Piece && board[x, y + i].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x) + Convert.ToString(y + i));

                    if (board[x, y + i] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                if (x - i >= 0)
                {
                    if (board[x - i, y] is Piece && board[x - i, y].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x - i) + Convert.ToString(y));

                    if (board[x - i, y] is Piece) break;
                }

            for (int i = 1; i < 8; i++)
                if (y - i >= 0)
                {
                    if (board[x, y - i] is Piece && board[x, y - i].Colour == this.Colour) break;
                    legalMoves.Add(Convert.ToString(x) + Convert.ToString(y - i));

                    if (board[x, y - i] is Piece) break;
                }

            return legalMoves;
        }

        public override string ToString()
        {
            if (Colour == 'W') return "Q";
            else return "q";
        }
    }
}