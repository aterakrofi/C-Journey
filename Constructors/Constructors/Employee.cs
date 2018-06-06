using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee    //public variable
    {

        public int YearsOfService { get; set; }   // property of employee class

        public int Office { get; set; }            // property of employee class


        public Employee(int years , int office)                          // Explicit constructor

        {

            YearsOfService = years;
            Office = office;
        }
    }
}
