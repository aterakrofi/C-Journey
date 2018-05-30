using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConstants
{
    class Program
    {
        enum Ages  // declared at the class level
        {
            oldEnough = 5,
            canDrink = 21,
            tooOld = 90
        }
        static void Main(string[] args)
        {

            const int age = 20;      // declare constant age
            if (age < (int)Ages.oldEnough)  // Ages can attach variables from the enum 
            {
                Console.WriteLine("Sorry, you are too young ot play");
           
            }else if(age < (int)Ages.canDrink)
            {
                Console.WriteLine("You can play, but no drinking!");
            }else if( age < (int)Ages.tooOld)
            {
                Console.WriteLine("Have Fun!");
            } else
            {
                Console.WriteLine("How about a nice nap?");
            }

        }
    }
}
