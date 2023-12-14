namespace WindowsFormsApp1
{
    partial class QuizQuestions
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
            this.rtbQuestions = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbQuestions
            // 
            this.rtbQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.rtbQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbQuestions.Location = new System.Drawing.Point(104, 181);
            this.rtbQuestions.Name = "rtbQuestions";
            this.rtbQuestions.ReadOnly = true;
            this.rtbQuestions.Size = new System.Drawing.Size(756, 96);
            this.rtbQuestions.TabIndex = 0;
            this.rtbQuestions.Text = "";
            this.rtbQuestions.TextChanged += new System.EventHandler(this.rtbQuestions_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 371);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 22);
            this.textBox1.TabIndex = 1;
            // 
            // QuizQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(966, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizQuestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQuestions;
        private System.Windows.Forms.TextBox textBox1;
    }
}