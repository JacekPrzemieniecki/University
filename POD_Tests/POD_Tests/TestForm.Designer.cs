namespace BD_Tests
{
    partial class TestForm
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
            this.PathBox = new System.Windows.Forms.TextBox();
            this.RunTestsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SingleBitOnesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SingleBitPassedLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PValueLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PokerPassedLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BlockStatistic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ShiftBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AutocorrelationStatisticLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(13, 13);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(321, 20);
            this.PathBox.TabIndex = 0;
            this.PathBox.Text = "E:\\tested.txt";
            // 
            // RunTestsButton
            // 
            this.RunTestsButton.Location = new System.Drawing.Point(13, 40);
            this.RunTestsButton.Name = "RunTestsButton";
            this.RunTestsButton.Size = new System.Drawing.Size(167, 23);
            this.RunTestsButton.TabIndex = 1;
            this.RunTestsButton.Text = "Run";
            this.RunTestsButton.UseVisualStyleBackColor = true;
            this.RunTestsButton.Click += new System.EventHandler(this.RunTestsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SingleBitOnesLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SingleBitPassedLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single bit test (FIPS)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "/ 20 000";
            // 
            // SingleBitOnesLabel
            // 
            this.SingleBitOnesLabel.AutoSize = true;
            this.SingleBitOnesLabel.Location = new System.Drawing.Point(144, 20);
            this.SingleBitOnesLabel.Name = "SingleBitOnesLabel";
            this.SingleBitOnesLabel.Size = new System.Drawing.Size(40, 13);
            this.SingleBitOnesLabel.TabIndex = 2;
            this.SingleBitOnesLabel.Text = "10 000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ones:";
            // 
            // SingleBitPassedLabel
            // 
            this.SingleBitPassedLabel.AutoSize = true;
            this.SingleBitPassedLabel.Location = new System.Drawing.Point(7, 20);
            this.SingleBitPassedLabel.Name = "SingleBitPassedLabel";
            this.SingleBitPassedLabel.Size = new System.Drawing.Size(43, 13);
            this.SingleBitPassedLabel.TabIndex = 0;
            this.SingleBitPassedLabel.Text = "Waiting";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(186, 40);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(147, 23);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PValueLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PokerPassedLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poker test (FIPS)";
            // 
            // PValueLabel
            // 
            this.PValueLabel.AutoSize = true;
            this.PValueLabel.Location = new System.Drawing.Point(144, 20);
            this.PValueLabel.Name = "PValueLabel";
            this.PValueLabel.Size = new System.Drawing.Size(13, 13);
            this.PValueLabel.TabIndex = 2;
            this.PValueLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "P:";
            // 
            // PokerPassedLabel
            // 
            this.PokerPassedLabel.AutoSize = true;
            this.PokerPassedLabel.Location = new System.Drawing.Point(7, 20);
            this.PokerPassedLabel.Name = "PokerPassedLabel";
            this.PokerPassedLabel.Size = new System.Drawing.Size(43, 13);
            this.PokerPassedLabel.TabIndex = 0;
            this.PokerPassedLabel.Text = "Waiting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BlockStatistic);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(340, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Block-gap test";
            // 
            // BlockStatistic
            // 
            this.BlockStatistic.AutoSize = true;
            this.BlockStatistic.Location = new System.Drawing.Point(144, 20);
            this.BlockStatistic.Name = "BlockStatistic";
            this.BlockStatistic.Size = new System.Drawing.Size(13, 13);
            this.BlockStatistic.TabIndex = 2;
            this.BlockStatistic.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "S:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShiftBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.AutocorrelationStatisticLabel);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(340, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 55);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autocorrelation test";
            // 
            // ShiftBox
            // 
            this.ShiftBox.Location = new System.Drawing.Point(245, 35);
            this.ShiftBox.Name = "ShiftBox";
            this.ShiftBox.Size = new System.Drawing.Size(70, 20);
            this.ShiftBox.TabIndex = 5;
            this.ShiftBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Shift:";
            // 
            // AutocorrelationStatisticLabel
            // 
            this.AutocorrelationStatisticLabel.AutoSize = true;
            this.AutocorrelationStatisticLabel.Location = new System.Drawing.Point(144, 20);
            this.AutocorrelationStatisticLabel.Name = "AutocorrelationStatisticLabel";
            this.AutocorrelationStatisticLabel.Size = new System.Drawing.Size(13, 13);
            this.AutocorrelationStatisticLabel.TabIndex = 2;
            this.AutocorrelationStatisticLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "S:";
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 196);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RunTestsButton);
            this.Controls.Add(this.PathBox);
            this.Name = "TestForm";
            this.Text = "Generator Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button RunTestsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SingleBitOnesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SingleBitPassedLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PValueLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PokerPassedLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label BlockStatistic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label AutocorrelationStatisticLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ShiftBox;
        private System.Windows.Forms.Label label7;
    }
}

