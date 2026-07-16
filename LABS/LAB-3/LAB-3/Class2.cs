using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3
{
    internal class Employee
    {

        int Emp_ID;
        String Name;
        String Department;
        String Designation;
        int Salary;
        
       public void GetEmpDetails()
        {
            Console.WriteLine("Enter Employee ID : ");
            Emp_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department : ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter EMployee Designation : ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Employee salary :  ");
            Salary = Convert.ToInt32(Console.ReadLine());

        }


        public void DisplayEmpDetails()
        {
            Console.WriteLine($"Employee ID : {Emp_ID} ");
            Console.WriteLine($"Employee Name : {Name} ");
            Console.WriteLine($"Employee Department : {Department} ");
            Console.WriteLine($"Employee Designation : {Designation} ");
            Console.WriteLine($"Employee Salary : {Salary} ");
        }


    }
}
