using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Enums;
using ConnectFour.Models;

namespace ConnectFour
{
    public class ConnectoFouro
    {
        private Board activeBoard;
        private Actor player1;
        private Actor player2;

        //private static void ClearBoard(Piece[,] bord)
        //{
        //    for (int i = 0; i < boardCol; i++)
        //    {
        //        for (int j = 0; j < boardRows; j++)
        //        {
        //            bord[i, j] = Piece.None;
        //        }
        //    }
        //}

        public void AITurn(Actor bot)
        {

        }

        public bool CheckWinConditions()
        {

        }

        public void HumanTurn(Actor meatbag)
        {

        }

        public void PlaceChip(Actor p, Board b, int column)
        {
            if(b.Grid[column, 0] != Chip.None)
            {
                Console.WriteLine("Column is full!");
            }
            else
            {

            }
        }

        public void UpdateLoop()
        {

        }
    }
}
