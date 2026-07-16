using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3
{
    internal class Item
    {


        int Item_Code;
        string Item_Name;
        int Stock_Quantity;

        public Item(int i_c , string i_n , int sq)
        {
            Item_Code = i_c;
            Item_Name = i_n;
            Stock_Quantity = sq;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Item Code : {Item_Code} ");
            Console.WriteLine($"Item Name : {Item_Name} ");
            Console.WriteLine($"Stock Quantity : {Stock_Quantity} ");
        }


    }
}
