namespace mmelichar_Topic3_activity7
{
    partial class mmelichar_Topic3_Activity7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mmelichar_Topic3_Activity7));
            this.lblInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblOutputDescription = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(75, 64);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(202, 15);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Number of terms to estimate pi with:";
            this.lblInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(283, 61);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxInput.TabIndex = 1;
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(183, 128);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 2;
            this.btnClickThis.Text = "Estimate";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblOutputDescription
            // 
            this.lblOutputDescription.AutoSize = true;
            this.lblOutputDescription.Location = new System.Drawing.Point(95, 95);
            this.lblOutputDescription.Name = "lblOutputDescription";
            this.lblOutputDescription.Size = new System.Drawing.Size(182, 15);
            this.lblOutputDescription.TabIndex = 3;
            this.lblOutputDescription.Text = "Pi is approximately equivalent to ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(283, 95);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(17, 15);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "--";
            // 
            // mmelichar_Topic3_Activity7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 172);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOutputDescription);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mmelichar_Topic3_Activity7";
            this.Text = "Pi Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInput;
        private TextBox textBoxInput;
        private Button btnClickThis;
        private Label lblOutputDescription;
        private Label lblOutput;
    }
}