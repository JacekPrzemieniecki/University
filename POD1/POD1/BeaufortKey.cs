using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace POD1
{
    class BeaufortKey
    {
        readonly byte[] _keyData;
        int index;

        public BeaufortKey(string key)
        {
            _keyData = Encoding.ASCII.GetBytes(key.ToUpperInvariant());
            for (var i = 0; i < _keyData.Length; i++)
            {
                Debug.Assert(_keyData[i] >= 'A');
                Debug.Assert(_keyData[i] <= 'Z');
                _keyData[i] -= 'A' - 1;
            }
        }

        public byte Current => _keyData[index];

        public void MoveNext()
        {
            if (index >= _keyData.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }

        public IEnumerator<byte> GetEnumerator()
        {
            index = 0;
            while (true)
            {
                yield return _keyData[index];
                index++;
                index %= _keyData.Length;
            }
        }
    }
}