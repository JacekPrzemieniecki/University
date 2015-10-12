/* 
Copyright (c) 2015 Jacek Przemieniecki

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all 
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
*/

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
            EncryptedText = BeaufortCipher.Encrypt(DecryptedText, Key);
        }

        void DecryptButton_Click(object sender, EventArgs e)
        {
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
                        var inBuffer = new char[Constants.BufferSize];
                        var outBuffer = new char[Constants.BufferSize];
                        var key = new BeaufortKey(Key);
                        int read;

                        while ((read = reader.Read(inBuffer, 0, Constants.BufferSize)) > 0)
                        {
                            BeaufortCipher.Encrypt(inBuffer, outBuffer, key);
                            writer.Write(outBuffer, 0, read);
                        }
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
                        var inBuffer = new char[Constants.BufferSize];
                        var outBuffer = new char[Constants.BufferSize];
                        var key = new BeaufortKey(Key);
                        int read;

                        while ((read = reader.Read(inBuffer, 0, Constants.BufferSize)) > 0)
                        {
                            BeaufortCipher.Decrypt(inBuffer, outBuffer, key);
                            writer.Write(outBuffer, 0, read);
                        }
                        var task = writer.FlushAsync();
                        while (!task.IsCompleted)
                        {
                            Application.DoEvents();
                        }
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