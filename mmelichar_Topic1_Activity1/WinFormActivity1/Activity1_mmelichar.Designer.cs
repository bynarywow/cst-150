namespace WinFormActivity1
{
    partial class Activity1_mmelichar
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblInputLabel = new System.Windows.Forms.Label();
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.lblOutputNumber = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(114, 75);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Double it!";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInputLabel
            // 
            this.lblInputLabel.AutoSize = true;
            this.lblInputLabel.Location = new System.Drawing.Point(39, 25);
            this.lblInputLabel.Name = "lblInputLabel";
            this.lblInputLabel.Size = new System.Drawing.Size(109, 15);
            this.lblInputLabel.TabIndex = 1;
            this.lblInputLabel.Text = "Number to Double:";
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(46, 54);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.Size = new System.Drawing.Size(102, 15);
            this.lblOutputLabel.TabIndex = 2;
            this.lblOutputLabel.Text = "Doubled Number:";
            // 
            // lblOutputNumber
            // 
            this.lblOutputNumber.AutoSize = true;
            this.lblOutputNumber.Location = new System.Drawing.Point(114, 54);
            this.lblOutputNumber.Name = "lblOutputNumber";
            this.lblOutputNumber.Size = new System.Drawing.Size(0, 15);
            this.lblOutputNumber.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(154, 17);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxInput.TabIndex = 5;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(154, 46);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutput.TabIndex = 6;
            // 
            // Activity1_mmelichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 108);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblOutputNumber);
            this.Controls.Add(this.lblOutputLabel);
            this.Controls.Add(this.lblInputLabel);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Activity1_mmelichar";
            this.Text = "Number Doubler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClickThis;
        private Label lblInputLabel;
        private Label lblOutputLabel;
        private Label lblOutputNumber;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
    }
}