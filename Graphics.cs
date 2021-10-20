using System;
using System.Collections.Generic;

namespace Chess
{
    public static class Graphics
    {
        public static void DrawBoard(Piece[,] boardState)
        {
            ConsoleColor lastColor = ConsoleColor.Black;
            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.Write(8 - i + "| ");

                for (int j = 0; j < 8; j++)
                {
                    if (lastColor == ConsoleColor.Black)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        lastColor = ConsoleColor.DarkGray;
                    }
                    else if (lastColor == ConsoleColor.DarkGray)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        lastColor = ConsoleColor.Black;
                    }
                    if (boardState[i,j] is Piece) System.Console.Write(boardState[i,j] + " ");
                    else System.Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (lastColor == ConsoleColor.Black)
                    lastColor = ConsoleColor.DarkGray;
                else if (lastColor == ConsoleColor.DarkGray)
                    lastColor = ConsoleColor.Black;
                    
                System.Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.Write("   ---------------");
            System.Console.WriteLine("");
            System.Console.Write("   ");
            char ch = 'A';
            for (int i = 0; i < 8; i++)
            {
                System.Console.Write(ch + " ");
                ch++;
            }
            System.Console.WriteLine();
        }
        public static void DrawBoard(Piece[,] boardState, int[] selectedPiece)
        {
            List<string> legalmoves = boardState[selectedPiece[0],selectedPiece[1]].GetLegalMoves(selectedPiece, boardState);
            ConsoleColor lastColor = ConsoleColor.Black;
            for (int i = 0; i < 8; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.Write(8 - i + "| ");

                for (int j = 0; j < 8; j++)
                {
                    if (lastColor == ConsoleColor.Black)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        lastColor = ConsoleColor.DarkGray;
                    }
                    else if (lastColor == ConsoleColor.DarkGray)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        lastColor = ConsoleColor.Black;
                    }
                    bool legalMoveFound = false;
                    foreach (string move in legalmoves)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        if (i.ToString() == move[0].ToString() && j.ToString() == move[1].ToString())
                        {
                            if (boardState[i,j] is Piece) System.Console.Write(boardState[i,j].ToString() + " ");
                            else System.Console.Write("- ");
                            legalMoveFound = true;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (i == selectedPiece[0] && j == selectedPiece[1] && legalMoveFound == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (boardState[i,j] is Piece) System.Console.Write(boardState[i,j] + " ");
                        else System.Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (legalMoveFound == false)
                    {
                        if (boardState[i,j] is Piece) System.Console.Write(boardState[i,j] + " ");
                        else System.Console.Write("  ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (lastColor == ConsoleColor.Black)
                    lastColor = ConsoleColor.DarkGray;
                else if (lastColor == ConsoleColor.DarkGray)
                    lastColor = ConsoleColor.Black;
                    
                System.Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.Write("   ---------------");
            System.Console.WriteLine("");
            System.Console.Write("   ");
            char ch = 'A';
            for (int i = 0; i < 8; i++)
            {
                System.Console.Write(ch + " ");
                ch++;
            }
            System.Console.WriteLine();
        }
    }
}