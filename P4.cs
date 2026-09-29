using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Aditya", "IT", 50000),
            new Employee("Rahul", "HR", 40000),
            new Employee("Priya", "IT", 60000),
            new Employee("Neha", "HR", 45000),
            new Employee("Arjun", "Sales", 70000)
        };

        Dictionary<string, decimal> departmentSalary =
            new Dictionary<string, decimal>();

        foreach (Employee employee in employees)
        {
            if (departmentSalary.ContainsKey(employee.Department))
            {
                departmentSalary[employee.Department] += employee.Salary;
            }
            else
            {
                departmentSalary[employee.Department] = employee.Salary;
            }
        }

        Console.WriteLine("Department Salary Totals:");

        foreach (KeyValuePair<string, decimal> pair in departmentSalary)
        {
            Console.WriteLine(
                $"{pair.Key}: {pair.Value}"
            );
        }

        string highestPayingDepartment = "";
        decimal highestSalary = 0;

        foreach (KeyValuePair<string, decimal> pair in departmentSalary)
        {
            if (pair.Value > highestSalary)
            {
                highestSalary = pair.Value;
                highestPayingDepartment = pair.Key;
            }
        }

        Console.WriteLine();
        Console.WriteLine(
            $"Highest-paying department: {highestPayingDepartment}"
        );
        Console.WriteLine(
            $"Total salary: {highestSalary}"
        );
    }
}