using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 21; // that's a line

            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Jessey Liberty ";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourly Rate : {myHourlyRate}, myName: {myName}");

            myAge = 35;
            x = 20;
            myHourlyRate = 85.00;
            myName = " George Washington";
            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourly Rate : {myHourlyRate}, myName: {myName}");
        }
    }
}
