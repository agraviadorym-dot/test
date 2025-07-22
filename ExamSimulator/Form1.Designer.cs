namespace ExamSimulator
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbtnChoice1 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice2 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice3 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblQuestion
            //
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            //
            // rbtnChoice1
            //
            this.rbtnChoice1.AutoSize = true;
            this.rbtnChoice1.Location = new System.Drawing.Point(15, 40);
            this.rbtnChoice1.Name = "rbtnChoice1";
            this.rbtnChoice1.Size = new System.Drawing.Size(62, 17);
            this.rbtnChoice1.TabIndex = 1;
            this.rbtnChoice1.TabStop = true;
            this.rbtnChoice1.Text = "Choice1";
            this.rbtnChoice1.UseVisualStyleBackColor = true;
            //
            // rbtnChoice2
            //
            this.rbtnChoice2.AutoSize = true;
            this.rbtnChoice2.Location = new System.Drawing.Point(15, 63);
            this.rbtnChoice2.Name = "rbtnChoice2";
            this.rbtnChoice2.Size = new System.Drawing.Size(62, 17);
            this.rbtnChoice2.TabIndex = 2;
            this.rbtnChoice2.TabStop = true;
            this.rbtnChoice2.Text = "Choice2";
            this.rbtnChoice2.UseVisualStyleBackColor = true;
            //
            // rbtnChoice3
            //
            this.rbtnChoice3.AutoSize = true;
            this.rbtnChoice3.Location = new System.Drawing.Point(15, 86);
            this.rbtnChoice3.Name = "rbtnChoice3";
            this.rbtnChoice3.Size = new System.Drawing.Size(62, 17);
            this.rbtnChoice3.TabIndex = 3;
            this.rbtnChoice3.TabStop = true;
            this.rbtnChoice3.Text = "Choice3";
            this.rbtnChoice3.UseVisualStyleBackColor = true;
            //
            // rbtnChoice4
            //
            this.rbtnChoice4.AutoSize = true;
            this.rbtnChoice4.Location = new System.Drawing.Point(15, 109);
            this.rbtnChoice4.Name = "rbtnChoice4";
            this.rbtnChoice4.Size = new System.Drawing.Size(62, 17);
            this.rbtnChoice4.TabIndex = 4;
            this.rbtnChoice4.TabStop = true;
            this.rbtnChoice4.Text = "Choice4";
            this.rbtnChoice4.UseVisualStyleBackColor = true;
            //
            // btnSubmit
            //
            this.btnSubmit.Location = new System.Drawing.Point(15, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            //
            // btnNext
            //
            this.btnNext.Location = new System.Drawing.Point(96, 145);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            //
            // lblScore
            //
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 180);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnChoice4);
            this.Controls.Add(this.rbtnChoice3);
            this.Controls.Add(this.rbtnChoice2);
            this.Controls.Add(this.rbtnChoice1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Exam Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbtnChoice1;
        private System.Windows.Forms.RadioButton rbtnChoice2;
        private System.Windows.Forms.RadioButton rbtnChoice3;
        private System.Windows.Forms.RadioButton rbtnChoice4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
    }
}
