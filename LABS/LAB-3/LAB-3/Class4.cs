using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3
{
    internal class Car
    {

        int Year;
        String FuelType;
        String Model;
        String Make;
        int HorsePower;

        public Car(int year , string fueltype , string model , string make , int hp) {
                Year = year;
                FuelType = fueltype;
                Model = model;
                Make = make;
                HorsePower = hp;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Year :  {Year}");
            Console.WriteLine($"Fuel Type : {FuelType}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Horse Power : {HorsePower}");
        }

    }
}
