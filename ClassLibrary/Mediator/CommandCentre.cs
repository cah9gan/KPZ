using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing");

            foreach (var runway in _runways)
            {
                if(aircraft.IsTakingOff)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off, cannot land.");
                    return;
                }
                if (runway.IsAvailable)
                {
                    runway.IsAvailable = false;
                    aircraft.Land();
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}");
                    return;
                }
            }

            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting takeoff");

            if(!aircraft.IsTakingOff)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not taking off, cannot take off.");
                return;
            }

            foreach (var runway in _runways)
            {
                if (!runway.IsAvailable)
                {
                    runway.IsAvailable = false;
                    aircraft.TakeOff();
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}");
                    return;
                }
            }

            Console.WriteLine($"Could not take off, all runways are busy.");
        }
    }
}
