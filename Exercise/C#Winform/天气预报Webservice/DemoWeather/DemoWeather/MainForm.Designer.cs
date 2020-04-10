namespace DemoWeather
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChinaWeather = new System.Windows.Forms.Button();
            this.btnSinaWeather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChinaWeather
            // 
            this.btnChinaWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChinaWeather.BackgroundImage")));
            this.btnChinaWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChinaWeather.Location = new System.Drawing.Point(23, 89);
            this.btnChinaWeather.Name = "btnChinaWeather";
            this.btnChinaWeather.Size = new System.Drawing.Size(131, 67);
            this.btnChinaWeather.TabIndex = 0;
            this.btnChinaWeather.UseVisualStyleBackColor = true;
            this.btnChinaWeather.Click += new System.EventHandler(this.btnChinaWeather_Click);
            // 
            // btnSinaWeather
            // 
            this.btnSinaWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSinaWeather.BackgroundImage")));
            this.btnSinaWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinaWeather.Location = new System.Drawing.Point(160, 89);
            this.btnSinaWeather.Name = "btnSinaWeather";
            this.btnSinaWeather.Size = new System.Drawing.Size(132, 67);
            this.btnSinaWeather.TabIndex = 0;
            this.btnSinaWeather.UseVisualStyleBackColor = true;
            this.btnSinaWeather.Click += new System.EventHandler(this.btnSinaWeather_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.btnSinaWeather);
            this.Controls.Add(this.btnChinaWeather);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChinaWeather;
        private System.Windows.Forms.Button btnSinaWeather;
    }
}