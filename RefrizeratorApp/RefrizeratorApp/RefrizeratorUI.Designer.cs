namespace RefrizeratorApp
{
    partial class RefrizeratorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.saveCapacityButton = new System.Windows.Forms.Button();
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum weight it can take";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. of items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current (Weight)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remaining (Weight)";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(192, 23);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 5;
            // 
            // saveCapacityButton
            // 
            this.saveCapacityButton.Location = new System.Drawing.Point(382, 20);
            this.saveCapacityButton.Name = "saveCapacityButton";
            this.saveCapacityButton.Size = new System.Drawing.Size(75, 23);
            this.saveCapacityButton.TabIndex = 6;
            this.saveCapacityButton.Text = "Save";
            this.saveCapacityButton.UseVisualStyleBackColor = true;
            this.saveCapacityButton.Click += new System.EventHandler(this.saveCapacityButton_Click);
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Location = new System.Drawing.Point(192, 95);
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemsTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Weight (kg)/unit";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(452, 98);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 9;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(569, 101);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(192, 167);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentWeightTextBox.TabIndex = 11;
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(452, 174);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 12;
            // 
            // RefrizeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 360);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemsTextBox);
            this.Controls.Add(this.saveCapacityButton);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefrizeratorUI";
            this.Text = "RefrizeratorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Button saveCapacityButton;
        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
    }
}

