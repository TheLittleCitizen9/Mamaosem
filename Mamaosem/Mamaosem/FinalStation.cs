using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mamaosem.Utils;

namespace Mamaosem
{
    public class FinalStation : Station
    {
        private const int STATION_NUMBER = 2;
        public FinalStation() : base(STATION_NUMBER)
        {
        }

        public void EnterCakeToQueue(HouseCake houseCake)
        {
            EnterCakeToLine(houseCake);
        }

        public void SaveCakeInStorage()
        {
            HouseCake houseCake = _houseCakes.Dequeue();
            houseCake.ExpiryDate = SetExpirationDate(houseCake.ExpiryDate);
            Console.WriteLine("Entering cake to storage");
            houseCake.ProductionTime = SetCreationDate();

            string path = @"storage.storage";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(houseCake.ToString());
            }
        }

        public void ReadFromStorage()
        {
            string path = @"storage.storage";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public DateTime SetExpirationDate(DateTime expiryDate)
        {
            DateTime today = new DateTime();
            expiryDate = today.AddDays(14);
            return expiryDate;
        }

        public DateTime SetCreationDate()
        {
            return new DateTime();
        }
    }
}
