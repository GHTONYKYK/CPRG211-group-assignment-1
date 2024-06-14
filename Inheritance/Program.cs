using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string[] lines = File.ReadAllLines("res/employees.txt");

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                string id = parts[0];
                string name = parts[1];
                string sin = parts[2];
                double hourlyRate = double.Parse(parts[3]);
                int workHours = int.Parse(parts[4]);

                switch (id[0])
                {
                    case "0":
                        employees.Add(new Salaried(id, name, sin));
                        break;
                    case "5":
                        employees.Add(new Wages(id, name, sin, hourlyRate, workHours));
                        break;
                    case "8":
                        employees.Add(new PartTime(id, name, sin, hourlyRate, workHours));
                        break;
                    default:
                        throw new Exception("Invalid employee ID");
                }
            }
            Console.WriteLine($"Total Employees: {employees.Count}");
            Console.WriteLine($"Average Weekly Pay: {WeeklyPay(employees):C}");
        }

        static double WeeklyPay(List<Employee> employees)
        {
            double totalPay = 0;
            foreach (var employee in employees)
            {
                totalPay += employee.WeeklyPay();
            }
            return employees.Count > 0 ? totalPay / employees.Count : 0;
        }
    }
}




