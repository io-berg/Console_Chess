using System.Collections.Generic;

namespace Chess
{
    public abstract class Piece
    {
        char colour;

        public char Colour 
        {
            get
            {
                return colour;
            }
        }

        public Piece(char colour)
        {
            this.colour = colour;
        }
        public abstract List<string> GetLegalMoves(int[] position, Piece[,] board);
    }
}