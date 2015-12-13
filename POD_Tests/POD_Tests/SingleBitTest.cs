using System.IO;

namespace BD_Tests
{
    class SingleBitTest
    {
        public int Ones { get; private set; } = 0;
        public bool Passed { get; private set; } = false;

        public void Run(FileStream reader)
        {
            byte[] buffer = new byte[20000];
            reader.Read(buffer, 0, 20000);
            foreach (var c in buffer)
            {
                if (c == '1')
                {
                    Ones++;
                }
            }
            Passed = Ones < 10275 && Ones > 9725;
        }
    }
}