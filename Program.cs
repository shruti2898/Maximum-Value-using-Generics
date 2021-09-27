using System;
using System.Collections.Generic;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {   //UC1 : for 3 integer values
            Console.WriteLine("Find Maximum Value in 3 integer numbers");
            TestCode.TestCase1Integer();
            TestCode.TestCase2Integer();
            TestCode.TestCase3Integer();
            //UC2 : for 3 float values
            Console.WriteLine("\nFind Maximum Value in 3 float numbers");
            TestCode.TestCase1Float();
            TestCode.TestCase2Float();
            TestCode.TestCase3Float();
            //UC3 : for 3 string values
            Console.WriteLine("\nFind Maximum Value in 3 strings");
            TestCode.TestCase1String();
            TestCode.TestCase2String();
            TestCode.TestCase3String();


            //UC4: using Refactored method for multiple input values
            Console.WriteLine("\nFind maximum value");
            int[] intArr = { 112, 344, 432, 555, 678 };
            int intMax = UC4_MaximumInArray.MaximumInteger(intArr);
            Console.WriteLine(intMax);
            float[] floatArr = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            float floatMax = UC4_MaximumInArray.MaximumFloat(floatArr);
            Console.WriteLine(floatMax);
            List<string> stringArr = new List<string> { "Red", "Blue", "Orange", "Green", "Yellow" };
            string stringMax = UC4_MaximumInArray.MaximumString(stringArr);
            Console.WriteLine(stringMax);


            //UC5 : using generic type class for multiple input values
            Console.WriteLine("\nFind maximum value");
            int[] intArray = { 112, 344, 432, 555, 678 };
            UC5_MaximumInArrayGeneric<int> generic = new UC5_MaximumInArrayGeneric<int>(intArray);
            generic.PrintMaxValue();
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            UC5_MaximumInArrayGeneric<float> genericFloat = new UC5_MaximumInArrayGeneric<float>(floatArray);
            genericFloat.PrintMaxValue();
            string[] stringArray = { "Red", "Blue", "Orange", "Green", "Yellow" };
            UC5_MaximumInArrayGeneric<string> genericString = new UC5_MaximumInArrayGeneric<string>(stringArray);
            genericString.PrintMaxValue();


            Console.ReadKey();
        }
    }   
}
