using System;
using System.Collections.Generic;

namespace Part4
{
    public class Order
    {
        int[] preOrder;
        int[] inOrder;
        int[] result;
        int[] nodeLocationInOrder;

        public int[] Create(int[] a, int[] b)
        {
            this.preOrder = a;
            this.inOrder = b;
            int n = preOrder.Length;
            result = new int[n + 1];

            nodeLocationInOrder = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                nodeLocationInOrder[inOrder[i]] = i;
            }
            return result;

        }
    }

}