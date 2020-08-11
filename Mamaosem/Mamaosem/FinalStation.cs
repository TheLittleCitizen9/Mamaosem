using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mamaosem.Utils;

namespace Mamaosem
{
    public class FinalStation : Station
    {
        //private HouseCake _houseCake;
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
            Console.WriteLine("Entering cake to storage");
            HouseCake houseCake = _houseCakes.Dequeue();
            ExpirationDate(ref houseCake);
            CreationDate(ref houseCake);

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

        public void ExpirationDate(ref HouseCake houseCake)
        {
            DateTime today = new DateTime();
            houseCake.ExpiryDate = today.AddDays(14);
        }

        public void CreationDate(ref HouseCake houseCake)
        {
            houseCake.ProductionTime = new DateTime();
        }
    }
}
