namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baoziDatabaseDataSet = new DataGridView.baoziDatabaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new DataGridView.baoziDatabaseDataSetTableAdapters.studentTableAdapter();
            this.student1DataSet = new DataGridView.Student1DataSet();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new DataGridView.Student1DataSetTableAdapters.StudentTableAdapter();
            this.stuNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xueHaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiBuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoziDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuNoDataGridViewTextBoxColumn,
            this.stuNameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.gradeNoDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.xueHaoDataGridViewTextBoxColumn,
            this.couNoDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.classnoDataGridViewTextBoxColumn,
            this.xiBuIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(435, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // baoziDatabaseDataSet
            // 
            this.baoziDatabaseDataSet.DataSetName = "baoziDatabaseDataSet";
            this.baoziDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.baoziDatabaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // student1DataSet
            // 
            this.student1DataSet.DataSetName = "Student1DataSet";
            this.student1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.student1DataSet;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // stuNoDataGridViewTextBoxColumn
            // 
            this.stuNoDataGridViewTextBoxColumn.DataPropertyName = "StuNo";
            this.stuNoDataGridViewTextBoxColumn.HeaderText = "StuNo";
            this.stuNoDataGridViewTextBoxColumn.Name = "stuNoDataGridViewTextBoxColumn";
            this.stuNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.DataPropertyName = "StuName";
            this.stuNameDataGridViewTextBoxColumn.HeaderText = "StuName";
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // gradeNoDataGridViewTextBoxColumn
            // 
            this.gradeNoDataGridViewTextBoxColumn.DataPropertyName = "GradeNo";
            this.gradeNoDataGridViewTextBoxColumn.HeaderText = "GradeNo";
            this.gradeNoDataGridViewTextBoxColumn.Name = "gradeNoDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // xueHaoDataGridViewTextBoxColumn
            // 
            this.xueHaoDataGridViewTextBoxColumn.DataPropertyName = "XueHao";
            this.xueHaoDataGridViewTextBoxColumn.HeaderText = "XueHao";
            this.xueHaoDataGridViewTextBoxColumn.Name = "xueHaoDataGridViewTextBoxColumn";
            // 
            // couNoDataGridViewTextBoxColumn
            // 
            this.couNoDataGridViewTextBoxColumn.DataPropertyName = "CouNo";
            this.couNoDataGridViewTextBoxColumn.HeaderText = "CouNo";
            this.couNoDataGridViewTextBoxColumn.Name = "couNoDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // classnoDataGridViewTextBoxColumn
            // 
            this.classnoDataGridViewTextBoxColumn.DataPropertyName = "classno";
            this.classnoDataGridViewTextBoxColumn.HeaderText = "classno";
            this.classnoDataGridViewTextBoxColumn.Name = "classnoDataGridViewTextBoxColumn";
            // 
            // xiBuIDDataGridViewTextBoxColumn
            // 
            this.xiBuIDDataGridViewTextBoxColumn.DataPropertyName = "XiBuID";
            this.xiBuIDDataGridViewTextBoxColumn.HeaderText = "XiBuID";
            this.xiBuIDDataGridViewTextBoxColumn.Name = "xiBuIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 425);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoziDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private baoziDatabaseDataSet baoziDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private baoziDatabaseDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private Student1DataSet student1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Student1DataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xueHaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiBuIDDataGridViewTextBoxColumn;
    }
}

