namespace DemoWeather
{
    partial class CountryControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combProvince = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.combUrban = new System.Windows.Forms.ComboBox();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.btnGo);
            this.gbBox.Controls.Add(this.label1);
            this.gbBox.Controls.Add(this.label3);
            this.gbBox.Controls.Add(this.combProvince);
            this.gbBox.Controls.Add(this.label2);
            this.gbBox.Controls.Add(this.combCity);
            this.gbBox.Controls.Add(this.combUrban);
            this.gbBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBox.Location = new System.Drawing.Point(0, 0);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(666, 80);
            this.gbBox.TabIndex = 3;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "gbBox";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(559, 30);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "省份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "城区/县：";
            // 
            // combProvince
            // 
            this.combProvince.FormattingEnabled = true;
            this.combProvince.Location = new System.Drawing.Point(55, 33);
            this.combProvince.Name = "combProvince";
            this.combProvince.Size = new System.Drawing.Size(121, 20);
            this.combProvince.TabIndex = 0;
            this.combProvince.SelectedIndexChanged += new System.EventHandler(this.combProvince_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "城市：";
            // 
            // combCity
            // 
            this.combCity.FormattingEnabled = true;
            this.combCity.Location = new System.Drawing.Point(233, 33);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(121, 20);
            this.combCity.TabIndex = 0;
            this.combCity.SelectedIndexChanged += new System.EventHandler(this.combCity_SelectedIndexChanged);
            // 
            // combUrban
            // 
            this.combUrban.FormattingEnabled = true;
            this.combUrban.Location = new System.Drawing.Point(429, 33);
            this.combUrban.Name = "combUrban";
            this.combUrban.Size = new System.Drawing.Size(121, 20);
            this.combUrban.TabIndex = 0;
            // 
            // CountryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBox);
            this.Name = "CountryControl";
            this.Size = new System.Drawing.Size(666, 80);
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combProvince;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.ComboBox combUrban;
    }
}
