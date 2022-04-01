namespace mmelichar_topic4_activity8
{
    partial class Form1
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
            this.fatGramsLbl = new System.Windows.Forms.Label();
            this.carbGramsLbl = new System.Windows.Forms.Label();
            this.fatCalOutput = new System.Windows.Forms.Label();
            this.carbCalOutput = new System.Windows.Forms.Label();
            this.fatGramsInput = new System.Windows.Forms.TextBox();
            this.carbGramsInput = new System.Windows.Forms.TextBox();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatGramsLbl
            // 
            this.fatGramsLbl.AutoSize = true;
            this.fatGramsLbl.Location = new System.Drawing.Point(56, 26);
            this.fatGramsLbl.Name = "fatGramsLbl";
            this.fatGramsLbl.Size = new System.Drawing.Size(153, 15);
            this.fatGramsLbl.TabIndex = 0;
            this.fatGramsLbl.Text = "Fat Grams Consumed Daily:";
            // 
            // carbGramsLbl
            // 
            this.carbGramsLbl.AutoSize = true;
            this.carbGramsLbl.Location = new System.Drawing.Point(56, 58);
            this.carbGramsLbl.Name = "carbGramsLbl";
            this.carbGramsLbl.Size = new System.Drawing.Size(162, 15);
            this.carbGramsLbl.TabIndex = 1;
            this.carbGramsLbl.Text = "Carb Grams Consumed Daily:";
            // 
            // fatCalOutput
            // 
            this.fatCalOutput.AutoSize = true;
            this.fatCalOutput.Location = new System.Drawing.Point(56, 93);
            this.fatCalOutput.Name = "fatCalOutput";
            this.fatCalOutput.Size = new System.Drawing.Size(0, 15);
            this.fatCalOutput.TabIndex = 2;
            // 
            // carbCalOutput
            // 
            this.carbCalOutput.AutoSize = true;
            this.carbCalOutput.Location = new System.Drawing.Point(56, 119);
            this.carbCalOutput.Name = "carbCalOutput";
            this.carbCalOutput.Size = new System.Drawing.Size(0, 15);
            this.carbCalOutput.TabIndex = 3;
            // 
            // fatGramsInput
            // 
            this.fatGramsInput.Location = new System.Drawing.Point(224, 23);
            this.fatGramsInput.Name = "fatGramsInput";
            this.fatGramsInput.Size = new System.Drawing.Size(100, 23);
            this.fatGramsInput.TabIndex = 4;
            // 
            // carbGramsInput
            // 
            this.carbGramsInput.Location = new System.Drawing.Point(224, 55);
            this.carbGramsInput.Name = "carbGramsInput";
            this.carbGramsInput.Size = new System.Drawing.Size(100, 23);
            this.carbGramsInput.TabIndex = 5;
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(143, 151);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 6;
            this.btnClickThis.Text = "Calculate";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 192);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.carbGramsInput);
            this.Controls.Add(this.fatGramsInput);
            this.Controls.Add(this.carbCalOutput);
            this.Controls.Add(this.fatCalOutput);
            this.Controls.Add(this.carbGramsLbl);
            this.Controls.Add(this.fatGramsLbl);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fatGramsLbl;
        private Label carbGramsLbl;
        private Label fatCalOutput;
        private Label carbCalOutput;
        private TextBox fatGramsInput;
        private TextBox carbGramsInput;
        private Button btnClickThis;
    }
}