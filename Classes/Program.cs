using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.   
             Company mysteryIncorporated = new Company ("Mystery Incorporated");

            // Create three employees
            Employee employee1 = new Employee("Scooby", "Mascot", new DateTime(1969, 9, 13));
            Employee employee2 = new Employee("Shaggy", "Assistant Investigator", new DateTime(1969, 9, 13));
            Employee employee3 = new Employee("Thelma","Lead Investigator", new DateTime(1969, 9, 13));

            // Assign the employees to the company
              mysteryIncorporated.AddEmployee(employee1);
              mysteryIncorporated.AddEmployee(employee2);
              mysteryIncorporated.AddEmployee(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            Console.WriteLine($"Company:{mysteryIncorporated.Name}");
            Console.WriteLine("Employees:");
            foreach (Employee employee in mysteryIncorporated.Employees)
            {
                Console.WriteLine($"{employee.Name}");
            }
            
            mysteryIncorporated.ListEmployees();
        }
    }
}



