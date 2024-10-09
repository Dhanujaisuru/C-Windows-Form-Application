namespace Programming
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmp_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbsent_Days = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeves = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPer_Day_Salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGov_Tax_Rate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSalary_Details = new System.Windows.Forms.DataGridView();
            this.salaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDaySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govTaxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_ToysDataSet3 = new Programming.Grifindo_ToysDataSet3();
            this.btnBack = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.salaryTableAdapter = new Programming.Grifindo_ToysDataSet3TableAdapters.SalaryTableAdapter();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtGross_Pay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_ToysDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSalary_ID
            // 
            this.txtSalary_ID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary_ID.Location = new System.Drawing.Point(226, 89);
            this.txtSalary_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary_ID.Multiline = true;
            this.txtSalary_ID.Name = "txtSalary_ID";
            this.txtSalary_ID.Size = new System.Drawing.Size(181, 29);
            this.txtSalary_ID.TabIndex = 1;
            this.txtSalary_ID.TextChanged += new System.EventHandler(this.txtSalary_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Salary ID";
            // 
            // txtEmp_ID
            // 
            this.txtEmp_ID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_ID.Location = new System.Drawing.Point(226, 183);
            this.txtEmp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmp_ID.Multiline = true;
            this.txtEmp_ID.Name = "txtEmp_ID";
            this.txtEmp_ID.Size = new System.Drawing.Size(181, 29);
            this.txtEmp_ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(42, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Emp ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(42, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Salary ";
            // 
            // txtAbsent_Days
            // 
            this.txtAbsent_Days.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbsent_Days.Location = new System.Drawing.Point(226, 375);
            this.txtAbsent_Days.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbsent_Days.Multiline = true;
            this.txtAbsent_Days.Name = "txtAbsent_Days";
            this.txtAbsent_Days.Size = new System.Drawing.Size(181, 29);
            this.txtAbsent_Days.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(42, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "Absent Days";
            // 
            // txtLeves
            // 
            this.txtLeves.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeves.Location = new System.Drawing.Point(715, 89);
            this.txtLeves.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeves.Multiline = true;
            this.txtLeves.Name = "txtLeves";
            this.txtLeves.Size = new System.Drawing.Size(181, 29);
            this.txtLeves.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(494, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Leves";
            // 
            // txtPer_Day_Salary
            // 
            this.txtPer_Day_Salary.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPer_Day_Salary.Location = new System.Drawing.Point(715, 183);
            this.txtPer_Day_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.txtPer_Day_Salary.Multiline = true;
            this.txtPer_Day_Salary.Name = "txtPer_Day_Salary";
            this.txtPer_Day_Salary.Size = new System.Drawing.Size(181, 29);
            this.txtPer_Day_Salary.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(494, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "Per Day Salary";
            // 
            // txtGov_Tax_Rate
            // 
            this.txtGov_Tax_Rate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGov_Tax_Rate.Location = new System.Drawing.Point(715, 283);
            this.txtGov_Tax_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.txtGov_Tax_Rate.Multiline = true;
            this.txtGov_Tax_Rate.Name = "txtGov_Tax_Rate";
            this.txtGov_Tax_Rate.Size = new System.Drawing.Size(181, 29);
            this.txtGov_Tax_Rate.TabIndex = 7;
            this.txtGov_Tax_Rate.TextChanged += new System.EventHandler(this.txtGov_Tax_Rate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(494, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 62);
            this.label8.TabIndex = 33;
            this.label8.Text = "Goverment \r\nTax Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(494, 371);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 31);
            this.label9.TabIndex = 35;
            this.label9.Text = "Gross Pay";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1541, 678);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 65);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1239, 678);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 65);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(940, 678);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 65);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(761, 450);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 65);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSalary_Details
            // 
            this.dgvSalary_Details.AutoGenerateColumns = false;
            this.dgvSalary_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalary_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.absentDaysDataGridViewTextBoxColumn,
            this.levesDataGridViewTextBoxColumn,
            this.perDaySalaryDataGridViewTextBoxColumn,
            this.govTaxRateDataGridViewTextBoxColumn,
            this.grossPayDataGridViewTextBoxColumn});
            this.dgvSalary_Details.DataSource = this.salaryBindingSource;
            this.dgvSalary_Details.Location = new System.Drawing.Point(940, 60);
            this.dgvSalary_Details.Name = "dgvSalary_Details";
            this.dgvSalary_Details.RowHeadersWidth = 51;
            this.dgvSalary_Details.RowTemplate.Height = 24;
            this.dgvSalary_Details.Size = new System.Drawing.Size(767, 611);
            this.dgvSalary_Details.TabIndex = 42;
            // 
            // salaryIDDataGridViewTextBoxColumn
            // 
            this.salaryIDDataGridViewTextBoxColumn.DataPropertyName = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.HeaderText = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryIDDataGridViewTextBoxColumn.Name = "salaryIDDataGridViewTextBoxColumn";
            this.salaryIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 84;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 75;
            // 
            // absentDaysDataGridViewTextBoxColumn
            // 
            this.absentDaysDataGridViewTextBoxColumn.DataPropertyName = "Absent_Days";
            this.absentDaysDataGridViewTextBoxColumn.HeaderText = "Absent_Days";
            this.absentDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.absentDaysDataGridViewTextBoxColumn.Name = "absentDaysDataGridViewTextBoxColumn";
            this.absentDaysDataGridViewTextBoxColumn.Width = 117;
            // 
            // levesDataGridViewTextBoxColumn
            // 
            this.levesDataGridViewTextBoxColumn.DataPropertyName = "Leves";
            this.levesDataGridViewTextBoxColumn.HeaderText = "Leves";
            this.levesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levesDataGridViewTextBoxColumn.Name = "levesDataGridViewTextBoxColumn";
            this.levesDataGridViewTextBoxColumn.Width = 73;
            // 
            // perDaySalaryDataGridViewTextBoxColumn
            // 
            this.perDaySalaryDataGridViewTextBoxColumn.DataPropertyName = "Per_Day_Salary";
            this.perDaySalaryDataGridViewTextBoxColumn.HeaderText = "Per_Day_Salary";
            this.perDaySalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perDaySalaryDataGridViewTextBoxColumn.Name = "perDaySalaryDataGridViewTextBoxColumn";
            this.perDaySalaryDataGridViewTextBoxColumn.Width = 135;
            // 
            // govTaxRateDataGridViewTextBoxColumn
            // 
            this.govTaxRateDataGridViewTextBoxColumn.DataPropertyName = "Gov_Tax_Rate";
            this.govTaxRateDataGridViewTextBoxColumn.HeaderText = "Gov_Tax_Rate";
            this.govTaxRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.govTaxRateDataGridViewTextBoxColumn.Name = "govTaxRateDataGridViewTextBoxColumn";
            this.govTaxRateDataGridViewTextBoxColumn.Width = 127;
            // 
            // grossPayDataGridViewTextBoxColumn
            // 
            this.grossPayDataGridViewTextBoxColumn.DataPropertyName = "Gross_Pay";
            this.grossPayDataGridViewTextBoxColumn.HeaderText = "Gross_Pay";
            this.grossPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grossPayDataGridViewTextBoxColumn.Name = "grossPayDataGridViewTextBoxColumn";
            this.grossPayDataGridViewTextBoxColumn.Width = 103;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.grifindo_ToysDataSet3;
            // 
            // grifindo_ToysDataSet3
            // 
            this.grifindo_ToysDataSet3.DataSetName = "Grifindo_ToysDataSet3";
            this.grifindo_ToysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Gotham Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 687);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 56);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1217, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 31);
            this.label10.TabIndex = 44;
            this.label10.Text = "Salary Details";
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(226, 285);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(181, 29);
            this.txtSalary.TabIndex = 3;
            // 
            // txtGross_Pay
            // 
            this.txtGross_Pay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross_Pay.Location = new System.Drawing.Point(715, 375);
            this.txtGross_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.txtGross_Pay.Multiline = true;
            this.txtGross_Pay.Name = "txtGross_Pay";
            this.txtGross_Pay.ReadOnly = true;
            this.txtGross_Pay.Size = new System.Drawing.Size(181, 29);
            this.txtGross_Pay.TabIndex = 8;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1720, 768);
            this.Controls.Add(this.txtGross_Pay);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSalary_Details);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGov_Tax_Rate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPer_Day_Salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLeves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAbsent_Days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmp_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_ToysDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmp_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbsent_Days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPer_Day_Salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGov_Tax_Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSalary_Details;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label10;
        private Grifindo_ToysDataSet3 grifindo_ToysDataSet3;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private Grifindo_ToysDataSet3TableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absentDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDaySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn govTaxRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtGross_Pay;
    }
}