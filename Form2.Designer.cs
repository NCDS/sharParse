namespace sharParse
{
    partial class set_partialMatches
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
            this.cb_enablePartialMatches = new System.Windows.Forms.CheckBox();
            this.pm_amount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_enablePartialMatches
            // 
            this.cb_enablePartialMatches.AutoSize = true;
            this.cb_enablePartialMatches.Location = new System.Drawing.Point(15, 44);
            this.cb_enablePartialMatches.Name = "cb_enablePartialMatches";
            this.cb_enablePartialMatches.Size = new System.Drawing.Size(141, 17);
            this.cb_enablePartialMatches.TabIndex = 0;
            this.cb_enablePartialMatches.Text = "Enable Partial Matches?";
            this.cb_enablePartialMatches.UseVisualStyleBackColor = true;
            this.cb_enablePartialMatches.CheckedChanged += new System.EventHandler(this.cb_enablePartialMatches_CheckedChanged);
            // 
            // pm_amount
            // 
            this.pm_amount.FormattingEnabled = true;
            this.pm_amount.Location = new System.Drawing.Point(220, 9);
            this.pm_amount.Name = "pm_amount";
            this.pm_amount.Size = new System.Drawing.Size(121, 21);
            this.pm_amount.TabIndex = 1;
            this.pm_amount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum Number of Characters to Match:";
            // 
            // set_partialMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 68);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pm_amount);
            this.Controls.Add(this.cb_enablePartialMatches);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "set_partialMatches";
            this.Text = "Settings / Parial Matches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_enablePartialMatches;
        private System.Windows.Forms.ComboBox pm_amount;
        private System.Windows.Forms.Label label1;
    }
}