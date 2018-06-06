using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);   // instantiating a new employee object

            // new emp object has properties years of service and Office

            Console.WriteLine($"emp years of service : {emp.YearsOfService}");  
            Console.WriteLine($"emp Office : {emp.Office}");
        }
    }
}
