using System;
using System.Collections.Generic;
using System.Text;
using Mamaosem.Utils;

namespace Mamaosem
{
    public class ProductionLine
    {

        private LinkedList<Station> _productionLine = new LinkedList<Station>();

        public ProductionLine(Station station)
        {
            _productionLine.AddLast(station);
        }
        public void PerformLineStep(HouseCake houseCake)
        {
            houseCake = ProductionLineService.PerformProdLineStep(2, houseCake);
            FinalStation finalStation = new FinalStation();
            finalStation.EnterCakeToQueue(houseCake);
            finalStation.SaveCakeInStorage();
            Console.WriteLine(houseCake.ToString());
        }

        public HouseCake CreateNewCake()
        {
            HouseCake houseCake = new HouseCake();
            return houseCake;
        }

        public void StartProductionLine(HouseCake houseCake)
        {
            Console.WriteLine("strated working on the cake");
            houseCake = ProductionLineService.PerformProdLineStep(1, houseCake);
            Console.WriteLine(houseCake.ToString());
            PerformLineStep(houseCake);
        }
    }
}
