using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class MillenialNewsBlogger
    {
        public static void PostStory(string allegedTruth)
        {
            Console.WriteLine("Big Brother just said: \"" + allegedTruth + "\"... but its not what you think!");
        }

        public static void TrustNewsSource(HeadlineNotifier source)
        {
            source.HeadlineDelegate += PostStory;
        }
    }


}
