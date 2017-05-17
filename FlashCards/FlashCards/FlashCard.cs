using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class FlashCard
    {
        public string Keyword { get; set; }
        public string Definition { get; set; }
        public int AttemptCount { get; set; }
        public int SuccessCount { get; set; }

        public FlashCard(string key, string def)
        {
            if(string.IsNullOrEmpty(key) || string.IsNullOrEmpty(def))
            {
                throw new ArgumentException("Card name and/or definition cannot be empty nor null!");
            }
            Keyword = key;
            Definition = def;
            AttemptCount = 0;
            SuccessCount = 0;
            
        }


        public float Mastery()
        {
            float rating = (this.SuccessCount / this.AttemptCount) * 100;
            return rating;
        }

        public string ResetMastery()
        {
            AttemptCount = 0;
            SuccessCount = 0;
            return ("Attempt count and success count reset!");
        }
    }
}
