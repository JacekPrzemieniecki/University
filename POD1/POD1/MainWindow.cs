using System;
using System.IO;
using System.Windows.Forms;

namespace POD1
{
    public partial class MainWindow : Form
    {
        const int MaxFileSize = 20*1024;
        readonly OpenFileDialog _fileDialog = new OpenFileDialog();
        readonly SaveFileDialog _saveDialog = new SaveFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        string EncryptedText
        {
            get { return EncryptedTextBox.Text; }
            set { EncryptedTextBox.Text = value; }
        }

        string DecryptedText
        {
            get { return DecryptedTextBox.Text; }
            set { DecryptedTextBox.Text = value; }
        }

        string Key => KeyTextBox.Text;

        void EncryptButton_Click(object sender, EventArgs e)
        {
            DecryptedText = DecryptedText.ToUpperInvariant();
            EncryptedText = BeaufortCipher.Encrypt(DecryptedText, Key);
        }

        void DecryptButton_Click(object sender, EventArgs e)
        {
            EncryptedText = EncryptedText.ToUpperInvariant();
            DecryptedText = BeaufortCipher.Decrypt(EncryptedText, Key);
        }

        void LoadDecryptedButton_Click(object sender, EventArgs e)
        {
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fInfo = new FileInfo(_fileDialog.FileName);

                if (fInfo.Length > MaxFileSize)
                {
                    // file too big to fit into the textbox, offer to encrypt to file directly
                    var message = "File too big to show in this window\nDo you want to encrypt directly to file?";
                    if (MessageBox.Show(message, "File too big", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    if (_saveDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    using (var writer = new StreamWriter(new BufferedStream(_saveDialog.OpenFile())))
                    using (var reader = new StreamReader(new BufferedStream(_fileDialog.OpenFile())))
                    {
                        TransformBetweenFiles(reader, writer, BeaufortCipher.Encrypt);
                    }
                }
                else
                {
                    using (var reader = new StreamReader(_fileDialog.OpenFile()))
                    {
                        DecryptedText = reader.ReadToEnd();
                    }
                }
            }
        }

        void TransformBetweenFiles(StreamReader source, StreamWriter dest, Action<char[], char[], BeaufortKey> operation)
        {
            var inBuffer = new char[Constants.BufferSize];
            var outBuffer = new char[Constants.BufferSize];
            var key = new BeaufortKey(Key);
            int read;

            while ((read = source.Read(inBuffer, 0, Constants.BufferSize)) > 0)
            {
                operation(inBuffer, outBuffer, key);
                dest.Write(outBuffer, 0, read);
            }
        }

        void SaveDecryptedButton_Click(object sender, EventArgs e)
        {
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(_saveDialog.OpenFile()))
                {
                    writer.WriteAsync(DecryptedText);
                }
            }
        }

        void LoadEncryptedButton_Click(object sender, EventArgs e)
        {
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fInfo = new FileInfo(_fileDialog.FileName);

                if (fInfo.Length > MaxFileSize)
                {
                    // file too big to fit into the textbox, offer to decrypt to file directly
                    var message = "File too big to show in this window\nDo you want to decrypt directly to file?";
                    if (MessageBox.Show(message, "File too big", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                    if (_saveDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    using (var writer = new StreamWriter(new BufferedStream(_saveDialog.OpenFile())))
                    using (var reader = new StreamReader(new BufferedStream(_fileDialog.OpenFile())))
                    {
                        TransformBetweenFiles(reader, writer, BeaufortCipher.Decrypt);
                    }
                }
                else
                {
                    using (var reader = new StreamReader(_fileDialog.OpenFile()))
                    {
                        EncryptedText = reader.ReadToEnd();
                    }
                }
            }
        }

        void SaveEncryptedButton_Click(object sender, EventArgs e)
        {
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(_saveDialog.OpenFile()))
                {
                    writer.WriteAsync(EncryptedText);
                }
            }
        }
    }
}