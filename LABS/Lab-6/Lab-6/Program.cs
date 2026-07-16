using System;
using System.Collections.Generic;
using System.Linq; // Added for easier searching via LINQ

// Define the custom Student data type
public class Student
{
    public int Id;
    public string Name;
    public double Marks;
}

public class Student_dict : Student
{
    public int subject1;
    public int subject2;
    public int subject3;
}

public class Cart
{
    public int id;
    public string name;
    public int price;
}

public class Product
{
    public int id;
    public string name;
    public int price;
}

class Program
{
    // Declared statically outside methods, now using the Student data type
    static List<Student> StudentList = new List<Student>();
    static List<Cart> Cart_items = new List<Cart>();
    static Dictionary<int , Student_dict> Student_dict_list = new Dictionary<int, Student_dict>();
    static Dictionary<int, Product> Product_dict_list = new Dictionary<int, Product>();

    public static void Main()
    {
        //program1(); 
        //program2();
        //program3();
        program4();
    }

    public static void program1()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Enter your choice from the following ---");
            Console.WriteLine(" 1. Add ");
            Console.WriteLine(" 2. Display  ");
            Console.WriteLine(" 3. Search ");
            Console.WriteLine(" 4. Update ");
            Console.WriteLine(" 5. Delete ");
            Console.WriteLine(" 6. Exit the program ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // ADD STUDENT
                    Student newStudent = new Student();

                    Console.Write("Enter Student ID: ");
                    newStudent.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    newStudent.Name = Console.ReadLine();

                    Console.Write("Enter Marks: ");
                    newStudent.Marks = Convert.ToDouble(Console.ReadLine());

                    StudentList.Add(newStudent);
                    Console.WriteLine("Student added successfully!");
                    break;

                case 2:
                    // DISPLAY ALL STUDENTS
                    if (StudentList.Count == 0)
                    {
                        Console.WriteLine("No students in the list.");
                        break;
                    }

                    Console.WriteLine("\n--- Student Records ---");
                    foreach (Student s in StudentList)
                    {
                        Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Marks: {s.Marks}");
                    }
                    break;

                case 3:
                    // SEARCH BY ID
                    Console.Write("Enter Student ID to search: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());

                    // Finds the first student matching the ID
                    Student foundStudent = StudentList.Find(s => s.Id == searchId);

                    if (foundStudent == null)
                    {
                        Console.WriteLine("The student was not found in the list.");
                    }
                    else
                    {
                        int idx = StudentList.IndexOf(foundStudent);
                        Console.WriteLine($"Found at index {idx} -> Name: {foundStudent.Name}, Marks: {foundStudent.Marks}");
                    }
                    break;

                case 4:
                    // UPDATE BY ID
                    Console.Write("Enter Student ID to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    Student studentToUpdate = StudentList.Find(s => s.Id == updateId);

                    if (studentToUpdate != null)
                    {
                        Console.Write("Enter new name: ");
                        studentToUpdate.Name = Console.ReadLine();

                        Console.Write("Enter new marks: ");
                        studentToUpdate.Marks = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Student updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("The student was not found in the list.");
                    }
                    break;

                case 5:
                    // DELETE BY ID
                    Console.Write("Enter Student ID to delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    Student studentToDelete = StudentList.Find(s => s.Id == deleteId);

                    if (studentToDelete != null)
                    {
                        StudentList.Remove(studentToDelete);
                        Console.WriteLine("Student deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("The student was not found in the list.");
                    }
                    break;

                case 6:
                    Console.WriteLine(" Exiting the program... ");
                    break;
            }

        } while (choice != 6);
    }

    public static void program2()
    {
       
        int choice;
        do
        {
            Console.WriteLine("Enter the choice from the following -------  ");
            Console.WriteLine(" 1. Create cart item ");
            Console.WriteLine(" 2. Display cart item ");
            Console.WriteLine(" 3. Update cart item ");
            Console.WriteLine(" 4. Delete cart item ");
            Console.WriteLine(" 5. Calculate total Amount ");
            Console.WriteLine(" 6. Exit the program ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Cart c = new Cart();
                    Console.WriteLine("Enter Id of cart item :   "); 
                    c.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name of cart item :   ");
                    c.name = Console.ReadLine();
                    Console.WriteLine("Enter price of cart item :   ");
                    c.price = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    foreach(Cart item in Cart_items)
                    {
                        Console.WriteLine("Item id : " + item.id);
                        Console.WriteLine("Item name : " + item.name);
                        Console.WriteLine("Item price : " + item.price);
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the id of the item to update :   ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Cart search_cart_item = Cart_items.Find(item => item.id == id);
                    if (search_cart_item == null)
                    {
                        Console.WriteLine("Item not found");

                    }
                    else
                    {
                        Console.WriteLine("Enter new name of cart item :   ");
                        search_cart_item.name = Console.ReadLine();
                        Console.WriteLine("Enter new price of cart item :   ");
                        search_cart_item.price = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter the id of the item to delete :   ");
                    int idx = Convert.ToInt32(Console.ReadLine());
                    Cart to_delete_item = Cart_items.Find(x => x.id == idx);
                    if(to_delete_item == null)
                    {
                        Console.WriteLine("Item not found");
                    }
                    else
                    {
                        Cart_items.Remove(to_delete_item);
                        Console.WriteLine("Item deleted successfully");
                    }
                    break;

                case 5:
                    int total_cost = 0;
                    foreach(Cart items in Cart_items)
                    {
                        total_cost += items.price;
                    }
                    break;

                case 6:
                    Console.WriteLine(" Exiting the program... ");
                    break;

            }

        } while (choice != 6);
    }

    public static void program3()
    {
        int choice;
        do
        {
            Console.WriteLine("Enter the choice from the following -------  ");
            Console.WriteLine(" 1. Create Student related data ");
            Console.WriteLine(" 2. Display Student details ");
            Console.WriteLine(" 3. Update Student details ");
            Console.WriteLine(" 4. Delete student ");
            Console.WriteLine(" 5. Calculate percentage ");
            Console.WriteLine(" 6. Exit the program ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Student_dict s1 = new Student_dict();
                    Console.WriteLine("Enter Id of Student :   ");
                    s1.Id = Convert.ToInt32(Console.ReadLine());

                    if (Student_dict_list.ContainsKey(s1.Id))
                    {
                        Console.WriteLine("Student with this ID already exists. Please enter a unique ID.");
                        break;
                    }
                    Console.WriteLine("Enter name of Student :   ");
                    s1.Name = Console.ReadLine();
                    Console.WriteLine("Enter Marks of Student in subject-1 :   ");
                    s1.subject1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Marks of Student in subject-2 :   ");
                    s1.subject2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Marks of Student in subject-3 :   ");
                    s1.subject3 = Convert.ToInt32(Console.ReadLine());

                    Student_dict_list.Add(s1.Id,s1);

                    break;

                case 2:

                    if(Student_dict_list.Count == 0) {
                        Console.WriteLine("No students in the list.");
                    }

                    Console.WriteLine("Student dictionary records are as follows ------ ");
                    foreach(var(id,student) in Student_dict_list) 
                    {
                        Console.WriteLine($"ID: {id} | Name: {student.Name} | Sub1: {student.subject1}, Sub2: {student.subject2}, Sub3: {student.subject3}");
                    }
                    
                    break;

                case 3:

                    Console.Write("Enter the ID of the student to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    if (Student_dict_list.TryGetValue(updateId, out Student_dict studentToUpdate))
                    {
                        Console.Write("Enter new name: ");
                        studentToUpdate.Name = Console.ReadLine();
                        Console.Write("Enter new sub1 marks: ");
                        studentToUpdate.subject1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new sub2 marks: ");
                        studentToUpdate.subject2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new sub3 marks: ");
                        studentToUpdate.subject3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student records updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;

                case 4:

                    Console.Write("Enter the ID of the student to delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    if (Student_dict_list.Remove(deleteId))
                    {
                        Console.WriteLine("Student deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;

                case 5:

                    Console.Write("Enter the ID of the student to calculate percentage: ");
                    int pctId = Convert.ToInt32(Console.ReadLine());

                    if (Student_dict_list.TryGetValue(pctId, out Student_dict s))
                    {
                        double total = s.subject1 + s.subject2 + s.subject3;
                        double percentage = (total / 300.0) * 100;
                        Console.WriteLine($"Total Marks: {total}/300 | Percentage: {percentage:F2}%");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 6:
                    Console.WriteLine(" Exiting the program... ");
                    break;

            }


        } while (choice!=6);
    }

    public static void program4()
    {
        int choice;
        do
        {

            Console.WriteLine("Enter the choice from the following -------  ");
            Console.WriteLine(" 1. Create Product  ");
            Console.WriteLine(" 2. Display Product ");
            Console.WriteLine(" 3. Update Product ");
            Console.WriteLine(" 4. Delete Product ");
            Console.WriteLine(" 5. Calculate total Amount ");
            Console.WriteLine(" 6. Exit the program ");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Product p = new Product();
                    Console.WriteLine("Enter Id of Product :   ");
                    p.id = Convert.ToInt32(Console.ReadLine());
                    if(Product_dict_list.ContainsKey(p.id))
                    {
                        Console.WriteLine("Product with this ID already exists. Please enter a unique ID.");
                        break;
                    }
                    Console.WriteLine("Enter name of Product :   ");
                    p.name = Console.ReadLine();
                    Console.WriteLine("Enter price of Product :   ");
                    p.price = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    if (Product_dict_list.Count == 0)
                    {
                        Console.WriteLine("No products in the list.");
                        break;
                    }
                    Console.WriteLine("Product dictionary records are as follows ------ "); 
                    foreach(var (id , Product) in Product_dict_list)
                    {
                        Console.WriteLine($"ID: {id} | Name: {Product.name} | Price: {Product.price}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the ID of the product to update: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (Product_dict_list.TryGetValue(index, out Product UpdatedProduct))
                    {
                        Console.WriteLine("Enter new Product name: ");
                        UpdatedProduct.name = Console.ReadLine();
                        Console.WriteLine("Enter new price: ");
                        UpdatedProduct.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Product updated successfully!");

                    }
                    else
                    {
                    Console.WriteLine("Product not found.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter the ID of the product to delete: ");
                    int deleteIndex = Convert.ToInt32(Console.ReadLine());
                    if (Product_dict_list.Remove(deleteIndex))
                    {
                        Console.WriteLine("Product deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case 5:
                    int total_cost = 0;
                    foreach (var (id, Product) in Product_dict_list)
                    {
                        
                        total_cost += Product.price;
                        
                    }
                    Console.WriteLine($"Total cost of all products: {total_cost}");
                    break;

                case 6:
                    Console.WriteLine(" Exiting the program... ");
                    break;


            } 
    } while (choice != 6);


    }
}