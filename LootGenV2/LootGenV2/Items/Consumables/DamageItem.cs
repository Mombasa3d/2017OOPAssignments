using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2;
using LootGenV2.Characters;
using LootGenV2.Interfaces;

namespace LootGenV2.Items.Consumables
{
    class DamageItem : Item, IConsumable
    {
        private static string[] damageItems = new string[]
        {
            "Boreal Wind", "Molten Core", "Static Cloud", "Starfall"
        };
        private int damageValue;

        public int DamageValue { get; }

        public DamageItem() : base()
        {
            Name = damageItems[rando.Next(damageItems.Length)];
            DamageValue = rando.Next(4, 11) * 5;
            Value = DamageValue * 12;
        }

        public void Use(Character input)
        {
            if(input.CurrentHP > 0)
            {
                input.TakeDamage(DamageValue);
            }
            else
            {
                Console.WriteLine(input.Name + " is already incapacitated, " + Name + " does no damage!");
            }

        }

        public string GetDescription()
        {
            return "Spell scroll that casts the " + Name + " spell, causing magic damage to the target.";
        }

        public override string ToString()
        {
            return "===Damage Scroll===\n" +
                "- " + Name + "\n" +
                "- Damage: " + DamageValue + "\n" +
                "- Value: " + Value + "\n" +
                GetDescription();
        }
    }
}
