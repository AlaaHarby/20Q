namespace TwentyQuestions
{
    partial class NewQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.question_text = new System.Windows.Forms.TextBox();
            this.play_again = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorry! we couldn\'t guess what you were thinking!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "You were thinking of:";
            // 
            // answer_text
            // 
            this.answer_text.Location = new System.Drawing.Point(236, 88);
            this.answer_text.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(322, 39);
            this.answer_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add a question:";
            // 
            // question_text
            // 
            this.question_text.Location = new System.Drawing.Point(236, 156);
            this.question_text.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(322, 39);
            this.question_text.TabIndex = 4;
            // 
            // play_again
            // 
            this.play_again.AutoSize = true;
            this.play_again.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again.Location = new System.Drawing.Point(423, 239);
            this.play_again.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.play_again.Name = "play_again";
            this.play_again.Size = new System.Drawing.Size(135, 47);
            this.play_again.TabIndex = 5;
            this.play_again.Text = "Play again!";
            this.play_again.UseVisualStyleBackColor = true;
            this.play_again.Click += new System.EventHandler(this.play_again_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(423, 331);
            this.exit_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 47);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit game";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 419);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.play_again);
            this.Controls.Add(this.question_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "NewQuestionForm";
            this.Text = "Twenty Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answer_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Button play_again;
        private System.Windows.Forms.Button exit_button;
    }
}