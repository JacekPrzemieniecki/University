using System;
using System.IO;

namespace Stegano
{
    struct SteganoWriter
    {
        FileStream _fromStream;
        FileStream _targetStream;
        byte[] buffer;

        public void WriteByte(byte b)
        {
            _fromStream.Read(buffer, 0, 8);
            for (int i = 0; i < 8; i++)
            {
                var bit = b >> 7;
                var carrying = buffer[i];
                var output = bit | (carrying & 0xFE);
                _targetStream.WriteByte((byte)output);
                b <<= 1;
            }
        }

        public void WriteToEnd()
        {
            int read = 100;
            byte[] buffer = new byte[1000];
            while (read != 0)
            {
                read = _fromStream.Read(buffer, 0, 1000);
                _targetStream.Write(buffer, 0, read);
            }
        }

        public SteganoWriter(FileStream from, FileStream to)
        {
            buffer = new byte[8];
            _fromStream = from;
            _targetStream = to;
            byte[] header = new byte[14];
            from.Read(header, 0, 14);
            _targetStream.Write(header, 0, 14);

            int offset = BitConverter.ToInt32(header, 10);
            int headerLeft = offset - 14;
            for (int i = 0; i < headerLeft; i++)
            {
                to.WriteByte((byte)from.ReadByte());
            }
        }
    }
}