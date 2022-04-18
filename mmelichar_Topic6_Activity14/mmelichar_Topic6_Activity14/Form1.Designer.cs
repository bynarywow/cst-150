namespace mmelichar_Topic6_Activity14
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
            this.dogCheckBox = new System.Windows.Forms.CheckBox();
            this.catCheckBox = new System.Windows.Forms.CheckBox();
            this.CountyListBox = new System.Windows.Forms.ListBox();
            this.hotRadioBtn = new System.Windows.Forms.RadioButton();
            this.coldRadioBtn = new System.Windows.Forms.RadioButton();
            this.labelCounty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOutputCounty = new System.Windows.Forms.Label();
            this.labelOutputLike = new System.Windows.Forms.Label();
            this.labelOutputWeather = new System.Windows.Forms.Label();
            this.animalOutput = new System.Windows.Forms.ListBox();
            this.weatherOutput = new System.Windows.Forms.Label();
            this.outputCounty = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dogCheckBox
            // 
            this.dogCheckBox.AutoSize = true;
            this.dogCheckBox.Location = new System.Drawing.Point(34, 152);
            this.dogCheckBox.Name = "dogCheckBox";
            this.dogCheckBox.Size = new System.Drawing.Size(53, 19);
            this.dogCheckBox.TabIndex = 0;
            this.dogCheckBox.Text = "Dogs";
            this.dogCheckBox.UseVisualStyleBackColor = true;
            this.dogCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // catCheckBox
            // 
            this.catCheckBox.AutoSize = true;
            this.catCheckBox.Location = new System.Drawing.Point(34, 177);
            this.catCheckBox.Name = "catCheckBox";
            this.catCheckBox.Size = new System.Drawing.Size(49, 19);
            this.catCheckBox.TabIndex = 1;
            this.catCheckBox.Text = "Cats";
            this.catCheckBox.UseVisualStyleBackColor = true;
            this.catCheckBox.CheckedChanged += new System.EventHandler(this.catCheckBox_CheckedChanged);
            // 
            // CountyListBox
            // 
            this.CountyListBox.FormattingEnabled = true;
            this.CountyListBox.ItemHeight = 15;
            this.CountyListBox.Items.AddRange(new object[] {
            "Apache",
            "Cochise",
            "Coconino",
            "Gila",
            "Graham",
            "Greenlee",
            "La Paz",
            "Maricopa",
            "Mohave",
            "Navajo",
            "Pima",
            "Pinal",
            "Santa Cruz",
            "Yavapai",
            "Yuma"});
            this.CountyListBox.Location = new System.Drawing.Point(28, 28);
            this.CountyListBox.Name = "CountyListBox";
            this.CountyListBox.Size = new System.Drawing.Size(120, 94);
            this.CountyListBox.TabIndex = 2;
            this.CountyListBox.SelectedIndexChanged += new System.EventHandler(this.countyListBox_SelectedIndexChanged);
            // 
            // hotRadioBtn
            // 
            this.hotRadioBtn.AutoSize = true;
            this.hotRadioBtn.Location = new System.Drawing.Point(6, 22);
            this.hotRadioBtn.Name = "hotRadioBtn";
            this.hotRadioBtn.Size = new System.Drawing.Size(45, 19);
            this.hotRadioBtn.TabIndex = 3;
            this.hotRadioBtn.TabStop = true;
            this.hotRadioBtn.Text = "Hot";
            this.hotRadioBtn.UseVisualStyleBackColor = true;
            this.hotRadioBtn.CheckedChanged += new System.EventHandler(this.hotCheckBox_CheckedChanged);
            // 
            // coldRadioBtn
            // 
            this.coldRadioBtn.AutoSize = true;
            this.coldRadioBtn.Location = new System.Drawing.Point(6, 47);
            this.coldRadioBtn.Name = "coldRadioBtn";
            this.coldRadioBtn.Size = new System.Drawing.Size(66, 19);
            this.coldRadioBtn.TabIndex = 4;
            this.coldRadioBtn.TabStop = true;
            this.coldRadioBtn.Text = "Not hot";
            this.coldRadioBtn.UseVisualStyleBackColor = true;
            this.coldRadioBtn.CheckedChanged += new System.EventHandler(this.coldRadioBtn_CheckedChanged);
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Location = new System.Drawing.Point(28, 10);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(156, 15);
            this.labelCounty.TabIndex = 6;
            this.labelCounty.Text = "What County do you live in?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Do you like:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotRadioBtn);
            this.groupBox1.Controls.Add(this.coldRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your favorite Arizona season:";
            // 
            // labelOutputCounty
            // 
            this.labelOutputCounty.Location = new System.Drawing.Point(253, 28);
            this.labelOutputCounty.Name = "labelOutputCounty";
            this.labelOutputCounty.Size = new System.Drawing.Size(195, 15);
            this.labelOutputCounty.TabIndex = 10;
            this.labelOutputCounty.Text = "The Arizona County I live in:";
            this.labelOutputCounty.Click += new System.EventHandler(this.labelOutputDay_Click);
            // 
            // labelOutputLike
            // 
            this.labelOutputLike.Location = new System.Drawing.Point(253, 134);
            this.labelOutputLike.Name = "labelOutputLike";
            this.labelOutputLike.Size = new System.Drawing.Size(41, 15);
            this.labelOutputLike.TabIndex = 11;
            this.labelOutputLike.Text = "I like:";
            // 
            // labelOutputWeather
            // 
            this.labelOutputWeather.Location = new System.Drawing.Point(253, 213);
            this.labelOutputWeather.Name = "labelOutputWeather";
            this.labelOutputWeather.Size = new System.Drawing.Size(112, 18);
            this.labelOutputWeather.TabIndex = 12;
            this.labelOutputWeather.Text = "I like the weather:";
            // 
            // animalOutput
            // 
            this.animalOutput.FormattingEnabled = true;
            this.animalOutput.ItemHeight = 15;
            this.animalOutput.Location = new System.Drawing.Point(253, 152);
            this.animalOutput.Name = "animalOutput";
            this.animalOutput.Size = new System.Drawing.Size(112, 49);
            this.animalOutput.TabIndex = 13;
            // 
            // weatherOutput
            // 
            this.weatherOutput.AutoSize = true;
            this.weatherOutput.Location = new System.Drawing.Point(352, 213);
            this.weatherOutput.Name = "weatherOutput";
            this.weatherOutput.Size = new System.Drawing.Size(0, 15);
            this.weatherOutput.TabIndex = 15;
            // 
            // outputCounty
            // 
            this.outputCounty.FormattingEnabled = true;
            this.outputCounty.ItemHeight = 15;
            this.outputCounty.Location = new System.Drawing.Point(253, 46);
            this.outputCounty.Name = "outputCounty";
            this.outputCounty.Size = new System.Drawing.Size(112, 64);
            this.outputCounty.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 301);
            this.Controls.Add(this.outputCounty);
            this.Controls.Add(this.weatherOutput);
            this.Controls.Add(this.animalOutput);
            this.Controls.Add(this.labelOutputWeather);
            this.Controls.Add(this.labelOutputLike);
            this.Controls.Add(this.labelOutputCounty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCounty);
            this.Controls.Add(this.CountyListBox);
            this.Controls.Add(this.catCheckBox);
            this.Controls.Add(this.dogCheckBox);
            this.Name = "Form1";
            this.Text = "Simple Introductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox dogCheckBox;
        private CheckBox catCheckBox;
        private ListBox CountyListBox;
        private RadioButton hotRadioBtn;
        private RadioButton coldRadioBtn;
        private Label labelCounty;
        private Label label2;
        private GroupBox groupBox1;
        private Label labelOutputCounty;
        private Label labelOutputLike;
        private Label labelOutputWeather;
        private ListBox animalOutput;
        private Label weatherOutput;
        private ListBox outputCounty;
    }
}