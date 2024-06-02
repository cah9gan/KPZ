using ClassLibrary.Blackjack;
using ClassLibrary.Chain_of_responsibility;
using ClassLibrary.Mediator;
// Chain of responsibility
Console.WriteLine("\t---Chain of responsibility---");

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();
Handler h4 = new ConcreteHandler4();

h1.SetNext(h2);
h2.SetNext(h3);
h3.SetNext(h4);
h4.SetNext(null);

while (true)
{
    Console.WriteLine("Choose level (1-4)");

    int level;

    if (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 4)
    {
        Console.WriteLine("Bad level input");
        continue;
    }

    h1.HandleRequest(level);
    break;
}

// Mediator
Console.WriteLine("\t---Mediator---");

var runway1 = new Runway();
var runway2 = new Runway();

var aircraft1 = new Aircraft("Aircraft 1", 1);
var aircraft2 = new Aircraft("Aircraft 2", 2);
var aircraft3 = new Aircraft("Aircraft 3", 3);

var commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2, aircraft3 });

commandCentre.RequestLanding(aircraft1);
commandCentre.RequestLanding(aircraft2);
commandCentre.RequestLanding(aircraft3);

commandCentre.RequestTakeOff(aircraft1);
commandCentre.RequestTakeOff(aircraft1);

// Observer/Strategy
Console.WriteLine("\t---Observer/Strategy---");

Game MyGame = new Game();
MyGame.Start();