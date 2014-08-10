namespace StudentAPP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.regTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deptSaveButton = new System.Windows.Forms.Button();
            this.studentSaveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentDataSet = new StudentAPP.DepartmentDataSet();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new StudentAPP.DepartmentDataSetTableAdapters.StudentTableTableAdapter();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dept Info";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(93, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(93, 35);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.studentNameTextBox);
            this.groupBox2.Controls.Add(this.regTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(342, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(92, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(92, 62);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 4;
            // 
            // regTextBox
            // 
            this.regTextBox.Location = new System.Drawing.Point(92, 27);
            this.regTextBox.Name = "regTextBox";
            this.regTextBox.Size = new System.Drawing.Size(100, 20);
            this.regTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reg";
            // 
            // deptSaveButton
            // 
            this.deptSaveButton.Location = new System.Drawing.Point(48, 211);
            this.deptSaveButton.Name = "deptSaveButton";
            this.deptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.deptSaveButton.TabIndex = 2;
            this.deptSaveButton.Text = "Save";
            this.deptSaveButton.UseVisualStyleBackColor = true;
            this.deptSaveButton.Click += new System.EventHandler(this.deptSaveButton_Click);
            // 
            // studentSaveButton
            // 
            this.studentSaveButton.Location = new System.Drawing.Point(394, 211);
            this.studentSaveButton.Name = "studentSaveButton";
            this.studentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.studentSaveButton.TabIndex = 3;
            this.studentSaveButton.Text = "Save";
            this.studentSaveButton.UseVisualStyleBackColor = true;
            this.studentSaveButton.Click += new System.EventHandler(this.studentSaveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(233, 254);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(191, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Details";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 258);
            this.dataGridView1.TabIndex = 5;
            // 
            // departmentDataSet
            // 
            this.departmentDataSet.DataSetName = "DepartmentDataSet";
            this.departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.departmentDataSet;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.studentSaveButton);
            this.Controls.Add(this.deptSaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox regTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deptSaveButton;
        private System.Windows.Forms.Button studentSaveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DepartmentDataSet departmentDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private DepartmentDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

