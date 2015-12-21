namespace Stegano
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
            this.ImagePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessagePathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TargetPathBox = new System.Windows.Forms.TextBox();
            this.WriteButton = new System.Windows.Forms.Button();
            this.WriteGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ImageReadBox = new System.Windows.Forms.TextBox();
            this.ReadSaveAsBox = new System.Windows.Forms.TextBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePathBox
            // 
            this.ImagePathBox.Location = new System.Drawing.Point(79, 19);
            this.ImagePathBox.Name = "ImagePathBox";
            this.ImagePathBox.Size = new System.Drawing.Size(259, 20);
            this.ImagePathBox.TabIndex = 0;
            this.ImagePathBox.Text = "E:\\img.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // MessagePathBox
            // 
            this.MessagePathBox.Location = new System.Drawing.Point(79, 45);
            this.MessagePathBox.Name = "MessagePathBox";
            this.MessagePathBox.Size = new System.Drawing.Size(259, 20);
            this.MessagePathBox.TabIndex = 3;
            this.MessagePathBox.Text = "E:\\test.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save as";
            // 
            // TargetPathBox
            // 
            this.TargetPathBox.Location = new System.Drawing.Point(79, 71);
            this.TargetPathBox.Name = "TargetPathBox";
            this.TargetPathBox.Size = new System.Drawing.Size(259, 20);
            this.TargetPathBox.TabIndex = 5;
            this.TargetPathBox.Text = "E:\\Stegano.bmp";
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(12, 97);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(326, 38);
            this.WriteButton.TabIndex = 6;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // WriteGroup
            // 
            this.WriteGroup.Controls.Add(this.label2);
            this.WriteGroup.Controls.Add(this.label3);
            this.WriteGroup.Controls.Add(this.label1);
            this.WriteGroup.Controls.Add(this.ImagePathBox);
            this.WriteGroup.Controls.Add(this.MessagePathBox);
            this.WriteGroup.Controls.Add(this.TargetPathBox);
            this.WriteGroup.Controls.Add(this.WriteButton);
            this.WriteGroup.Location = new System.Drawing.Point(16, 6);
            this.WriteGroup.Name = "WriteGroup";
            this.WriteGroup.Size = new System.Drawing.Size(344, 145);
            this.WriteGroup.TabIndex = 7;
            this.WriteGroup.TabStop = false;
            this.WriteGroup.Text = "Write";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ImageReadBox);
            this.groupBox1.Controls.Add(this.ReadSaveAsBox);
            this.groupBox1.Controls.Add(this.ReadButton);
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Save as";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Image";
            // 
            // ImageReadBox
            // 
            this.ImageReadBox.Location = new System.Drawing.Point(79, 19);
            this.ImageReadBox.Name = "ImageReadBox";
            this.ImageReadBox.Size = new System.Drawing.Size(259, 20);
            this.ImageReadBox.TabIndex = 0;
            this.ImageReadBox.Text = "E:\\Stegano.bmp";
            // 
            // ReadSaveAsBox
            // 
            this.ReadSaveAsBox.Location = new System.Drawing.Point(79, 45);
            this.ReadSaveAsBox.Name = "ReadSaveAsBox";
            this.ReadSaveAsBox.Size = new System.Drawing.Size(259, 20);
            this.ReadSaveAsBox.TabIndex = 5;
            this.ReadSaveAsBox.Text = "E:\\Read.txt";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(6, 91);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(326, 38);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WriteGroup);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WriteGroup.ResumeLayout(false);
            this.WriteGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ImagePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessagePathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TargetPathBox;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.GroupBox WriteGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ImageReadBox;
        private System.Windows.Forms.TextBox ReadSaveAsBox;
        private System.Windows.Forms.Button ReadButton;
    }
}

