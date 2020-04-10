namespace DataGridViewDatasource
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
            this.bdGridView = new System.Windows.Forms.DataGridView();
            this.NbddataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdGridView
            // 
            this.bdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdGridView.Location = new System.Drawing.Point(39, 60);
            this.bdGridView.Name = "bdGridView";
            this.bdGridView.RowTemplate.Height = 23;
            this.bdGridView.Size = new System.Drawing.Size(335, 214);
            this.bdGridView.TabIndex = 0;
            // 
            // NbddataGridView
            // 
            this.NbddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NbddataGridView.Location = new System.Drawing.Point(467, 60);
            this.NbddataGridView.Name = "NbddataGridView";
            this.NbddataGridView.RowTemplate.Height = 23;
            this.NbddataGridView.Size = new System.Drawing.Size(335, 214);
            this.NbddataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "绑定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "非绑定";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NbddataGridView);
            this.Controls.Add(this.bdGridView);
            this.Name = "Form1";
            this.Text = "DataGridView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bdGridView;
        private System.Windows.Forms.DataGridView NbddataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

