using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class FlashCard
    {
        private string Keyword { get; set; }
        private string Definition { get; set; }

        public FlashCard(string key, string def)
        {
            Keyword = key;
            Definition = def;
        }
    }
}
