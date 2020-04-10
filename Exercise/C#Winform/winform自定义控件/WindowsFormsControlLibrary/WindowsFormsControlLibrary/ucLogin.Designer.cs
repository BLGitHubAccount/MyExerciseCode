namespace WindowsFormsControlLibrary
{
    partial class ucLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labUserName = new System.Windows.Forms.Label();
            this.labPw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(63, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(126, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(63, 74);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(126, 21);
            this.txtPw.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(138, 117);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(51, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(3, 28);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(41, 12);
            this.labUserName.TabIndex = 4;
            this.labUserName.Text = "用户名";
            // 
            // labPw
            // 
            this.labPw.AutoSize = true;
            this.labPw.Location = new System.Drawing.Point(3, 77);
            this.labPw.Name = "labPw";
            this.labPw.Size = new System.Drawing.Size(29, 12);
            this.labPw.TabIndex = 5;
            this.labPw.Text = "密码";
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labPw);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUserName);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(238, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtPw;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Label labUserName;
        public System.Windows.Forms.Label labPw;
    }
}
