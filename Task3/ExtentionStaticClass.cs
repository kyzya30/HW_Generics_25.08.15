using System;

namespace Task3
{
    static class ExtentionStaticClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            for (int i = 0; i < list.ArrCount; i++)
            {
                Console.WriteLine(list[i]);
            }
            return default(T[]);
        }
    }
}
