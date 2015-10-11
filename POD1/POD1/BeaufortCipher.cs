using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace POD1
{
    static class BeaufortCipher
    {
        const int LettersInAlphabet = 'Z' - 'A' + 1;

        public static string Encrypt(string plain, string key)
        {
            var encryptedBytes = Encrypt(Encoding.ASCII.GetBytes(plain.ToUpperInvariant()), new BeaufortKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static char[] Encrypt(char[] plain, BeaufortKey key)
        {
            for (int i = 0; i < plain.Length; i++)
            {
                plain[i] = char.ToUpperInvariant(plain[i]);
            }
            var encryptedBytes = Encrypt(Encoding.ASCII.GetBytes(plain), key);
            return Encoding.ASCII.GetChars(encryptedBytes);
        }

        public static byte[] Encrypt(byte[] plain, BeaufortKey key)
        {
            var encrypted = new byte[plain.Length];
            Transform(plain, encrypted, key, EncryptOperation);
            return encrypted;
        }

        public static string Decrypt(string encrypted, string key)
        {
            var encryptedBytes = Decrypt(Encoding.ASCII.GetBytes(encrypted), new BeaufortKey(key));
            return Encoding.ASCII.GetString(encryptedBytes);
        }

        public static char[] Decrypt(char[] encrypted, BeaufortKey key)
        {
            var decryptedBytes = Decrypt(Encoding.ASCII.GetBytes(encrypted), key);
            return Encoding.ASCII.GetChars(decryptedBytes);
        }

        public static byte[] Decrypt(byte[] encrypted, BeaufortKey key)
        {
            var decrypted = new byte[encrypted.Length];
            Transform(encrypted, decrypted, key, DecryptOperation);
            return decrypted;
        }

        static byte EncryptOperation(byte plain, byte key)
        {
            return (byte) (plain > key ? (plain - key) : (plain + (LettersInAlphabet) - key));
        }

        static byte DecryptOperation(byte encrypted, byte key)
        {
            var plain = encrypted + key;
            return (byte) (plain < LettersInAlphabet ? plain : (plain - LettersInAlphabet));
        }

        static void Transform(byte[] input, byte[] output, BeaufortKey key, Func<byte, byte, byte> operation)
        {
            Debug.Assert(input.Length == output.Length);
            const int aOffset = 'A' - 1;
            for (var i = 0; i < input.Length; i++)
            {
                key.MoveNext();
                if (input[i] < 'A' || input[i] > 'Z')
                {
                    output[i] = input[i];
                }
                else
                {
                    var inputNormalized = input[i] - aOffset;
                    var outputNormalized = operation((byte) inputNormalized, key.Current);
                    output[i] = (byte) (outputNormalized + aOffset);
                }
            }
        }
    }
}