/* 
Copyright (c) 2015 Jacek Przemieniecki

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all 
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
*/

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