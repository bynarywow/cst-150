namespace mmelichar_Topic7_Milestone4
{
    partial class InventoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.labelSku = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnRestockItem = new System.Windows.Forms.Button();
            this.btnDisplayInventory = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(556, 178);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(12, 34);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 23);
            this.textBoxSku.TabIndex = 3;
            // 
            // labelSku
            // 
            this.labelSku.AutoSize = true;
            this.labelSku.Location = new System.Drawing.Point(12, 16);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(28, 15);
            this.labelSku.TabIndex = 4;
            this.labelSku.Text = "SKU";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(118, 16);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 15);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(118, 34);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(224, 16);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(224, 34);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(330, 16);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(330, 34);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 9;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 65);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(93, 65);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnRestockItem
            // 
            this.btnRestockItem.Location = new System.Drawing.Point(199, 65);
            this.btnRestockItem.Name = "btnRestockItem";
            this.btnRestockItem.Size = new System.Drawing.Size(92, 23);
            this.btnRestockItem.TabIndex = 13;
            this.btnRestockItem.Text = "Restock Item";
            this.btnRestockItem.UseVisualStyleBackColor = true;
            this.btnRestockItem.Click += new System.EventHandler(this.btnRestockItem_Click);
            // 
            // btnDisplayInventory
            // 
            this.btnDisplayInventory.Location = new System.Drawing.Point(297, 65);
            this.btnDisplayInventory.Name = "btnDisplayInventory";
            this.btnDisplayInventory.Size = new System.Drawing.Size(116, 23);
            this.btnDisplayInventory.TabIndex = 14;
            this.btnDisplayInventory.Text = "Display Inventory";
            this.btnDisplayInventory.UseVisualStyleBackColor = true;
            this.btnDisplayInventory.Click += new System.EventHandler(this.btnDisplayInventory_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(419, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 281);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDisplayInventory);
            this.Controls.Add(this.btnRestockItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForm";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBoxSku;
        private Label labelSku;
        private Label labelQuantity;
        private TextBox textBoxQuantity;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnRestockItem;
        private Button btnDisplayInventory;
        private Button button5;
    }
}