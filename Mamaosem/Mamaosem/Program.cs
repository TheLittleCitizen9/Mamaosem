using Mamaosem.Utils;
using System;

namespace Mamaosem
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalStation finalStation = new FinalStation();
            ProductionLine productionLine = new ProductionLine(finalStation);
            HouseCake houseCake = productionLine.CreateNewCake();
            Console.WriteLine(houseCake.ToString());
            productionLine.StartProductionLine(houseCake);
            
        }
    }
}
