using System;
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
            Encrypt(Encoding.ASCII.GetBytes(plain.ToUpperInvariant()), encryptedBytes, new BeaufortKey(key));
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
                key.MoveNext();
                var inputNormalized = input[i] - Constants.AsciiOffset;
                byte plain = (byte) inputNormalized;
                byte key1 = key.Current;
                var outputNormalized = (byte) (plain > key1 ? (plain - key1) : (plain + Constants.AlphabetLength - key1));
                output[i] = (byte) (outputNormalized + Constants.AsciiOffset);
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
                key.MoveNext();
                var inputNormalized = input[i] - Constants.AsciiOffset;
                var plain = (byte) inputNormalized + key.Current;
                var outputNormalized = (byte) (plain < Constants.AlphabetLength ? plain : (plain - Constants.AlphabetLength));
                output[i] = (byte) (outputNormalized + Constants.AsciiOffset);
            }
        }
    }
}