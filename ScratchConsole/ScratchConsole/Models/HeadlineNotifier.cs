using ScratchConsole.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class HeadlineNotifier
    {
        public StringDelegate HeadlineDelegate;
        private string headline;

        public string Headline
        {
            get { return headline; }
            set
            {
                headline = value;
                if (!string.IsNullOrEmpty(value) && HeadlineDelegate != null)
                {
                    //Line below is the same as this -- > Headliner(Headline);
                    HeadlineDelegate.Invoke(Headline);
                }
            }
        }

    }
}
