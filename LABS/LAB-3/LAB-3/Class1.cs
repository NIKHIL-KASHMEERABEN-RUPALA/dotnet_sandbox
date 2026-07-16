using System;
using System.Collections.Generic;
using System.Text;



namespace LAB_3
{
    internal class Faculty
    {
        int ID;
        string Name;
        int Age;
        int Weight;
        int Height;
        public void GetFacultyDetails()
        {

            Console.WriteLine("Enter Faculty ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Faculty Name :  ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Age of Faculty :  ");
            Age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the weight of Faculty :  ");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of Faculty :    ");
            Height = Convert.ToInt32(Console.ReadLine());


        }


        void DisplayFacultyDetails()
        {
            Console.WriteLine($"Faculty ID : {ID} ");
            Console.WriteLine($"Faculty Name : {Name} ");
            Console.WriteLine($"Faculty Age : {Age}");
            Console.WriteLine($"Faculty Weight : {Weight} "); 
            Console.WriteLine($"Faculty Height is : {Height} ");
        }



    }


}
