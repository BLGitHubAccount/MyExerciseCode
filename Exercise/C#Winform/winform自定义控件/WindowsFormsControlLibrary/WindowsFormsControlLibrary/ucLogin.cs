using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class ucLogin: UserControl
    {
        /// <summary>
        /// 登录按钮对象
        /// </summary>
        private static readonly object _LoginButton = new object();

        public ucLogin()
        {
            InitializeComponent();
        }

        #region Property
        private string _userNameText;
        [Description("用户名")]
        public string UserNameText
        {
            get { return this.txtUserName.Text; }
            set
            {
                _userNameText = value;
                this.txtUserName.Text = value;
            }
        }

        private string _pwText;
        [Description("密码")]
        public string PwText
        {
            get { return this.txtPw.Text; }
            set
            {
                _pwText = value;
                this.txtPw.Text = value;
            }
        }
        #endregion
        #region Event
        public delegate void LoginButtonClickEventHander(object sender, EventArgs e);
        [Category("Event")]
        [Description("登录按钮点击事件")]
        public event LoginButtonClickEventHander LoginButtonClick
        {
             add { base.Events.AddHandler(_LoginButton, value); }
            remove { base.Events.RemoveHandler(_LoginButton, value); }
            
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginButtonClickEventHander hander = base.Events[_LoginButton] as LoginButtonClickEventHander;
            if (hander != null)
            {
                hander.Invoke(btnLogin,e);
            }
        }
    }
}
