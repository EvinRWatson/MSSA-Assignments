using System;
namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            doMission("Clear LA");
        }

        public static void doMission(string missionName)
        {
            Console.WriteLine($"Commencing Mission: {missionName}");
            Unit MAC2 = new Platoon("Mac 2", 40, "Route Clearance", "USMC");
            Console.WriteLine($"Unit assigned: {MAC2.name}");
            Personnel PltSgt = new Marine("Watson", 21, "Platoon Sergeant", new M4(), MAC2);

            Console.WriteLine($"{MAC2.name} leaves FOB Sierra northbound bn I5 to clear the route to Long Beach.");
            Personnel Engineer = new Marine("Inman", 19, "GP", new M4(), MAC2);
            Console.WriteLine($"All of a sudden when clearing through Compton, LCpl {Engineer.name} spots what appears to be a pressure " +
                              $"actuated DFC of the side of the road.");
            Console.WriteLine($"{PltSgt.name} calls EOD to investigate");
            Personnel EODtech = new Marine("Darius", 26, "EOD Tech", new Weapon(), new Unit());
            Console.WriteLine($"The EOD Tech {EODtech.name} assures us that it is nothing and us Engineers are getting complacent");
            Console.WriteLine($"Regardless, {MAC2.name} finishes the mission and goes home to drink beer");
            Personnel SupremeCommander = new Spaceman("Dan", 40, "Our benevolent overlord", null, null);
            Console.WriteLine($"Supreme Commander {SupremeCommander.name} gives everyone any award for their bravery in the streets of Southern California");
        }
    }
}
