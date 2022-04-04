namespace mmelichar_Topic2_Activity4
{
    partial class mmelichar_activity4
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
            this.lblInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(130, 99);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Submit";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(39, 34);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(132, 15);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Enter a time in seconds:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(177, 27);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(39, 68);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 3;
            // 
            // mmelichar_activity4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 148);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnClickThis);
            this.Name = "mmelichar_activity4";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClickThis;
        private Label lblInput;
        private TextBox textBoxInput;
        private Label lblOutput;
    }
}