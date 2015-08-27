using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int>  intLst = new List<int>();
        intLst.Add(10);
        intLst.Add(22);
        intLst.Add(1);
        intLst.Add(8);
        Sort(intLst);
        foreach (var VARIABLE in intLst)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        static void Sort<T>(List<T> arrList) where T : IComparable<T>
        {
            
            for (int i = 0; i < arrList.Count; i++)
            {
                for (int j = 0; j < arrList.Count - 1; j++)
                {
                    if (arrList[i].CompareTo(arrList[j]) < 0)
                    {
                        T z = arrList[j];
                        arrList[j] = arrList[j + 1];
                        arrList[j + 1] = z;
                    }
                }
            }

        }
    }

   
}
