using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int myLittleHorses = 0;   //initialize variable

            do
            {
                Console.WriteLine($"myLittleHorses  = {myLittleHorses}");   //will run at least once
                myLittleHorses++;   // increment by 1
            } while (myLittleHorses < 5);    // stop condition
        }
    }
}
