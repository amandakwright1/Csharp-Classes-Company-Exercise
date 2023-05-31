using System;

namespace Classes
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string title, DateTime startDate)
        {
            Name = name;  //this.Name is the property of the class. Or could've just lowercased the name so it would be different.
            Title = title;
            StartDate = startDate;
        }
    }
}





