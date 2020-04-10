namespace DemoWeather
{
    partial class ChinaMainForm
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
            this.lblNjd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWSE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWD = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.countryControl1 = new DemoWeather.CountryControl();
            this.gbWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWeather
            // 
            this.gbWeather.Controls.Add(this.label6);
            this.gbWeather.Controls.Add(this.lblNjd);
            this.gbWeather.Controls.Add(this.label5);
            this.gbWeather.Controls.Add(this.lblWSE);
            this.gbWeather.Controls.Add(this.label4);
            this.gbWeather.Controls.Add(this.lblSD);
            this.gbWeather.Controls.Add(this.label9);
            this.gbWeather.Controls.Add(this.lblWS);
            this.gbWeather.Controls.Add(this.label8);
            this.gbWeather.Controls.Add(this.label7);
            this.gbWeather.Controls.Add(this.lblWD);
            this.gbWeather.Controls.Add(this.lblTemp);
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
            this.label6.Location = new System.Drawing.Point(314, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "实况:";
            // 
            // lblNjd
            // 
            this.lblNjd.AutoSize = true;
            this.lblNjd.Location = new System.Drawing.Point(350, 100);
            this.lblNjd.Name = "lblNjd";
            this.lblNjd.Size = new System.Drawing.Size(29, 12);
            this.lblNjd.TabIndex = 3;
            this.lblNjd.Text = "实况";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "风力:";
            // 
            // lblWSE
            // 
            this.lblWSE.AutoSize = true;
            this.lblWSE.Location = new System.Drawing.Point(350, 81);
            this.lblWSE.Name = "lblWSE";
            this.lblWSE.Size = new System.Drawing.Size(29, 12);
            this.lblWSE.TabIndex = 3;
            this.lblWSE.Text = "风力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "湿度:";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(350, 62);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(29, 12);
            this.lblSD.TabIndex = 3;
            this.lblSD.Text = "湿度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "风速:";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.Location = new System.Drawing.Point(273, 100);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(29, 12);
            this.lblWS.TabIndex = 3;
            this.lblWS.Text = "风速";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "风向:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "温度:";
            // 
            // lblWD
            // 
            this.lblWD.AutoSize = true;
            this.lblWD.Location = new System.Drawing.Point(273, 81);
            this.lblWD.Name = "lblWD";
            this.lblWD.Size = new System.Drawing.Size(29, 12);
            this.lblWD.TabIndex = 3;
            this.lblWD.Text = "风向";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(273, 62);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(29, 12);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "温度";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(200, 115);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(29, 12);
            this.lblTemp2.TabIndex = 2;
            this.lblTemp2.Text = "夜晚";
            this.lblTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(148, 114);
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
            this.pBox2.Location = new System.Drawing.Point(188, 62);
            this.pBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(50, 50);
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
            this.pBox1.Size = new System.Drawing.Size(50, 50);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.countryControl1);
            this.Controls.Add(this.gbWeather);
            this.Name = "MainForm";
            this.Text = "DemoWeather--中国天气网";
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
        private System.Windows.Forms.Label lblNjd;
        private System.Windows.Forms.Label lblWSE;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblWD;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CountryControl countryControl1;
    }
}

