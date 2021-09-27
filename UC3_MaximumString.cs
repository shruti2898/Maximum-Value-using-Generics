using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class UC3_MaximumString
    {
        public static String MaximumString(String first, String second, String third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                throw new Exception("First,second and third are same");
            }
        }
    }
}
