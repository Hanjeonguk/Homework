using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sorting
{
    internal class Sorting
    {
        //1.선택정렬
        public static void Swap(IList<int>list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
        public static void  SelectionSort(IList<int>list, int start, int end)
        {
            for (int i = start; i < end; i++) 
            {
                int index = i;
                for(int j = i+1; j < end; j++)
                {
                    if (list[index] > list[j])
                    {
                        index = j;
                    }
                }
                Swap(list, i, index);
            }
        }

        //2.삽입 정렬
         public static void InsertionSort(IList<int>list, int start, int end)
        {
            for(int i = start; i < end; i++)
            {
                for(int j=i; j > 0; j--)
                {
                    if (list[j-1] < list[j])
                    {
                        break;
                    }
                    Swap(list, j - 1, j);
                }
            }
        }   
        
    }
}
