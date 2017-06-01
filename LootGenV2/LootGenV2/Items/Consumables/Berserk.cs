 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2.Interfaces;
using LootGenV2;
using LootGenV2.Characters;

namespace LootGenV2.Items.Consumables
{
    class Berserk : Item, IConsumable
    {
        private int rageStr;
        private int rageHP;
        private int rageInt;
        private int rageDex;
        private string[] rageNames = new string[]
        {
            "Bloodlust", "Enrage", "Bacchus' Wine","Infinite Duress"
        };

        public int RageStr { get; }
        public int RageHP { get; }
        public int RageInt { get; }
        public int RageDex { get; }

        public Berserk() : base()
        {
            Name = rageNames[rando.Next(rageNames.Length)];
            
            RageStr = rando.Next(4,9);
            RageDex = rando.Next(1, RageStr);
            RageInt = rando.Next(3, 8) * -1;
            RageHP = rando.Next(2, 10) * (RageStr / 2);
            Value = (RageStr * 20);
        }

        public void Use(Character input)
        {
            if (input.CurrentHP <= 0)
            {
                Console.WriteLine(input.Name + " is dead, " + Name + " has no effect!");
            }
            else
            {
                input.TakeDamage(RageHP);
                input.StrMod += RageStr;
                input.IntMod += RageInt;
                input.DexMod += RageDex;
                Console.WriteLine(input.Name + " has flown into a rage!");
            }
        }

        public string GetDescription()
        {
            return "Spell scroll that casts a berserk type spell on the user,\n raising Str and Dex but reducing Int and sapping HP.";
        }

        public override string ToString()
        {
            return "===Berserk Scroll===\n" +
                "- " + Name + "\n" +
                "- Value:" +  Value + "\n" +
                GetDescription() + "\n" +
                "== Boosts ==\n" +
                "- Str: " + RageStr + "\n" +
                "- Dex: " + RageDex + "\n" +
                "- Int: " + RageInt + "\n" +
                "- Self Damage: " + RageHP + "\n";
        }
    }
}
