using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2.Characters
{
    class Ahriman : Character
    {
        public override int Attack()
        {
            Console.WriteLine("Darn, I've been hacked.");
            throw new NotImplementedException();
        }

        public override int TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
