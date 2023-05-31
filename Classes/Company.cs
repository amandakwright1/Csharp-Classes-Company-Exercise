using System;

namespace Classes
{
    public class Company
    {

       public string Name {get; set;}
    public List <Employee> Employees{get; set;}

    public Company(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void ListEmployees()
    {
        foreach (Employee employee in Employees)
        {
            string report = $"{employee.Name} works for {Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}.";
            Console.WriteLine(report);
        }
    }
    }
}