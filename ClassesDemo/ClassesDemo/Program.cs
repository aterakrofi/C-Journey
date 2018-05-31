using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)  // Main driver to run program
        {

            Employee tony = new Employee();                        // instantiate new object employee
            tony.Income = 150000;                                  // Set the employee property:: income(150k) to tony
            tony.YearsOfService = 8;                               // Set the employee property :: years of service(8) to tony
            tony.SetRating(Employee.Rating.excellent);             // Set the method SetRating with enum parameters to tony
            tony.CalculateRaise();                                 // Tony object calls the method Calculate raise 



        }
    }
    
        // NEW CLASS
        public class Employee       

    {
        //ENUM TYPE
        public enum Rating   // enum type with parameters
        {
            poor,
            good,
            excellent
        }

        //
        private Rating rating;                  // rating is camelCase with lowercase letter

        //PROPERTY
        public double Income { get; set; }      // property of a class- income
        
        //PROPERTY
        public int YearsOfService { get; set; } // property of a class - years of service

        //METHOD
        public void SetRating(Rating rating)    // Create a Method and parse it the enum type rating
        {
            this.rating = rating;              // why ???
        }

        //METHOD
        public void CalculateRaise()                  // Create a Method which performes some calculations
        {
            double baseRaise = Income * .05;          // baseRaise is a field ??
            double bonus = YearsOfService * 1000;
            Income += baseRaise + bonus;

            //SWITCH
            switch (rating)                          // Switch based on the rating

            {
                case Rating.poor:
                    Income -= YearsOfService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearsOfService * 500;
                    break;

            }

            Console.WriteLine($"New income is {Income}");
        }

    }
}
