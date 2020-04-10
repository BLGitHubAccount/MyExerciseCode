namespace test3_richTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redbtn = new System.Windows.Forms.Button();
            this.bulebtn = new System.Windows.Forms.Button();
            this.ks18btn = new System.Windows.Forms.Button();
            this.itembtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 361);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "操作前请选中文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(491, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作";
            // 
            // redbtn
            // 
            this.redbtn.Location = new System.Drawing.Point(473, 63);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(75, 23);
            this.redbtn.TabIndex = 3;
            this.redbtn.Text = "红色";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // bulebtn
            // 
            this.bulebtn.Location = new System.Drawing.Point(473, 125);
            this.bulebtn.Name = "bulebtn";
            this.bulebtn.Size = new System.Drawing.Size(75, 23);
            this.bulebtn.TabIndex = 4;
            this.bulebtn.Text = "蓝色";
            this.bulebtn.UseVisualStyleBackColor = true;
            this.bulebtn.Click += new System.EventHandler(this.bulebtn_Click);
            // 
            // ks18btn
            // 
            this.ks18btn.Location = new System.Drawing.Point(473, 187);
            this.ks18btn.Name = "ks18btn";
            this.ks18btn.Size = new System.Drawing.Size(75, 23);
            this.ks18btn.TabIndex = 5;
            this.ks18btn.Text = "楷书18";
            this.ks18btn.UseVisualStyleBackColor = true;
            this.ks18btn.Click += new System.EventHandler(this.ks18btn_Click);
            // 
            // itembtn
            // 
            this.itembtn.Location = new System.Drawing.Point(473, 249);
            this.itembtn.Name = "itembtn";
            this.itembtn.Size = new System.Drawing.Size(75, 23);
            this.itembtn.TabIndex = 6;
            this.itembtn.Text = "项目符号";
            this.itembtn.UseVisualStyleBackColor = true;
            this.itembtn.Click += new System.EventHandler(this.itembtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(473, 311);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 7;
            this.resetbtn.Text = "复原";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 415);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.itembtn);
            this.Controls.Add(this.ks18btn);
            this.Controls.Add(this.bulebtn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "richTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button bulebtn;
        private System.Windows.Forms.Button ks18btn;
        private System.Windows.Forms.Button itembtn;
        private System.Windows.Forms.Button resetbtn;
    }
}

