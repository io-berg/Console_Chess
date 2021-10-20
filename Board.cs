using System;
using System.Collections.Generic;

namespace Chess
{
    public class Board
    {
        Piece[,] boardState = new Piece[8, 8];

        public Piece[,] BoardState { get => boardState; set => boardState = value; }

        public Board()
        {
            boardState[0, 0] = new Rook('B');
            boardState[0, 1] = new Knight('B');
            boardState[0, 2] = new Bishop('B');
            boardState[0, 3] = new Queen('B');
            boardState[0, 4] = new King('B');
            boardState[0, 5] = new Bishop('B');
            boardState[0, 6] = new Knight('B');
            boardState[0, 7] = new Rook('B');

            boardState[1, 0] = new Pawn('B');
            boardState[1, 1] = new Pawn('B');
            boardState[1, 2] = new Pawn('B');
            boardState[1, 3] = new Pawn('B');
            boardState[1, 4] = new Pawn('B');
            boardState[1, 5] = new Pawn('B');
            boardState[1, 6] = new Pawn('B');
            boardState[1, 7] = new Pawn('B');

            boardState[6, 0] = new Pawn('W');
            boardState[6, 1] = new Pawn('W');
            boardState[6, 2] = new Pawn('W');
            boardState[6, 3] = new Pawn('W');
            boardState[6, 4] = new Pawn('W');
            boardState[6, 5] = new Pawn('W');
            boardState[6, 6] = new Pawn('W');
            boardState[6, 7] = new Pawn('W');

            boardState[7, 0] = new Rook('W');
            boardState[7, 1] = new Knight('W');
            boardState[7, 2] = new Bishop('W');
            boardState[7, 3] = new Queen('W');
            boardState[7, 4] = new King('W');
            boardState[7, 5] = new Bishop('W');
            boardState[7, 6] = new Knight('W');
            boardState[7, 7] = new Rook('W');
        }

        // for testing pieces
        public Board(char c)
        {
            if (c == 'K') boardState[4, 4] = new King('W');
            else if (c == 'B') boardState[4, 4] = new Bishop('W'); boardState[1, 1] = new King('B'); boardState[6, 6] = new Pawn('W');
        }
        public void MovePiece(int[] selectedPiece)
        {
            Piece piece = BoardState[selectedPiece[0], selectedPiece[1]];

            System.Console.Write("Select where to move your piece (ex: b4):");
            char[] userInput = Console.ReadLine().ToUpper().ToCharArray();

            int column = userInput[0] - 'A';

            int row = userInput[1] - '1';
            if (row == 7) row = 0;
            else if (row == 6) row = 1;
            else if (row == 5) row = 2;
            else if (row == 4) row = 3;
            else if (row == 3) row = 4;
            else if (row == 2) row = 5;
            else if (row == 1) row = 6;
            else if (row == 0) row = 7;

            List<string> legalMoves = piece.GetLegalMoves(selectedPiece, boardState);

            foreach (string move in legalMoves)
                if (column.ToString() + row.ToString() == move[1].ToString() + move[0].ToString())
                {
                    boardState[row, column] = piece;
                    boardState[selectedPiece[0], selectedPiece[1]] = null;
                    if (piece is Pawn p) { p.HasMoved = true; }
                    if (piece is King k) { k.HasMoved = true; }
                    if (piece is Rook r) { r.HasMoved = true; }

                    break;
                }
        }
    }
}