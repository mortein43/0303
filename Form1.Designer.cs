namespace _0303
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            StopButton = new Button();
            numericGz = new NumericUpDown();
            numericLong = new NumericUpDown();
            numericNumber = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericGz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericNumber).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(101, 156);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(216, 156);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(75, 23);
            StopButton.TabIndex = 0;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // numericGz
            // 
            numericGz.Location = new Point(56, 77);
            numericGz.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericGz.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numericGz.Name = "numericGz";
            numericGz.Size = new Size(75, 23);
            numericGz.TabIndex = 1;
            numericGz.Value = new decimal(new int[] { 37, 0, 0, 0 });
            // 
            // numericLong
            // 
            numericLong.Location = new Point(151, 77);
            numericLong.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericLong.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericLong.Name = "numericLong";
            numericLong.Size = new Size(75, 23);
            numericLong.TabIndex = 1;
            numericLong.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericNumber
            // 
            numericNumber.Location = new Point(276, 77);
            numericNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericNumber.Name = "numericNumber";
            numericNumber.Size = new Size(75, 23);
            numericNumber.TabIndex = 1;
            numericNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Частота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 40);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Довжина звучання";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 40);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "К-сть звуків";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericNumber);
            Controls.Add(numericLong);
            Controls.Add(numericGz);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericGz).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private NumericUpDown numericGz;
        private NumericUpDown numericLong;
        private NumericUpDown numericNumber;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}