using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myLittleHorses = 0;   // initialize
            while (myLittleHorses < 10)  // while condition
            {
                Console.WriteLine($"myLittleHorses = {myLittleHorses}");
                myLittleHorses++; // everytime you write to console , increment myLittleHorses
            }
        }
    }
}
