using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class UC2_MaximumFloat
    {
        public static float MaximumFloat(float first, float second, float third)
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
