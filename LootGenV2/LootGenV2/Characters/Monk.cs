using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    public class Monk : Character
    {
        string[] monkNames = new string[]
            {
                "Kharazim", "Galuf", "Yda", "Yang", "Sabin"
            };
        public Monk() : base()
        {
            base.Name = monkNames[statRando.Next(monkNames.Length)];
            base.StrBase = 12;
            base.StrMod = 7;
            base.DexBase = 10;
            base.DexMod = 5;
            base.IntBase = 2;
            base.IntMod = -4;
            base.BaseHP = StrBase * 10;
            base.CurrentHP = baseHP;
            base.CharWep = new Weapon();
            base.CharArmor = new Armor();
            base.DamageReduction = charArmor.DamageReduction;
            
        }

        public override int Attack()
        {
            return Strength;
        }

        public override int TakeDamage(int wound)
        {
            if (CurrentHP <= 0)
            {
                Console.WriteLine(Name + " is already dead!");
                return 0;
            }
            else
            {
                int damage = (wound < DamageReduction) ? 0 : wound - DamageReduction;
                CurrentHP = ((CurrentHP - damage) < 0) ? 0 : CurrentHP - damage;
                Console.WriteLine(Name + " has taken " + damage + " damage!");
                return damage;
            }
        }

        public override string ToString()
        {
            return "- " + Name + "\n" +
             "== Class: Monk ==\n" +
             "- HP: " + CurrentHP + "/" + BaseHP + "\n" +
             "- Strength: " + Strength + "\n" +
             "- Dexterity: " + Dexterity + "\n" +
             "- Intelligence: " + Intelligence + "\n" +
             "- Total Damage Reduction: " + DamageReduction + "\n" +
             charArmor + "\n" +
             charWep +  "\n";
        }
    }
}
