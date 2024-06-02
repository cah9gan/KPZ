using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Chain_of_responsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
                Console.WriteLine("Hi from level 3");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
