using System;
using System.Collections.Generic;
using System.IO;

namespace BD_Tests
{
    class BlockGapTest
    {
        public double Statistic;

        public void Run(FileStream stream)
        {
            var streamLength = stream.Length;
            var data = new StreamReader(stream).ReadToEnd();
            var current = data[0];
            var series = 0;

            var gapCounts = new Dictionary<int, int>();
            var seriesCounts = new Dictionary<int, int>();

            foreach (var c in data)
            {
                if (c == current)
                {
                    series++;
                }
                else
                {
                    var dict = current == '0' ? gapCounts : seriesCounts;

                    if (!dict.ContainsKey(series))
                    {
                        dict[series] = 0;
                    }

                    dict[series]++;
                    
                    current = c;
                    series = 1;
                }
            }

            Statistic = 0;
            foreach (var pair in gapCounts)
            {
                int len = pair.Key;
                int gapCount = pair.Value;
                int seriesCount = seriesCounts.ContainsKey(len) ? seriesCounts[len] : 0;

                double expected = (streamLength - len + 3.0)/Math.Pow(2, len);
                if (expected < 5)
                {
                    break;
                }

                Statistic += Math.Pow(gapCount - expected, 2)/expected + Math.Pow(seriesCount - expected, 2)/expected;
            }
        }
    }
}