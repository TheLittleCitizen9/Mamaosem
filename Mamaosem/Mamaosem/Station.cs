using Mamaosem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mamaosem
{
    public class Station
    {
        protected int _stationNumber;
        protected Queue<HouseCake> _houseCakes = new Queue<HouseCake>();

        public Station(int stationNumber)
        {
            _stationNumber = stationNumber;
        }

        public void EnterCakeToLine(HouseCake houseCake)
        {
            _houseCakes.Enqueue(houseCake);
        }
    }
}
