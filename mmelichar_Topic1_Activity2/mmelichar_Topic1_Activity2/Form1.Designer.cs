namespace mmelichar_Topic1_Activity2
{
    partial class Activity2_mmelichar
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
            this.lblInputLabel = new System.Windows.Forms.Label();
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputLabel
            // 
            this.lblInputLabel.AutoSize = true;
            this.lblInputLabel.Location = new System.Drawing.Point(67, 27);
            this.lblInputLabel.Name = "lblInputLabel";
            this.lblInputLabel.Size = new System.Drawing.Size(150, 15);
            this.lblInputLabel.TabIndex = 2;
            this.lblInputLabel.Text = "Enter your weight on Earth:";
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(98, 56);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.Size = new System.Drawing.Size(119, 15);
            this.lblOutputLabel.TabIndex = 3;
            this.lblOutputLabel.Text = "Your weight on Mars:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(223, 19);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxInput.TabIndex = 6;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(223, 48);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutput.TabIndex = 7;
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(223, 77);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 8;
            this.btnClickThis.Text = "Convert";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // Activity2_mmelichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 110);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblOutputLabel);
            this.Controls.Add(this.lblInputLabel);
            this.Name = "Activity2_mmelichar";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInputLabel;
        private Label lblOutputLabel;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button btnClickThis;
    }
}