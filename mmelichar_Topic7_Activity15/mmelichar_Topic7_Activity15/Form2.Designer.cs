namespace mmelichar_Topic7_Activity15
{
    partial class FormOutput
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
            this.lblOutputLucky = new System.Windows.Forms.Label();
            this.lblLuckyNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutputLucky
            // 
            this.lblOutputLucky.AutoSize = true;
            this.lblOutputLucky.Location = new System.Drawing.Point(88, 46);
            this.lblOutputLucky.Name = "lblOutputLucky";
            this.lblOutputLucky.Size = new System.Drawing.Size(118, 15);
            this.lblOutputLucky.TabIndex = 0;
            this.lblOutputLucky.Text = "Your lucky number is";
            this.lblOutputLucky.Click += new System.EventHandler(this.lblOutputLucky_Click);
            // 
            // lblLuckyNumber
            // 
            this.lblLuckyNumber.AutoSize = true;
            this.lblLuckyNumber.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLuckyNumber.Location = new System.Drawing.Point(88, 67);
            this.lblLuckyNumber.Name = "lblLuckyNumber";
            this.lblLuckyNumber.Size = new System.Drawing.Size(92, 106);
            this.lblLuckyNumber.TabIndex = 1;
            this.lblLuckyNumber.Text = "o";
            // 
            // FormOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 204);
            this.Controls.Add(this.lblLuckyNumber);
            this.Controls.Add(this.lblOutputLucky);
            this.Name = "FormOutput";
            this.Text = "Your Results!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOutputLucky;
        private Label lblLuckyNumber;
    }
}