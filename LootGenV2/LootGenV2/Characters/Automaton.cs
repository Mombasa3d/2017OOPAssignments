using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    class Automaton : Character
    {
        private int ironBody = 6;
        private int integratedWeaponry = 3;
        private string[] automataNames = new string[]
        {
            "Iron Giant", "Mimic", "Magitek Enforcer", "Clockwork Knight"
        };


        public Automaton() : base()
        {
            Name = automataNames[statRando.Next(automataNames.Length)];
            StrBase = 10;
            DexBase = 7;
            IntBase = 2;
            StrMod = statRando.Next(7, 15);
            DexMod = statRando.Next(5, 12);
            IntMod = statRando.Next(2, 7);
            DamageReduction = ironBody;
            BaseHP = 15 * StrMod;
            CurrentHP = BaseHP;
        }

        public override int Attack()
        {
            return Strength + (Dexterity / 2) + integratedWeaponry;
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
                CurrentHP -= damage;
                Console.WriteLine(Name + " has taken " + damage + " damage!");
                return damage;
            }
        }

        public override string ToString()
        {
            return "- " + Name + "\n" +
             "== Class: Automaton ==\n" +
             "HP: " + CurrentHP + "/" + BaseHP + "\n" +
             "Strength: " + Strength + "\n" +
             "Dexterity: " + Dexterity + "\n" +
             "Intelligence: " + Intelligence + "\n" +
             "Armor: Iron Body | DR: " + DamageReduction + "\n" +
             "Weapon: Integrated Weaponry | Damage Bonus: " + integratedWeaponry + "\n";
              
        }
    }
}
