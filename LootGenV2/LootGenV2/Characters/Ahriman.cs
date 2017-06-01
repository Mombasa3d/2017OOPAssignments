using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    class Voidsent : Character
    {

        private int voidShield = 8;
        private string[] voidsentNames = new string[]
        {
            "Ahriman", "Mindflayer", "Dark Flan", "Voidriga", "Fel Tonberry",
        };

        public Voidsent() : base()
        {
            Name = voidsentNames[statRando.Next(voidsentNames.Length)];
            StrMod = statRando.Next(2, 10);
            IntMod = statRando.Next(5, 16);
            DexMod = statRando.Next(1, 6);
            BaseHP = 15 * StrMod;
            CurrentHP = BaseHP;
            StrBase = 10;
            DexBase = 7;
            IntBase = 2;
            DamageReduction = voidShield;
        }

        public override int Attack()
        {
            return Strength + Intelligence;

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
                CurrentHP -= wound;
                Console.WriteLine(Name + " has taken " + wound + " damage!");
                return wound;
            }
        }

        public override string ToString()
        {
            return "- " + Name + "\n" +
             "== Class: Voidsent ==\n" +
             "- HP: " + CurrentHP + "/" + BaseHP + "\n" +
             "- Strength: " + Strength + "\n" +
             "- Dexterity: " + Dexterity + "\n" +
             "- Intelligence: " + Intelligence + "\n" +
             "- Armor: Void Shielding | DR: " + DamageReduction + "\n" +
             "- Weapon: N/A | Damage Bonus: N/A";
            ;
        }
    }
}
