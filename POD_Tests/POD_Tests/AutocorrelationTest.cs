using System;
using System.IO;

namespace BD_Tests
{
    class AutocorrelationTest
    {
        readonly int _shift;
        public double Statistic;

        public AutocorrelationTest(int shift)
        {
            _shift = shift;
        }

        public void Run(FileStream stream)
        {
            var streamLength = stream.Length;
            byte[] buffer = new byte[_shift];
            byte[] read = new byte[_shift];
            stream.Read(buffer, 0, _shift);
            int differentBits = 0;
            for (int i = 0; i < stream.Length - 2*_shift; i++)
            {
                stream.Read(read, 0, _shift);
                for (int j = 0; j < _shift; j++)
                {
                    if (buffer[j] != read[j])
                    {
                        differentBits++;
                    }
                }

                Buffer.BlockCopy(read, 0, buffer, 0, _shift);
            }

            Statistic = (2*differentBits - streamLength + _shift)/Math.Sqrt(streamLength - _shift);
        }
    }
}