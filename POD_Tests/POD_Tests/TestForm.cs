using System;
using System.IO;
using System.Windows.Forms;

namespace BD_Tests
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        void RunTestsButton_Click(object sender, EventArgs e)
        {
            using (var stream = new FileStream(PathBox.Text, FileMode.Open))
            {
                var singleBitTest = new SingleBitTest();
                singleBitTest.Run(stream);
                SingleBitOnesLabel.Text = singleBitTest.Ones.ToString();
                SingleBitPassedLabel.Text = singleBitTest.Passed ? "Passed" : "Failed";

                stream.Position = 0;
                var pokerTest = new PokerTest();
                pokerTest.Run(stream);
                PokerPassedLabel.Text = pokerTest.Passed ? "Passed" : "Failed";
                PValueLabel.Text = pokerTest.P.ToString();

                stream.Position = 0;
                var blockGapTest = new BlockGapTest();
                blockGapTest.Run(stream);
                BlockStatistic.Text = blockGapTest.Statistic.ToString();

                stream.Position = 0;
                var autoCorrelationTest = new AutocorrelationTest((int) ShiftBox.Value);
                autoCorrelationTest.Run(stream);
                AutocorrelationStatisticLabel.Text = autoCorrelationTest.Statistic.ToString();
            }
        }

        void GenerateButton_Click(object sender, EventArgs e)
        {
            var rng = new Random();

            var buffer = new byte[2500];
            rng.NextBytes(buffer);
            using (var writer = new StreamWriter(new FileStream(PathBox.Text, FileMode.Create)))
            {
                foreach (var b in buffer)
                {
                    writer.Write(Convert.ToString(b, 2).PadLeft(8, '0'));
                }
            }
        }
    }
}