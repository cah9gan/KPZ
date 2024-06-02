using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Chain_of_responsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
                Console.WriteLine("Hi from level 1");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
