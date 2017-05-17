using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Models
{
    public class Board
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public Chip[,] Grid { get; set; }

        public Board(int column, int rows)
        {
            ColumnCount = column;
            RowCount = rows;
            Grid = new Chip[column, rows];
        }

        public Board()
        {
            ColumnCount = 7;
            RowCount = 6;
            Grid = new Chip[7, 6];
        }

    }
}
