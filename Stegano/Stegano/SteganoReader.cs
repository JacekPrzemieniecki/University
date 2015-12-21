using System;
using System.IO;

namespace Stegano
{
    struct SteganoReader
    {
        FileStream _from;
        FileStream _to;
        public SteganoReader(FileStream sourceFile, FileStream to)
        {
            _from = sourceFile;
            _to = to;
        }

        public void Run()
        {
            byte[] header = new byte[14];
            _from.Read(header, 0, 14);

            int offset = BitConverter.ToInt32(header, 10);
            int headerLeft = offset - 14;
            _from.Seek(headerLeft, SeekOrigin.Current);
            byte[] lenghtBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                lenghtBytes[i] = (byte)ReadByte();
                Console.WriteLine("Read: " + lenghtBytes[i]);
            }
            int len = BitConverter.ToInt32(lenghtBytes, 0);
            Console.WriteLine("Length: " + len);
            for (int i = 0; i < len; i++)
            {
                _to.WriteByte((byte)ReadByte());
            }
        }

        int ReadByte()
        {
            int b = 0;
            for (int j = 0; j < 8; j++)
            {
                b <<= 1;
                int read = _from.ReadByte();
                b |= (read & 1);
            }
            return b;
        }
    }
}