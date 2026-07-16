using LAB_3;
using System.Collections.Concurrent;

internal class Program
{
    static void Main()
    {
        Faculty f1 = new Faculty();
        question3();
        Console.WriteLine();
        question4();
        Console.WriteLine();
        question5();
        Console.WriteLine();
        question6();

    }
    public static void question2()
    {
        Employee[] emp = new Employee[5];
       
        for(int i = 0; i < emp.Length; i++)
        {
            emp[i] = new Employee();
            emp[i].GetEmpDetails();
        }

        for(int j = 0; j < emp.Length; j++) {
            emp[j].DisplayEmpDetails();
        }
                   
    }

    public static void question3()
    {
        Cube c1 = new Cube(4);
        c1.DisplayVolume();
    }

    public static void question4()
    {
        Car c = new Car(2024,"electric","c63-amg","Mercedes",990);

        c.DisplayCarInfo();

    }

    public static void question5()

    {
        Item[] items = new Item[10];

        for(int j = 0; j < items.Length; j++)
        {

            Console.WriteLine("Enter Item Code : ");

            int i_c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Item Name : ");

            string i_n = Console.ReadLine();

            Console.WriteLine("Enter Stock Quantity : ");

            int sq = Convert.ToInt32(Console.ReadLine());

            items[j] = new Item(i_c, i_n, sq);

        }


        foreach(Item item in items)
        {
            item.DisplayDetails();
        }
    



}

    public static void question6()
    {

        Patient[] patients = new Patient[2];

        for(int i = 0; i < patients.Length; i++)
        {

            patients[i] = new Patient();
            patients[i].GetPatientDatails();

        }


        foreach(Patient patient in patients) {

            patient.DisplayPatientDetails();

        }


    }

}