using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_list.sort
{
    class MyQuickSort
    {
        static void Swap(ref PhoneTalk a, ref PhoneTalk b)
        {
            PhoneTalk temp = a;
            a = b;
            b = temp;
        }

        static int Partition(UserList<PhoneTalk> arr, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for(int i = minIndex; i < maxIndex; i++)
            {
                
            }
            return 0;
        }
        

    }
}
