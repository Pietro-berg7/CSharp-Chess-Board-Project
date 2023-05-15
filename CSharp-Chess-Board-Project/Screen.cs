﻿using CSharp_Chess_Board_Project.board;

namespace CSharp_Chess_Board_Project
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
