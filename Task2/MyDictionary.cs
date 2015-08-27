using System;

namespace Task2
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _value;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _value = new TValue[0];
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < _keys.Length; i++)
                {
                    if (_keys[i].Equals(key))
                    {
                        return _value[i];
                    }
                }
                Console.WriteLine("Not found");
                return default(TValue);
            }
        }

        public void ClearDictionary()
        {
            _keys = new TKey[0];
            _value = new TValue[0];
        }
        public int KeysLen
        {
            get
            {
                return _keys.Length;
            }
        }

        public int ValueLen
        {
            get
            {
                return _value.Length;
            }
        }

        public void Add(TKey key, TValue val)
        {
            TKey[] tempKey = new TKey[KeysLen + 1];
            for (int i = 0; i < KeysLen; i++)
            {
                tempKey[i] = _keys[i];
            }
            tempKey[_keys.Length] = key;
            _keys = tempKey;

            TValue[] tempVal = new TValue[ValueLen + 1];
            for (int i = 0; i < ValueLen; i++)
            {
                tempVal[i] = _value[i];
            }
            tempVal[_value.Length] = val;
            _value = tempVal;
        }
    }
}
