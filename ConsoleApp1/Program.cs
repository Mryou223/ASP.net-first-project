// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

Console.WriteLine("Hello, World!");
var context = new HrContext();
var numOfEmps = context.Employees.Count();
Console.WriteLine("num of employee:  "+ numOfEmps);

var emps = context.Employees.Where(e => e.Salary >= 15000);
foreach (var emp in emps)
{
    Console.WriteLine($" name is { emp.FirstName} { emp.LastName},Salary: { emp.Salary}");
}

HrContext hrContext = new HrContext();  

var employees = hrContext.Employees
    .w