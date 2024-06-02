using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Chain_of_responsibility
{
    public class ConcreteHandler4 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 4)
                Console.WriteLine("Hi from level 4");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
