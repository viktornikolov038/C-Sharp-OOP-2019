using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Company_Roster
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var compareDepartments = new Dictionary<string,List<Employee>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var salaty = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var currentEmployee = new Employee(name,salaty,position,department);
                
                if (input.Length == 5)
                {
                    if (int.TryParse(input[4],out int age))
                    {
                        currentEmployee.Age = age;
                    }
                    else
                    {
                        currentEmployee.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    if (int.TryParse(input[4], out int age))
                    {
                        currentEmployee.Age = age;
                    }
                    else
                    {
                        currentEmployee.Email = input[4];
                        currentEmployee.Age = int.Parse(input[5]);
                    }
                }
                if (!compareDepartments.ContainsKey(department))
                {
                    compareDepartments[department] = new List<Employee>();
                }
                compareDepartments[department].Add(currentEmployee);
            }

            var biggestSalartDepartment = compareDepartments.OrderByDescending(a => a.Value.Sum(e => e.Salary)).ToDictionary(a => a.Key, a => a.Value);
            foreach (var department in biggestSalartDepartment)
            {
                Console.WriteLine($"Highest Average Salary: {department.Key}");
                foreach (var employee in department.Value.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
                }
                break;
            }
        }
    }
}
