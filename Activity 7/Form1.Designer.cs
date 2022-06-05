namespace Activity_7
{
    partial class Approximate_Pi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Approximate_Pi));
            this.PromptLB = new System.Windows.Forms.Label();
            this.NumTermsTB = new System.Windows.Forms.TextBox();
            this.CalculateBTN = new System.Windows.Forms.Button();
            this.TermsLBL = new System.Windows.Forms.Label();
            this.ResultLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PromptLB
            // 
            this.PromptLB.AutoSize = true;
            this.PromptLB.Location = new System.Drawing.Point(34, 36);
            this.PromptLB.Name = "PromptLB";
            this.PromptLB.Size = new System.Drawing.Size(85, 13);
            this.PromptLB.TabIndex = 0;
            this.PromptLB.Text = "Enter # of terms:";
            // 
            // NumTermsTB
            // 
            this.NumTermsTB.Location = new System.Drawing.Point(125, 33);
            this.NumTermsTB.Name = "NumTermsTB";
            this.NumTermsTB.Size = new System.Drawing.Size(100, 20);
            this.NumTermsTB.TabIndex = 1;
            // 
            // CalculateBTN
            // 
            this.CalculateBTN.Location = new System.Drawing.Point(37, 65);
            this.CalculateBTN.Name = "CalculateBTN";
            this.CalculateBTN.Size = new System.Drawing.Size(188, 40);
            this.CalculateBTN.TabIndex = 2;
            this.CalculateBTN.Text = "Calculate";
            this.CalculateBTN.UseVisualStyleBackColor = true;
            this.CalculateBTN.Click += new System.EventHandler(this.CalculateBTN_Click);
            // 
            // TermsLBL
            // 
            this.TermsLBL.AutoSize = true;
            this.TermsLBL.Location = new System.Drawing.Point(37, 123);
            this.TermsLBL.Name = "TermsLBL";
            this.TermsLBL.Size = new System.Drawing.Size(0, 13);
            this.TermsLBL.TabIndex = 3;
            // 
            // ResultLBL
            // 
            this.ResultLBL.AutoSize = true;
            this.ResultLBL.Location = new System.Drawing.Point(37, 151);
            this.ResultLBL.Name = "ResultLBL";
            this.ResultLBL.Size = new System.Drawing.Size(0, 13);
            this.ResultLBL.TabIndex = 4;
            // 
            // Approximate_Pi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.ResultLBL);
            this.Controls.Add(this.TermsLBL);
            this.Controls.Add(this.CalculateBTN);
            this.Controls.Add(this.NumTermsTB);
            this.Controls.Add(this.PromptLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Approximate_Pi";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLB;
        private System.Windows.Forms.TextBox NumTermsTB;
        private System.Windows.Forms.Button CalculateBTN;
        private System.Windows.Forms.Label TermsLBL;
        private System.Windows.Forms.Label ResultLBL;
    }
}

