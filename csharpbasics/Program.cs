using System;

namespace csharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to c# Bsics");


            Employee emp_1 = new Employee();
            emp_1.SetEmployeeID(12345);
            emp_1.SetEmployeeName("upeksha");
            emp_1.GetEmployeeDetails();
        }
    }
}
