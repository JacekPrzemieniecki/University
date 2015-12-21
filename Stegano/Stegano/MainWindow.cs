using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Stegano
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            AllocConsole();
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        void WriteButton_Click(object sender, EventArgs e)
        {
            var imagePath = ImagePathBox.Text;
            var messagePath = MessagePathBox.Text;
            var outputPath = TargetPathBox.Text;
            using (var imageReader = new FileStream(imagePath, FileMode.Open))
            using (var messageReader = new FileStream(messagePath, FileMode.Open))
            using (var outputWriter = new FileStream(outputPath, FileMode.Create))
            {
                var steganoWriter = new SteganoWriter(imageReader, outputWriter);
                int messageLen = (int)messageReader.Length;
                Console.WriteLine("Writing length: " + messageLen);
                var lenBytes = BitConverter.GetBytes(messageLen);
                foreach (var lenByte in lenBytes)
                {
                    Console.WriteLine("Len: " + lenByte);
                    steganoWriter.WriteByte(lenByte);
                }
                for (var i = 0; i < messageLen; i++)
                {
                    steganoWriter.WriteByte((byte) messageReader.ReadByte());
                }
                steganoWriter.WriteToEnd();
            }
        }

        void ReadButton_Click(object sender, EventArgs e)
        {
            using (var imageReader = new FileStream(ImageReadBox.Text, FileMode.Open))
            using (var outputWriter = new FileStream(ReadSaveAsBox.Text, FileMode.Create))
            {
                var reader = new SteganoReader(imageReader, outputWriter);
                reader.Run();
            }
        }
    }
}