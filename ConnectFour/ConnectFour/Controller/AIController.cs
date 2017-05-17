using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Models;

namespace ConnectFour.Controller
{
    class AIController
    {
        public static int DetermineMove(Board bord)
        {
            Random rando = new Random();
            return rando.Next(bord.ColumnCount);
        }
    }
}
