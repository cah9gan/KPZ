using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mediator
{
    public class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; } = false;
        public Aircraft(string name, int size) => this.Name = name;
        public void Land() { 
            this.IsTakingOff = true;
            
            Console.WriteLine($"Aircraft {this.Name} is landing."); }
        public void TakeOff() { 
            this.IsTakingOff = false;
            Console.WriteLine($"Aircraft {this.Name} is taking off."); }
    }
}
