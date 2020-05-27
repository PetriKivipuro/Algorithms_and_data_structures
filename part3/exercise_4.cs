using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class BinarySearch
    {
        public bool Find(int[] t, int x)
        {
            Array.Sort(t);

            object d = x;

            if (!(t.Contains(d)))
            {
                return false;/*  */
            }

            return true;
        }
    }
}