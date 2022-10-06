using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public Class1()
        {
            //Displays Small Menu
            Display();
            //Values Entry
            EntryValues();
        }

        public static void EntryValues()
        {
            var stop = -1;//Stopping Condition
            do
            {
                //Entry of Value
                Console.Write("Input Integer: ");
                int point = int.Parse(Console.ReadLine());
                if (point == stop)
                {
                    return;
                }
                //Compare Value and Displays the Category
                CheckCategory(point);
            } while (true);
        }
        public static void Display()
        {
            int previousValue = 0;
            foreach (int i in Enum.GetValues(typeof(CategoryList.Category)))//Get each Integer of the enums
            {
                Console.WriteLine($"Category: {Enum.GetName(typeof(CategoryList.Category), i)} has a range of {previousValue} - {i}");
                previousValue = i + 1;
            }
        }

        public static void CheckCategory(int point)
        {
            foreach (int i in Enum.GetValues(typeof(CategoryList.Category)))
            {
                if (point <= i)
                {
                    Console.WriteLine($"{Enum.GetName(typeof(CategoryList.Category), i)}");
                    return;
                }
            }
        }
    }
    public class CategoryList
    {
        public enum Category
        {
            F = 10,
            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100
        }
    }
}
