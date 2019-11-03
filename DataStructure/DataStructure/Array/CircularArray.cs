using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Array
{
    class CircularArray
    {
        object[] arr = new object[ARR_SIZE];
        const int ARR_SIZE = 8;
        int currIdx = 0;
        
        void Add(object element)
        {
            if (currIdx >= ARR_SIZE)
            {
                currIdx = 0;
            }

            arr[currIdx] = element;

            currIdx++;
        }
    }
}
