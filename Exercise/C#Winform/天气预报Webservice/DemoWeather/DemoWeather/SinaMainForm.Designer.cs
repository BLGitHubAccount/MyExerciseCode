namespace DemoWeather
{
    partial class SinaMainForm
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
            this.gbWeather = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZwx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWSE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWD = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.countryControl1 = new DemoWeather.CountryControl();
            this.lblChy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPollution = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWeather
            // 
            this.gbWeather.Controls.Add(this.label9);
            this.gbWeather.Controls.Add(this.label4);
            this.gbWeather.Controls.Add(this.label3);
            this.gbWeather.Controls.Add(this.lblGm);
            this.gbWeather.Controls.Add(this.lblYd);
            this.gbWeather.Controls.Add(this.lblPollution);
            this.gbWeather.Controls.Add(this.label2);
            this.gbWeather.Controls.Add(this.lblChy);
            this.gbWeather.Controls.Add(this.label6);
            this.gbWeather.Controls.Add(this.lblZwx);
            this.gbWeather.Controls.Add(this.label5);
            this.gbWeather.Controls.Add(this.lblWSE);
            this.gbWeather.Controls.Add(this.label8);
            this.gbWeather.Controls.Add(this.lblWD);
            this.gbWeather.Controls.Add(this.lblTemp2);
            this.gbWeather.Controls.Add(this.lblTemp1);
            this.gbWeather.Controls.Add(this.lblCity);
            this.gbWeather.Controls.Add(this.pBox2);
            this.gbWeather.Controls.Add(this.pBox1);
            this.gbWeather.Location = new System.Drawing.Point(12, 98);
            this.gbWeather.Name = "gbWeather";
            this.gbWeather.Size = new System.Drawing.Size(640, 278);
            this.gbWeather.TabIndex = 3;
            this.gbWeather.TabStop = false;
            this.gbWeather.Text = "天气信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "紫外线:";
            // 
            // lblZwx
            // 
            this.lblZwx.AutoSize = true;
            this.lblZwx.Location = new System.Drawing.Point(363, 81);
            this.lblZwx.Name = "lblZwx";
            this.lblZwx.Size = new System.Drawing.Size(41, 12);
            this.lblZwx.TabIndex = 3;
            this.lblZwx.Text = "紫外线";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "风力:";
            // 
            // lblWSE
            // 
            this.lblWSE.AutoSize = true;
            this.lblWSE.Location = new System.Drawing.Point(363, 61);
            this.lblWSE.Name = "lblWSE";
            this.lblWSE.Size = new System.Drawing.Size(29, 12);
            this.lblWSE.TabIndex = 3;
            this.lblWSE.Text = "风力";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "风向:";
            // 
            // lblWD
            // 
            this.lblWD.AutoSize = true;
            this.lblWD.Location = new System.Drawing.Point(363, 41);
            this.lblWD.Name = "lblWD";
            this.lblWD.Size = new System.Drawing.Size(29, 12);
            this.lblWD.TabIndex = 3;
            this.lblWD.Text = "风向";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(243, 146);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(29, 12);
            this.lblTemp2.TabIndex = 2;
            this.lblTemp2.Text = "夜晚";
            this.lblTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(164, 145);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(29, 12);
            this.lblTemp1.TabIndex = 2;
            this.lblTemp1.Text = "白天";
            this.lblTemp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(135, 41);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 12);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "城市";
            // 
            // pBox2
            // 
            this.pBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBox2.Location = new System.Drawing.Point(218, 62);
            this.pBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(80, 80);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 0;
            this.pBox2.TabStop = false;
            // 
            // pBox1
            // 
            this.pBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBox1.Location = new System.Drawing.Point(136, 62);
            this.pBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(80, 80);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            // 
            // countryControl1
            // 
            this.countryControl1.Go = null;
            this.countryControl1.Location = new System.Drawing.Point(12, 12);
            this.countryControl1.Name = "countryControl1";
            this.countryControl1.Size = new System.Drawing.Size(640, 80);
            this.countryControl1.TabIndex = 4;
            this.countryControl1.Urban = null;
            // 
            // lblChy
            // 
            this.lblChy.AutoSize = true;
            this.lblChy.Location = new System.Drawing.Point(363, 101);
            this.lblChy.Name = "lblChy";
            this.lblChy.Size = new System.Drawing.Size(53, 12);
            this.lblChy.TabIndex = 3;
            this.lblChy.Text = "穿衣指数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "穿衣:";
            // 
            // lblPollution
            // 
            this.lblPollution.AutoSize = true;
            this.lblPollution.Location = new System.Drawing.Point(363, 121);
            this.lblPollution.Name = "lblPollution";
            this.lblPollution.Size = new System.Drawing.Size(53, 12);
            this.lblPollution.TabIndex = 3;
            this.lblPollution.Text = "污染指数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "污染:";
            // 
            // lblYd
            // 
            this.lblYd.AutoSize = true;
            this.lblYd.Location = new System.Drawing.Point(363, 141);
            this.lblYd.Name = "lblYd";
            this.lblYd.Size = new System.Drawing.Size(53, 12);
            this.lblYd.TabIndex = 3;
            this.lblYd.Text = "运动指数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "运动指数:";
            // 
            // lblGm
            // 
            this.lblGm.AutoSize = true;
            this.lblGm.Location = new System.Drawing.Point(363, 161);
            this.lblGm.Name = "lblGm";
            this.lblGm.Size = new System.Drawing.Size(53, 12);
            this.lblGm.TabIndex = 3;
            this.lblGm.Text = "感冒指数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "感冒指数:";
            // 
            // SinaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.countryControl1);
            this.Controls.Add(this.gbWeather);
            this.Name = "SinaMainForm";
            this.Text = "DemoWeather--新浪网";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbWeather.ResumeLayout(false);
            this.gbWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbWeather;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblZwx;
        private System.Windows.Forms.Label lblWSE;
        private System.Windows.Forms.Label lblWD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private CountryControl countryControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGm;
        private System.Windows.Forms.Label lblYd;
        private System.Windows.Forms.Label lblPollution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChy;
    }
}

