using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player('W');
            Player player2 = new Player('B');

            int[] selectedPiece;
            while (true)
            {
                Graphics.DrawBoard(board.BoardState);
                selectedPiece = player1.SelectPiece(board.BoardState);
                Graphics.DrawBoard(board.BoardState, selectedPiece);
                board.MovePiece(selectedPiece);
                Graphics.DrawBoard(board.BoardState);
                selectedPiece = player2.SelectPiece(board.BoardState);
                Graphics.DrawBoard(board.BoardState, selectedPiece);
                board.MovePiece(selectedPiece);
            }
        }
    }
}
