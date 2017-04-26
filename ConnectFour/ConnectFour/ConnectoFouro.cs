using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Enums;

namespace ConnectFour
{
    class ConnectoFouro
    {
        private static int boardCol = 7;
        private static int boardRows = 6;
        public static Piece[,] board = new Piece[7, 6];

        private static void ClearBoard(Piece[,] bord)
        {
            for(int i = 0; i < boardCol; i++)
            {
                for(int j = 0; j < boardRows; j++)
                {
                    bord[i, j] = Piece.None;
                }
            }
        }

        public static void PrintBoard(Piece[,] bord, bool colDisp)
        {
            if(colDisp)
            {
                Console.WriteLine(" 1 2 3 4 5 6 7");
            }
            for(int i = 0 ; i < boardCol; i++)
            {
                String bordPrint = "";
                for(int j = 0; j < boardRows; j++)
                {
                    bordPrint += "|";
                    bordPrint += (bord[i, j] == Piece.None) ? " " : bord[i,j].ToString();
                }
                Console.WriteLine(bordPrint + "|");
            }
        }
    }
}
