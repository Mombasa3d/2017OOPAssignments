using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Enums;

namespace ConnectFour.Models
{
    class Actor
    {
        private Random rando = new Random();
        private string Name { get; set; }
        private Chip PlayerColor { get; set; }
        private bool IsHuman { get; set; }
        private string[] defaults = new string[]
        {
            "Bahamut", "Shiva", "Ifrit", "Ramuh", "Garuda", "Titan"
        };

        public Actor(string name, Chip pColor, bool organic)
        {
            Name = (string.IsNullOrEmpty(name)) ? defaults[rando.Next(0, defaults.Length)] : name;  
            PlayerColor = pColor;
            IsHuman = organic;

        }




    }
}
