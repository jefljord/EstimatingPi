using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PiDart
{
    class FindPiThread
    {
        private int totDart;
        public int printTot
        {
            get
            {
                return totDart;

            }
        }

        private int hitDarts;
        public int printHits
        {
            get
            {
                return hitDarts;

            }
        }
        

        Random ran;

        public FindPiThread(int xdarts)
        {
            hitDarts = 0;
            ran = new Random();
            totDart = xdarts;

        }

        public void throwDarts()
        {
            for(int i = 0; i < totDart; i++)
            {               
      
                double piave = ran.NextDouble();
                double seconddouble = ran.NextDouble();

                if (Math.Sqrt((Math.Pow(piave, 2) + Math.Pow(seconddouble, 2))) <= 1)
                {
                    hitDarts++;
                }
                
            }


        }
    }
}