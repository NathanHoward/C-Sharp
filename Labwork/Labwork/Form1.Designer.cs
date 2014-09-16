namespace Labwork
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calcAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 34);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 0;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(175, 34);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(175, 76);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "button1";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.AddFromCode);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // calcAverage
            // 
            this.calcAverage.Location = new System.Drawing.Point(175, 209);
            this.calcAverage.Name = "calcAverage";
            this.calcAverage.Size = new System.Drawing.Size(75, 23);
            this.calcAverage.TabIndex = 4;
            this.calcAverage.Text = "button1";
            this.calcAverage.UseVisualStyleBackColor = true;
            this.calcAverage.Click += new System.EventHandler(this.calcAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calcAverage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calcAverage;

    }
}

