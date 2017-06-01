using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenV2.Characters;

namespace LootGenV2.Interfaces
{
    interface IConsumable
    {

        void Use(Character input);
        string GetDescription();

    }
}
