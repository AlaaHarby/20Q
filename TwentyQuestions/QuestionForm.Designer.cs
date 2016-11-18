namespace TwentyQuestions
{
    partial class branch_form
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
            this.q_label = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q_label
            // 
            this.q_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.q_label.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_label.Location = new System.Drawing.Point(-6, 87);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(829, 70);
            this.q_label.TabIndex = 0;
            this.q_label.Text = "label";
            this.q_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.q_label.UseMnemonic = false;
            // 
            // yes_button
            // 
            this.yes_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yes_button.AutoSize = true;
            this.yes_button.Font = new System.Drawing.Font("Pristina", 12F);
            this.yes_button.Location = new System.Drawing.Point(171, 236);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(134, 45);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // no_button
            // 
            this.no_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.no_button.AutoSize = true;
            this.no_button.Font = new System.Drawing.Font("Pristina", 12F);
            this.no_button.Location = new System.Drawing.Point(520, 236);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(134, 45);
            this.no_button.TabIndex = 2;
            this.no_button.Text = "No";
            this.no_button.UseVisualStyleBackColor = true;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // branch_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 397);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.q_label);
            this.Name = "branch_form";
            this.Text = "Twenty questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
    }
}

