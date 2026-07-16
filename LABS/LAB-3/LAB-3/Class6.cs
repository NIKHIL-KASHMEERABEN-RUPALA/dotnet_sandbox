using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3
{
    internal class Patient
    {

        int Patient_ID;
        string Name;
        int Age;
        string Disease;



        public void GetPatientDatails()
        {
            Console.WriteLine("Enter the Patient ID :  ");
            Patient_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Age of Patient :  ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name of Disease :  ");
            Disease = Console.ReadLine();

        }


        public void DisplayPatientDetails()
        {
            Console.WriteLine($"Patient ID : {Patient_ID} ");
            Console.WriteLine($"Patient Age : {Age} ");
            Console.WriteLine($"Patient Disease : {Disease} ");
        }


    }
}
