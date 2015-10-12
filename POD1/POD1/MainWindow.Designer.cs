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

namespace POD1
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DecryptedGroup = new System.Windows.Forms.GroupBox();
            this.DecryptedTextBox = new System.Windows.Forms.TextBox();
            this.DecryptedButtons = new System.Windows.Forms.Panel();
            this.LoadDecryptedButton = new System.Windows.Forms.Button();
            this.SaveDecryptedButton = new System.Windows.Forms.Button();
            this.Encrypted = new System.Windows.Forms.GroupBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedButtons = new System.Windows.Forms.Panel();
            this.LoadEncryptedButton = new System.Windows.Forms.Button();
            this.SaveEncryptedButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.DecryptedGroup.SuspendLayout();
            this.DecryptedButtons.SuspendLayout();
            this.Encrypted.SuspendLayout();
            this.EncryptedButtons.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecryptedGroup
            // 
            this.DecryptedGroup.Controls.Add(this.DecryptedTextBox);
            this.DecryptedGroup.Controls.Add(this.DecryptedButtons);
            this.DecryptedGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.DecryptedGroup.Location = new System.Drawing.Point(0, 0);
            this.DecryptedGroup.Name = "DecryptedGroup";
            this.DecryptedGroup.Size = new System.Drawing.Size(452, 608);
            this.DecryptedGroup.TabIndex = 0;
            this.DecryptedGroup.TabStop = false;
            this.DecryptedGroup.Text = "Decrypted";
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptedTextBox.Location = new System.Drawing.Point(3, 16);
            this.DecryptedTextBox.Multiline = true;
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.Size = new System.Drawing.Size(446, 550);
            this.DecryptedTextBox.TabIndex = 3;
            // 
            // DecryptedButtons
            // 
            this.DecryptedButtons.Controls.Add(this.LoadDecryptedButton);
            this.DecryptedButtons.Controls.Add(this.SaveDecryptedButton);
            this.DecryptedButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DecryptedButtons.Location = new System.Drawing.Point(3, 566);
            this.DecryptedButtons.Name = "DecryptedButtons";
            this.DecryptedButtons.Size = new System.Drawing.Size(446, 39);
            this.DecryptedButtons.TabIndex = 0;
            // 
            // LoadDecryptedButton
            // 
            this.LoadDecryptedButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadDecryptedButton.Location = new System.Drawing.Point(0, 0);
            this.LoadDecryptedButton.Name = "LoadDecryptedButton";
            this.LoadDecryptedButton.Size = new System.Drawing.Size(183, 39);
            this.LoadDecryptedButton.TabIndex = 0;
            this.LoadDecryptedButton.Text = "Load";
            this.LoadDecryptedButton.UseVisualStyleBackColor = true;
            this.LoadDecryptedButton.Click += new System.EventHandler(this.LoadDecryptedButton_Click);
            // 
            // SaveDecryptedButton
            // 
            this.SaveDecryptedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveDecryptedButton.Location = new System.Drawing.Point(263, 0);
            this.SaveDecryptedButton.Name = "SaveDecryptedButton";
            this.SaveDecryptedButton.Size = new System.Drawing.Size(183, 39);
            this.SaveDecryptedButton.TabIndex = 1;
            this.SaveDecryptedButton.Text = "Save";
            this.SaveDecryptedButton.UseVisualStyleBackColor = true;
            this.SaveDecryptedButton.Click += new System.EventHandler(this.SaveDecryptedButton_Click);
            // 
            // Encrypted
            // 
            this.Encrypted.Controls.Add(this.EncryptedTextBox);
            this.Encrypted.Controls.Add(this.EncryptedButtons);
            this.Encrypted.Dock = System.Windows.Forms.DockStyle.Right;
            this.Encrypted.Location = new System.Drawing.Point(705, 0);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(452, 608);
            this.Encrypted.TabIndex = 1;
            this.Encrypted.TabStop = false;
            this.Encrypted.Text = "Encrypted";
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedTextBox.Location = new System.Drawing.Point(3, 16);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(446, 550);
            this.EncryptedTextBox.TabIndex = 2;
            // 
            // EncryptedButtons
            // 
            this.EncryptedButtons.Controls.Add(this.LoadEncryptedButton);
            this.EncryptedButtons.Controls.Add(this.SaveEncryptedButton);
            this.EncryptedButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EncryptedButtons.Location = new System.Drawing.Point(3, 566);
            this.EncryptedButtons.Name = "EncryptedButtons";
            this.EncryptedButtons.Size = new System.Drawing.Size(446, 39);
            this.EncryptedButtons.TabIndex = 1;
            // 
            // LoadEncryptedButton
            // 
            this.LoadEncryptedButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadEncryptedButton.Location = new System.Drawing.Point(0, 0);
            this.LoadEncryptedButton.Name = "LoadEncryptedButton";
            this.LoadEncryptedButton.Size = new System.Drawing.Size(183, 39);
            this.LoadEncryptedButton.TabIndex = 0;
            this.LoadEncryptedButton.Text = "Load";
            this.LoadEncryptedButton.UseVisualStyleBackColor = true;
            this.LoadEncryptedButton.Click += new System.EventHandler(this.LoadEncryptedButton_Click);
            // 
            // SaveEncryptedButton
            // 
            this.SaveEncryptedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveEncryptedButton.Location = new System.Drawing.Point(263, 0);
            this.SaveEncryptedButton.Name = "SaveEncryptedButton";
            this.SaveEncryptedButton.Size = new System.Drawing.Size(183, 39);
            this.SaveEncryptedButton.TabIndex = 1;
            this.SaveEncryptedButton.Text = "Save";
            this.SaveEncryptedButton.UseVisualStyleBackColor = true;
            this.SaveEncryptedButton.Click += new System.EventHandler(this.SaveEncryptedButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.DecryptButton);
            this.ButtonPanel.Controls.Add(this.EncryptButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(452, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(253, 608);
            this.ButtonPanel.TabIndex = 2;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.Location = new System.Drawing.Point(59, 307);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(136, 30);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "< Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptButton.Location = new System.Drawing.Point(59, 271);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(136, 30);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "    Encrypt >";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyTextBox.Location = new System.Drawing.Point(29, 0);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(1128, 20);
            this.KeyTextBox.TabIndex = 2;
            this.KeyTextBox.Text = "INSERTKEYHERE";
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KeyTextBox);
            this.panel1.Controls.Add(this.KeyLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 25);
            this.panel1.TabIndex = 3;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.KeyLabel.Location = new System.Drawing.Point(0, 0);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Padding = new System.Windows.Forms.Padding(2);
            this.KeyLabel.Size = new System.Drawing.Size(29, 17);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Key";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 633);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.DecryptedGroup);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Beaufort cipher";
            this.DecryptedGroup.ResumeLayout(false);
            this.DecryptedGroup.PerformLayout();
            this.DecryptedButtons.ResumeLayout(false);
            this.Encrypted.ResumeLayout(false);
            this.Encrypted.PerformLayout();
            this.EncryptedButtons.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DecryptedGroup;
        private System.Windows.Forms.TextBox DecryptedTextBox;
        private System.Windows.Forms.Panel DecryptedButtons;
        private System.Windows.Forms.Button LoadDecryptedButton;
        private System.Windows.Forms.Button SaveDecryptedButton;
        private System.Windows.Forms.GroupBox Encrypted;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.Panel EncryptedButtons;
        private System.Windows.Forms.Button LoadEncryptedButton;
        private System.Windows.Forms.Button SaveEncryptedButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KeyLabel;
    }
}

