using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2.Characters;
using LootGenV2.Interfaces;
using LootGenV2;

namespace LootGenV2.Items.Consumables
{
    class FullHeal :  Item , IConsumable
    {

        public FullHeal() : base()
        {
            Name = "FullHeal";
            Value = 500;
        }
        
        public string GetDescription()
        {
            return "A rare, expensive concoction that fully restores the user's health.";
        }

        public void Use(Character input)
        {
            if (input.CurrentHP > 0)
            {
                input.CurrentHP = input.BaseHP;
                Console.WriteLine(input.Name + " has recovered all of their health!");
            }
            else if (input.CurrentHP == input.BaseHP)
            {
                Console.WriteLine(input.Name + " is already at full health! " + Name + " has no effect!");
            }
            else
            {
                Console.WriteLine(input.Name + " is KO'd, " + Name + " has no effect!");
            }
        }

        public override string ToString()
        {
            return "=== Full Heal ===\n" +
                "- Value: " + Value + "\n" +
                "- " + GetDescription();
        }
    }
}
