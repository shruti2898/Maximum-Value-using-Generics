using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class UC4_MaximumInArray
    {
        public static int MaximumInteger(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        public static float MaximumFloat(float[] arr)
        {
            float max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        public static String MaximumString(List<string> arr)
        {
            arr.Sort();
            string max = arr[arr.Count - 1];
            return max;
        }
    }
}
