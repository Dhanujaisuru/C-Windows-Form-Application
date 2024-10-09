namespace Programming
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSetting_Details = new System.Windows.Forms.DataGridView();
            this.settingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesforSalarycycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarycyclebeginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarycycleendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofleavesforYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_ToysDataSet4 = new Programming.Grifindo_ToysDataSet4();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmp_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetting_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo_of_Leves = new System.Windows.Forms.TextBox();
            this.dtpSalary_Sart_Day = new System.Windows.Forms.DateTimePicker();
            this.dtpSalary_End_Date = new System.Windows.Forms.DateTimePicker();
            this.txtDscycle = new System.Windows.Forms.TextBox();
            this.settingTableAdapter = new Programming.Grifindo_ToysDataSet4TableAdapters.SettingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetting_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_ToysDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1213, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 31);
            this.label10.TabIndex = 53;
            this.label10.Text = "Setting Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(757, 555);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 65);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSetting_Details
            // 
            this.dgvSetting_Details.AutoGenerateColumns = false;
            this.dgvSetting_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSetting_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetting_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settingIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.datesforSalarycycleDataGridViewTextBoxColumn,
            this.salarycyclebeginDateDataGridViewTextBoxColumn,
            this.salarycycleendDateDataGridViewTextBoxColumn,
            this.noofleavesforYearDataGridViewTextBoxColumn});
            this.dgvSetting_Details.DataSource = this.settingBindingSource;
            this.dgvSetting_Details.Location = new System.Drawing.Point(936, 68);
            this.dgvSetting_Details.Name = "dgvSetting_Details";
            this.dgvSetting_Details.RowHeadersWidth = 51;
            this.dgvSetting_Details.RowTemplate.Height = 24;
            this.dgvSetting_Details.Size = new System.Drawing.Size(767, 611);
            this.dgvSetting_Details.TabIndex = 51;
            // 
            // settingIDDataGridViewTextBoxColumn
            // 
            this.settingIDDataGridViewTextBoxColumn.DataPropertyName = "Setting_ID";
            this.settingIDDataGridViewTextBoxColumn.HeaderText = "Setting_ID";
            this.settingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.settingIDDataGridViewTextBoxColumn.Name = "settingIDDataGridViewTextBoxColumn";
            this.settingIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 84;
            // 
            // datesforSalarycycleDataGridViewTextBoxColumn
            // 
            this.datesforSalarycycleDataGridViewTextBoxColumn.DataPropertyName = "Dates_for_Salary_cycle";
            this.datesforSalarycycleDataGridViewTextBoxColumn.HeaderText = "Dates_for_Salary_cycle";
            this.datesforSalarycycleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datesforSalarycycleDataGridViewTextBoxColumn.Name = "datesforSalarycycleDataGridViewTextBoxColumn";
            this.datesforSalarycycleDataGridViewTextBoxColumn.Width = 179;
            // 
            // salarycyclebeginDateDataGridViewTextBoxColumn
            // 
            this.salarycyclebeginDateDataGridViewTextBoxColumn.DataPropertyName = "Salary_cycle_begin_Date";
            this.salarycyclebeginDateDataGridViewTextBoxColumn.HeaderText = "Salary_cycle_begin_Date";
            this.salarycyclebeginDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarycyclebeginDateDataGridViewTextBoxColumn.Name = "salarycyclebeginDateDataGridViewTextBoxColumn";
            this.salarycyclebeginDateDataGridViewTextBoxColumn.Width = 191;
            // 
            // salarycycleendDateDataGridViewTextBoxColumn
            // 
            this.salarycycleendDateDataGridViewTextBoxColumn.DataPropertyName = "Salary_cycle_end_Date";
            this.salarycycleendDateDataGridViewTextBoxColumn.HeaderText = "Salary_cycle_end_Date";
            this.salarycycleendDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarycycleendDateDataGridViewTextBoxColumn.Name = "salarycycleendDateDataGridViewTextBoxColumn";
            this.salarycycleendDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // noofleavesforYearDataGridViewTextBoxColumn
            // 
            this.noofleavesforYearDataGridViewTextBoxColumn.DataPropertyName = "No_of_leaves_for_Year";
            this.noofleavesforYearDataGridViewTextBoxColumn.HeaderText = "No_of_leaves_for_Year";
            this.noofleavesforYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofleavesforYearDataGridViewTextBoxColumn.Name = "noofleavesforYearDataGridViewTextBoxColumn";
            this.noofleavesforYearDataGridViewTextBoxColumn.Width = 178;
            // 
            // settingBindingSource
            // 
            this.settingBindingSource.DataMember = "Setting";
            this.settingBindingSource.DataSource = this.grifindo_ToysDataSet4;
            // 
            // grifindo_ToysDataSet4
            // 
            this.grifindo_ToysDataSet4.DataSetName = "Grifindo_ToysDataSet4";
            this.grifindo_ToysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Gotham Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 699);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 56);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1537, 686);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 65);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1235, 686);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 65);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(936, 686);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 65);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 46;
            this.label1.Text = "Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(490, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 62);
            this.label7.TabIndex = 61;
            this.label7.Text = "No of  Leves \r\nfor Yesr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(38, 474);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 62);
            this.label6.TabIndex = 60;
            this.label6.Text = "Salary Cycle \r\nEnd Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(38, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 62);
            this.label5.TabIndex = 59;
            this.label5.Text = "Salary Cycle \r\nBegin Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(38, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 62);
            this.label4.TabIndex = 58;
            this.label4.Text = "Date For \r\nSalary Cycle";
            // 
            // txtEmp_ID
            // 
            this.txtEmp_ID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_ID.Location = new System.Drawing.Point(222, 180);
            this.txtEmp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmp_ID.Multiline = true;
            this.txtEmp_ID.Name = "txtEmp_ID";
            this.txtEmp_ID.Size = new System.Drawing.Size(181, 29);
            this.txtEmp_ID.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 57;
            this.label3.Text = "Emp ID";
            // 
            // txtSetting_ID
            // 
            this.txtSetting_ID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetting_ID.Location = new System.Drawing.Point(222, 86);
            this.txtSetting_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetting_ID.Multiline = true;
            this.txtSetting_ID.Name = "txtSetting_ID";
            this.txtSetting_ID.Size = new System.Drawing.Size(181, 29);
            this.txtSetting_ID.TabIndex = 54;
            this.txtSetting_ID.TextChanged += new System.EventHandler(this.txtSetting_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "Setting ID";
            // 
            // txtNo_of_Leves
            // 
            this.txtNo_of_Leves.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo_of_Leves.Location = new System.Drawing.Point(691, 86);
            this.txtNo_of_Leves.Margin = new System.Windows.Forms.Padding(4);
            this.txtNo_of_Leves.Multiline = true;
            this.txtNo_of_Leves.Name = "txtNo_of_Leves";
            this.txtNo_of_Leves.Size = new System.Drawing.Size(181, 29);
            this.txtNo_of_Leves.TabIndex = 62;
            // 
            // dtpSalary_Sart_Day
            // 
            this.dtpSalary_Sart_Day.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalary_Sart_Day.Location = new System.Drawing.Point(222, 375);
            this.dtpSalary_Sart_Day.Name = "dtpSalary_Sart_Day";
            this.dtpSalary_Sart_Day.Size = new System.Drawing.Size(352, 31);
            this.dtpSalary_Sart_Day.TabIndex = 63;
            // 
            // dtpSalary_End_Date
            // 
            this.dtpSalary_End_Date.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalary_End_Date.Location = new System.Drawing.Point(222, 481);
            this.dtpSalary_End_Date.Name = "dtpSalary_End_Date";
            this.dtpSalary_End_Date.Size = new System.Drawing.Size(352, 31);
            this.dtpSalary_End_Date.TabIndex = 64;
            // 
            // txtDscycle
            // 
            this.txtDscycle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscycle.Location = new System.Drawing.Point(222, 278);
            this.txtDscycle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDscycle.Multiline = true;
            this.txtDscycle.Name = "txtDscycle";
            this.txtDscycle.Size = new System.Drawing.Size(181, 29);
            this.txtDscycle.TabIndex = 65;
            // 
            // settingTableAdapter
            // 
            this.settingTableAdapter.ClearBeforeFill = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1720, 768);
            this.Controls.Add(this.txtDscycle);
            this.Controls.Add(this.dtpSalary_End_Date);
            this.Controls.Add(this.dtpSalary_Sart_Day);
            this.Controls.Add(this.txtNo_of_Leves);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmp_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSetting_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSetting_Details);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetting_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_ToysDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSetting_Details;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmp_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetting_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNo_of_Leves;
        private System.Windows.Forms.DateTimePicker dtpSalary_Sart_Day;
        private System.Windows.Forms.DateTimePicker dtpSalary_End_Date;
        private System.Windows.Forms.TextBox txtDscycle;
        private Grifindo_ToysDataSet4 grifindo_ToysDataSet4;
        private System.Windows.Forms.BindingSource settingBindingSource;
        private Grifindo_ToysDataSet4TableAdapters.SettingTableAdapter settingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesforSalarycycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycyclebeginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycycleendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofleavesforYearDataGridViewTextBoxColumn;
    }
}