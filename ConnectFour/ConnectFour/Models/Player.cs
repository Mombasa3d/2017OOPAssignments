using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Enums;

namespace ConnectFour.Models
{
    class Player
    {
        Random rando = new Random();
        private string Name { get; set; }
        private Piece PlayerPiece { get; set; }
        private PType playerType;
        private string[] defaults = new string[]
        {
            "Bahamut", "Shiva", "Ifrit", "Ramuh", "Garuda", "Titan"
        };

        public Player(string name, Piece pColor, PType organic)
        {
            Name = (string.IsNullOrEmpty(name)) ? defaults[rando.Next(0, defaults.Length)] : name;  
            PlayerPiece = pColor;
            playerType = organic;

        }




    }
}
