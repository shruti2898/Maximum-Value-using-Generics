using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class TestCode
    {   //test cases for int values
        //test case 1: max value at first position
        public static void TestCase1Integer()
        {
            int result =  UC1_MaximumInteger.MaximumInteger(10, 5, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 2: max value at second position
        public static void TestCase2Integer()
        {
            int result = UC1_MaximumInteger.MaximumInteger(10, 15, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 3: max value at third position
        public static void TestCase3Integer()
        {
            int result = UC1_MaximumInteger.MaximumInteger(10, 5, 16);
            Console.WriteLine("\nMaximum value is " + result);
        }


        //test cases for float values
        //test case 1: max value at first position
        public static void TestCase1Float()
        {
            float result = UC2_MaximumFloat.MaximumFloat(21.5f, 8.5f, 15.7f);
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 2: max value at second position
        public static void TestCase2Float()
        {
            float result = UC2_MaximumFloat.MaximumFloat(2.6f, 15.4f, 1.5f);
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 3: max value at third position
        public static void TestCase3Float()
        {
            float result = UC2_MaximumFloat.MaximumFloat(2.6f, 8.5f, 15.7f);
            Console.WriteLine("\nMaximum value is " + result);
        }


        //test cases for String values
        //test case 1: max value at first position
        public static void TestCase1String()
        {
            String result = UC3_MaximumString.MaximumString("Peach", "Apple", "Banana");
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 2: max value at second position
        public static void TestCase2String()
        {
            String result = UC3_MaximumString.MaximumString("Lion", "Zebra", "Cat");
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 3: max value at third position
        public static void TestCase3String()
        {
            String result = UC3_MaximumString.MaximumString("Blue", "Red", "Yellow");
            Console.WriteLine("\nMaximum value is " + result);
        }

    }
}
