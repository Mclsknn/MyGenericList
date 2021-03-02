using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
   public class MyList<TKey,TValue>
    {
        TKey[] _keyArray;
        TValue[] _valueArray;
        TKey[] _tempKeyArray;
        TValue[] _tempValueArray;
        public MyList()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }
        public void Add(TKey key,TValue value) {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;
            _keyArray = new TKey[_keyArray.Length + 1];
            _valueArray = new TValue[_valueArray.Length + 1];
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
            }
            _keyArray[_keyArray.Length - 1] = key;
            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _valueArray[i] = _tempValueArray[i];
            }
            _valueArray[_valueArray.Length - 1] = value;
        }
    }
}
