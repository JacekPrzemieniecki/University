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

using System.Diagnostics;
using System.Text;

namespace POD1
{
    static class BeaufortCipher
    {
        static readonly byte[] EncryptedBuffer = new byte[Constants.BufferSize];
        static readonly byte[] DecryptedBuffer = new byte[Constants.BufferSize];

        public static string Encrypt(string plain, string key)
        {
            var encryptedBytes = new byte[plain.Length];
            Encrypt(Encoding.ASCII.GetBytes(plain), encryptedBytes, new BeaufortKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static void Encrypt(char[] input, char[] output, BeaufortKey key)
        {
            Encoding.ASCII.GetBytes(input, 0, input.Length, DecryptedBuffer, 0);
            Encrypt(DecryptedBuffer, EncryptedBuffer, key);
            Encoding.ASCII.GetChars(EncryptedBuffer, 0, Constants.BufferSize, output, 0);
        }

        public static void Encrypt(byte[] input, byte[] output, BeaufortKey key)
        {
            Debug.Assert(input.Length == output.Length);
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '\n' || input[i] == '\r')
                {
                    output[i] = input[i];
                    continue;
                }
                var inputNormalized = input[i] - Constants.AsciiOffset;
                var plain = (byte) inputNormalized;
                var key1 = key.Current;
                var outputNormalized =
                    (byte) (plain > key1 ? (plain - key1) : (plain + Constants.AlphabetLength - key1));
                output[i] = (byte) (outputNormalized + Constants.AsciiOffset);
                key.MoveNext();
            }
        }

        public static string Decrypt(string encrypted, string key)
        {
            var encryptedBytes = new byte[encrypted.Length];
            Decrypt(Encoding.ASCII.GetBytes(encrypted), encryptedBytes, new BeaufortKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static void Decrypt(char[] input, char[] output, BeaufortKey key)
        {
            Encoding.ASCII.GetBytes(input, 0, input.Length, EncryptedBuffer, 0);
            Decrypt(EncryptedBuffer, DecryptedBuffer, key);
            Encoding.ASCII.GetChars(DecryptedBuffer, 0, Constants.BufferSize, output, 0);
        }

        public static void Decrypt(byte[] input, byte[] output, BeaufortKey key)
        {
            Debug.Assert(input.Length == output.Length);
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '\n' || input[i] == '\r')
                {
                    output[i] = input[i];
                    continue;
                }
                var inputNormalized = input[i] - Constants.AsciiOffset;
                var plain = (byte) inputNormalized + key.Current;
                var outputNormalized =
                    (byte) (plain < Constants.AlphabetLength ? plain : (plain - Constants.AlphabetLength));
                output[i] = (byte) (outputNormalized + Constants.AsciiOffset);
                key.MoveNext();
            }
        }
    }
}