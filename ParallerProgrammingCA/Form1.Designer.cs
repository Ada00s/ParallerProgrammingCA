
namespace ParallerProgrammingCA
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
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historyLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // minNum
            // 
            this.minNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minNum.Location = new System.Drawing.Point(77, 65);
            this.minNum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.minNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(150, 27);
            this.minNum.TabIndex = 0;
            this.minNum.ThousandsSeparator = true;
            this.minNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maxNum
            // 
            this.maxNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxNum.Location = new System.Drawing.Point(346, 65);
            this.maxNum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.maxNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(150, 27);
            this.maxNum.TabIndex = 1;
            this.maxNum.ThousandsSeparator = true;
            this.maxNum.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Parallely";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Sequentially";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 20;
            this.Results.Location = new System.Drawing.Point(420, 139);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(448, 244);
            this.Results.TabIndex = 4;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(497, 475);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(409, 27);
            this.timerBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "History:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // historyLog
            // 
            this.historyLog.Location = new System.Drawing.Point(29, 260);
            this.historyLog.Multiline = true;
            this.historyLog.Name = "historyLog";
            this.historyLog.Size = new System.Drawing.Size(361, 228);
            this.historyLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 514);
            this.Controls.Add(this.historyLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.minNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox historyLog;
    }
}

