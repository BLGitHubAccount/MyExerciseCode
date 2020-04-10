namespace CsharpconnectSql
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.querybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student1DataSet = new CsharpconnectSql.Student1DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new CsharpconnectSql.Student1DataSetTableAdapters.StudentTableAdapter();
            this.student1DataSet1 = new CsharpconnectSql.Student1DataSet1();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new CsharpconnectSql.Student1DataSet1TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.Color.Yellow;
            this.richTextBox1.Location = new System.Drawing.Point(-5, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1016, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // namecomboBox
            // 
            this.namecomboBox.DataSource = this.studentBindingSource1;
            this.namecomboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.ItemHeight = 14;
            this.namecomboBox.Location = new System.Drawing.Point(94, 39);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(246, 22);
            this.namecomboBox.TabIndex = 1;
            // 
            // querybutton
            // 
            this.querybutton.Location = new System.Drawing.Point(94, 93);
            this.querybutton.Name = "querybutton";
            this.querybutton.Size = new System.Drawing.Size(54, 33);
            this.querybutton.TabIndex = 2;
            this.querybutton.Text = "查询";
            this.querybutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(710, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(235, 191);
            this.dataGridView1.TabIndex = 4;
            // 
            // student1DataSet
            // 
            this.student1DataSet.DataSetName = "Student1DataSet";
            this.student1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.student1DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // student1DataSet1
            // 
            this.student1DataSet1.DataSetName = "Student1DataSet1";
            this.student1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.student1DataSet1;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.querybutton);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.Button querybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student1DataSet student1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Student1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Student1DataSet1 student1DataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Student1DataSet1TableAdapters.StudentTableAdapter studentTableAdapter1;
    }
}

