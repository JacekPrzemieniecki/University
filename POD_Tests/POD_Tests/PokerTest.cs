using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BD_Tests
{
    class PokerTest
    {
        public bool Passed;
        public double P;

        public void Run(FileStream stream)
        {
            var countDict = new Dictionary<string, int>
            {
                ["0000"] = 0,
                ["0001"] = 0,
                ["0010"] = 0,
                ["0011"] = 0,
                ["0100"] = 0,
                ["0101"] = 0,
                ["0110"] = 0,
                ["0111"] = 0,
                ["1000"] = 0,
                ["1001"] = 0,
                ["1010"] = 0,
                ["1011"] = 0,
                ["1100"] = 0,
                ["1101"] = 0,
                ["1110"] = 0,
                ["1111"] = 0
            };

            var buffer = new byte[20000];
            stream.Read(buffer, 0, 20000);
            for (var i = 0; i < buffer.Length/4; i++)
            {
                var str = Encoding.ASCII.GetString(buffer, i*4, 4);
                countDict[str]++;
            }

            double sumSqr = 0;
            for (var i = 0; i < 16; i++)
            {
                var count = countDict[Convert.ToString(i, 2).PadLeft(4, '0')];
                sumSqr += count*count;
            }
            Console.WriteLine(sumSqr);
            double p = (16.0/5000)*(sumSqr) - 5000;
            P = p;

            Passed = p <= 46.17 && p >= 2.16;
        }
    }
}