namespace POS409_Learning_Team_1.Forms
{
    partial class AorBForm
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
            this.optionA = new System.Windows.Forms.Button();
            this.optionB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionA
            // 
            this.optionA.Location = new System.Drawing.Point(60, 37);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(144, 38);
            this.optionA.TabIndex = 0;
            this.optionA.Text = "button1";
            this.optionA.UseVisualStyleBackColor = true;
            this.optionA.Click += new System.EventHandler(this.OptionA_Click);
            // 
            // optionB
            // 
            this.optionB.Location = new System.Drawing.Point(285, 37);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(144, 38);
            this.optionB.TabIndex = 1;
            this.optionB.Text = "button2";
            this.optionB.UseVisualStyleBackColor = true;
            this.optionB.Click += new System.EventHandler(this.OptionB_Click);
            // 
            // AorBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 110);
            this.Controls.Add(this.optionB);
            this.Controls.Add(this.optionA);
            this.Name = "AorBForm";
            this.Text = "AorBForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionA;
        private System.Windows.Forms.Button optionB;
    }
}