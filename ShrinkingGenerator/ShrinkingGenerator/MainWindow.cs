using System;
using System.IO;
using System.Windows.Forms;

namespace ShrinkingGenerator
{
    public partial class MainWindow : Form
    {
        const int BufferSize = 1024;

        public MainWindow()
        {
            InitializeComponent();
        }

        void GenerateButton_Click(object sender, EventArgs e)
        {
            using (var writer = new BinaryWriter(new FileStream(GenerateToBox.Text, FileMode.Create)))
            {
                var generator = BuildGenerator();
                var count = (int) GenerateByteCount.Value;
                for (var i = 0; i < count; i++)
                {
                    generator.MoveNext();
                    writer.Write(generator.Current);
                }
            }
        }

        ShrinkingGenerator BuildGenerator()
        {
            var lsfr1 = new LinearFeedbackShiftRegister(uint.Parse(Lfsr1InitialValueBox.Text),
                uint.Parse(Lfsr1ToggleMaskBox.Text));
            var lsfr2 = new LinearFeedbackShiftRegister(uint.Parse(Lfsr2InitialValueBox.Text),
                uint.Parse(Lfsr1ToggleMaskBox.Text));
            var generator = new ShrinkingGenerator(lsfr1, lsfr2);
            return generator;
        }

        void EncryptButton_Click(object sender, EventArgs e)
        {
            var inPath = EncryptFilePath.Text;
            var outPath = EncryptTargetPath.Text;
            Process(inPath, outPath);
        }

        void DecryptButton_Click(object sender, EventArgs e)
        {
            var inPath = DecryptFilePath.Text;
            var outPath = DecryptTargetPath.Text;
            Process(inPath, outPath);
        }

        void Process(string inPath, string outPath)
        {
            var buffer = new byte[BufferSize];
            var generator = BuildGenerator();

            using (var reader = new BufferedStream(new FileStream(inPath, FileMode.Open)))
            using (var writer = new BufferedStream(new FileStream(outPath, FileMode.Create)))
            {
                while (true)
                {
                    var read = reader.Read(buffer, 0, BufferSize);
                    if (read == 0)
                    {
                        break;
                    }
                    for (var i = 0; i < read; i++)
                    {
                        generator.MoveNext();
                        buffer[i] = (byte) (buffer[i] ^ generator.Current);
                    }
                    writer.Write(buffer, 0, read);
                }
            }
        }

    }
}