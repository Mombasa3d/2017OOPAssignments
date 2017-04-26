using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUtilLib
{
    public class TryParseIntResult
    {
        readonly public bool didParse;
        readonly public int? result;

        //Props
        public bool DidParse => didParse;
        public int? Result => result;

        public TryParseIntResult(bool didParse, int? result)
        {
            this.didParse = didParse;
            this.result = result;
        }
    }
}
