namespace ShrinkingGenerator
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
            this.GenerateToBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptFilePath = new System.Windows.Forms.TextBox();
            this.EncryptTargetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DecryptTargetPath = new System.Windows.Forms.TextBox();
            this.DecryptFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GenerateByteCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lfsr1InitialValueBox = new System.Windows.Forms.TextBox();
            this.Lfsr1ToggleMaskBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lfsr2ToggleMaskBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lfsr2InitialValueBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateByteCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateToBox
            // 
            this.GenerateToBox.Location = new System.Drawing.Point(82, 10);
            this.GenerateToBox.Name = "GenerateToBox";
            this.GenerateToBox.Size = new System.Drawing.Size(195, 20);
            this.GenerateToBox.TabIndex = 0;
            this.GenerateToBox.Text = "E:\\generated.bin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate to";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(13, 36);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(466, 35);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypt";
            // 
            // EncryptFilePath
            // 
            this.EncryptFilePath.Location = new System.Drawing.Point(82, 78);
            this.EncryptFilePath.Name = "EncryptFilePath";
            this.EncryptFilePath.Size = new System.Drawing.Size(397, 20);
            this.EncryptFilePath.TabIndex = 4;
            this.EncryptFilePath.Text = "E:\\EncryptTest.png";
            // 
            // EncryptTargetPath
            // 
            this.EncryptTargetPath.Location = new System.Drawing.Point(82, 105);
            this.EncryptTargetPath.Name = "EncryptTargetPath";
            this.EncryptTargetPath.Size = new System.Drawing.Size(397, 20);
            this.EncryptTargetPath.TabIndex = 5;
            this.EncryptTargetPath.Text = "E:\\Encrypted.enc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 131);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(466, 35);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 227);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(466, 35);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // DecryptTargetPath
            // 
            this.DecryptTargetPath.Location = new System.Drawing.Point(82, 201);
            this.DecryptTargetPath.Name = "DecryptTargetPath";
            this.DecryptTargetPath.Size = new System.Drawing.Size(397, 20);
            this.DecryptTargetPath.TabIndex = 10;
            this.DecryptTargetPath.Text = "E:\\DecryptTest.png";
            // 
            // DecryptFilePath
            // 
            this.DecryptFilePath.Location = new System.Drawing.Point(82, 174);
            this.DecryptFilePath.Name = "DecryptFilePath";
            this.DecryptFilePath.Size = new System.Drawing.Size(397, 20);
            this.DecryptFilePath.TabIndex = 9;
            this.DecryptFilePath.Text = "E:\\Encrypted.enc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decrypt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bytes";
            // 
            // GenerateByteCount
            // 
            this.GenerateByteCount.Location = new System.Drawing.Point(324, 10);
            this.GenerateByteCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.GenerateByteCount.Name = "GenerateByteCount";
            this.GenerateByteCount.Size = new System.Drawing.Size(154, 20);
            this.GenerateByteCount.TabIndex = 14;
            this.GenerateByteCount.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lfsr1ToggleMaskBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Lfsr1InitialValueBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LFSR1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Initial Value";
            // 
            // Lfsr1InitialValueBox
            // 
            this.Lfsr1InitialValueBox.Location = new System.Drawing.Point(74, 13);
            this.Lfsr1InitialValueBox.Name = "Lfsr1InitialValueBox";
            this.Lfsr1InitialValueBox.Size = new System.Drawing.Size(392, 20);
            this.Lfsr1InitialValueBox.TabIndex = 1;
            this.Lfsr1InitialValueBox.Text = "63844534";
            // 
            // Lfsr1ToggleMaskBox
            // 
            this.Lfsr1ToggleMaskBox.Location = new System.Drawing.Point(74, 39);
            this.Lfsr1ToggleMaskBox.Name = "Lfsr1ToggleMaskBox";
            this.Lfsr1ToggleMaskBox.Size = new System.Drawing.Size(393, 20);
            this.Lfsr1ToggleMaskBox.TabIndex = 3;
            this.Lfsr1ToggleMaskBox.Text = "2155840383";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Toggle Mask";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lfsr2ToggleMaskBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Lfsr2InitialValueBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(10, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LFSR2";
            // 
            // Lfsr2ToggleMaskBox
            // 
            this.Lfsr2ToggleMaskBox.Location = new System.Drawing.Point(74, 39);
            this.Lfsr2ToggleMaskBox.Name = "Lfsr2ToggleMaskBox";
            this.Lfsr2ToggleMaskBox.Size = new System.Drawing.Size(393, 20);
            this.Lfsr2ToggleMaskBox.TabIndex = 3;
            this.Lfsr2ToggleMaskBox.Text = "3539489530";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Toggle Mask";
            // 
            // Lfsr2InitialValueBox
            // 
            this.Lfsr2InitialValueBox.Location = new System.Drawing.Point(74, 13);
            this.Lfsr2InitialValueBox.Name = "Lfsr2InitialValueBox";
            this.Lfsr2InitialValueBox.Size = new System.Drawing.Size(392, 20);
            this.Lfsr2InitialValueBox.TabIndex = 1;
            this.Lfsr2InitialValueBox.Text = "86345434";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Initial Value";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GenerateByteCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptTargetPath);
            this.Controls.Add(this.DecryptFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptTargetPath);
            this.Controls.Add(this.EncryptFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateToBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GenerateByteCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenerateToBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptFilePath;
        private System.Windows.Forms.TextBox EncryptTargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DecryptTargetPath;
        private System.Windows.Forms.TextBox DecryptFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GenerateByteCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Lfsr1ToggleMaskBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Lfsr1InitialValueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Lfsr2ToggleMaskBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Lfsr2InitialValueBox;
        private System.Windows.Forms.Label label10;
    }
}

