using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2.Characters;
using LootGenV2.Interfaces;
using LootGenV2;

namespace LootGenerator2.Items.Consumables
{
    class Megalixir :  Item , IConsumable
    {

        public Megalixir(string name, int value) : base(name, value)
        {
            Name = "Megalixir";
            Value = value;
        }
        
        public string GetDescription()
        {
            return "A rare, expensive concoction that fully restores the user's health.";
        }

        public void Use(Character input)
        {
            if (input.CurrentHP <= 0)
            {
                input.CurrentHP = input.BaseHP;
                Console.WriteLine("$[input] recovered all of their health!");
            }
            else
            {

            }
        }
    }
}
