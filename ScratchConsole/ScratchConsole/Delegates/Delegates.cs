using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Delegates
{
    //Delegates
    // * Hold references to other methods in the application
    // * When invoked, the delegate goes through its invocation list 
    //      and calls every method therein, passing the parameter(s) provided
    // * These sort of work like interfaces in a way

    public delegate void StringDelegate(string words);

}
