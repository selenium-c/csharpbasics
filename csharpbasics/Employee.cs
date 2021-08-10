using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasics
{
    public class Employee
    {
        int emp_ID;
        string emp_Name = null;
        public void SetEmployeeID(int Id)
        {
            emp_ID = Id;
        }
        public void SetEmployeeName(string name)
            {
            emp_Name = name;
        }
           public void GetEmployeeDetails()
        {
            Console.WriteLine(" EMP ID: " + emp_ID);
            Console.WriteLine("EMP NAME: " + emp_Name);
        }
          
    }
}
