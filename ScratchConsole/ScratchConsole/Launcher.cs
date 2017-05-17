using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgUtilLib;
using ScratchConsole.Models;

namespace ScratchConsole
{
    class Launcher
    {
        static void Main()
        {
            Run();   
        }

        public static void Run()
        {
            HeadlineNotifier helen = new HeadlineNotifier();

            // How to subscribe to a delegate
            helen.HeadlineDelegate += ClassicNewsAnchor.BragaboutNews;
            //helen.HeadlineDelegate += MillenialNewsBlogger.PostStory;
            MillenialNewsBlogger.TrustNewsSource(helen);
            helen.HeadlineDelegate += Stoner.Dude;
            helen.HeadlineDelegate -= Stoner.Dude;
            helen.HeadlineDelegate = null;

            string newsStory = "exit";
            do
            {
                Console.Write("Enter a new Headline: \n");
                helen.Headline = Console.ReadLine();

            } while (!string.IsNullOrEmpty(helen.Headline));
        }
    }
}
