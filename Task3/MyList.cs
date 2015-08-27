using System.Linq;

namespace Task3
{
    class MyList<T>
    {
        private T[] _arr;
        public MyList()
        {
            _arr = new T[0];
        }
        
        public void ClearArr()
        {
            _arr = new T[0];
        }
        public int ArrCount
        {
            get
            {
                return _arr.Count();
            }
        }
        public void AddElem(T num)
        {
            T[] tempArr = new T[_arr.Length + 1];
            for (int i = 0; i < ArrCount; i++)
            {
                tempArr[i] = _arr[i];
            }
            tempArr[_arr.Length] = num;
            _arr = tempArr;
        }
        public T this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
    }
}
