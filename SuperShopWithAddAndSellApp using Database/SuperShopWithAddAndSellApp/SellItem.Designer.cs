namespace SuperShopWithAddAndSellApp
{
    partial class SellItem
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sellItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sellQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellProductIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.sellItemButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sellQuantityTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sellProductIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(93, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 311);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "product Info";
            // 
            // sellItemButton
            // 
            this.sellItemButton.Location = new System.Drawing.Point(144, 101);
            this.sellItemButton.Name = "sellItemButton";
            this.sellItemButton.Size = new System.Drawing.Size(75, 23);
            this.sellItemButton.TabIndex = 3;
            this.sellItemButton.Text = "Sell Item";
            this.sellItemButton.UseVisualStyleBackColor = true;
            this.sellItemButton.Click += new System.EventHandler(this.sellItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "quantity";
            // 
            // sellQuantityTextBox
            // 
            this.sellQuantityTextBox.Location = new System.Drawing.Point(88, 64);
            this.sellQuantityTextBox.Name = "sellQuantityTextBox";
            this.sellQuantityTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellQuantityTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product/Item ID";
            // 
            // sellProductIdTextBox
            // 
            this.sellProductIdTextBox.Location = new System.Drawing.Point(88, 27);
            this.sellProductIdTextBox.Name = "sellProductIdTextBox";
            this.sellProductIdTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellProductIdTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // SellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 392);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellItem";
            this.Text = "SellItem";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sellItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellProductIdTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}