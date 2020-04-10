using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsharpconnectSql
{
    public partial class Form1 : Form
    {
        //类初始化

        #region ////以下定义OrBit插件与浏览器进行交互的接口变量

        //基本接口变量
        //public string PlugInCommand;  //插件的命令ID
        //public string PlugInName; //插件的名字(能随语言ID改变)
        //public string LanguageId; //语言ID(0-英,1-简,2-繁...8)
        //public string ParameterString; //参数字串
        //public string RightString; //权限字串(1-Z)
        //public string OrBitUserId; //OrBit用户ID
        //public string OrBitUserName; //用户名
        //public string ApplicationName; //应用系统
        //public string ResourceId; //资源(电脑)ID
        //public string ResourceName; //资源名
        //public bool IsExitQuery; //在插件窗体退出是询问是否要退出，用于提醒数据状态已改变。
        //public string UserTicket; //经浏览器认证后的加密票，调用某些WCF服务时需要使用

        //单独调试数据库应用时需用到参数
        public string DatabaseServer; //数据库服务器
        public string DatabaseName;//数据库名
        public string DatabaseUser;//数据库用户
        public string DatabasePassword; //密码

        //各服务器的地址
        //public string WcfServerUrl; // WCF或Webservice服务的路径
        //public string DocumentServerURL; //文档服务器URL
        //public string PluginServerURL;//插件服务器URL
        //public string RptReportServerURL; //水晶报表服务器URL

        //回传给浏览器的元对象信息
        //public string MetaDataName = "No metadata"; //元对象名
        //public string MetaDataVersion = "0.00"; //元对象版本
        //public string UIMappingEngineVersion = "0.00"; //UIMapping版本号

        //事件日志类型枚举--1.普通事件，2警告，3错误，4严重错误 ,5表字段变更 ,6其它
        // public enum EventLogType { Normal = 1, Warning = 2, Error = 3, FatalError = 4, TableChanged = 5, Other = 6 };

        #endregion

        /// <summary>
        ///构造函数
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #region 自定义公共变量
        /// <summary>
        /// ftp下载地址
        /// </summary>
        private string FTPServer = "ftp://10.2.0.9/ftptlt";
        /// <summary>
        /// ftp登录用户名
        /// </summary>
        private string FTPUser = "mes";
        /// <summary>
        /// ftp登录密码
        /// </summary>
        private string FTPPassWord = "mesmes";
        /// <summary>
        /// 此产品的脚本文件路径
        /// </summary>
        private string FilePath = "ftp://10.2.0.9/PackTemplate/alert.wav";
        /// <summary>
        /// 成品料号
        /// </summary>
    //    private string ProductName = "";
        /// <summary>
        /// 规程Id
        /// </summary>
        private string SpecificationId = "SPE100000094";
        /// <summary>
        /// 成品描述
        /// </summary>
        private string ProductDescription = "";
        /// <summary>
        /// 订单Id
        /// </summary>
        private string SORootId = "";
        /// <summary>
        /// 装箱数量
        /// </summary>
        private int BoxQty = 0;
        /// <summary>
        /// 添加节点的委托
        /// </summary>
        /// <param name="PalletSN"></param>
        private delegate void Add_Node(TreeNode tn, TreeView tv);
        /// <summary>
        /// 存放打印机端口信息
        /// </summary>
        public Dictionary<string, string> printInfo = new Dictionary<string, string>();
        /// <summary>
        /// 设置某一控件状态的委托
        /// </summary>
        /// <param name="isEnable"></param>
        private delegate void Set_Enable(bool isEnable);
        #endregion
        /// <summary>
        /// 插件入口,由.NET自动生成
        /// </summary>
        //public UserControl1()
        //{
        //    InitializeComponent();　//插件控件布局(.NET的默认过程)
        //    initializeVariable(); //插件变量初始化
        //    SwitchUI();　　//切换语言
        //}



        /// <summary>
        /// 本私有函数对插件各接口变量进行初始化，赋予默认值
        /// 调试环境下这些值不变，通过浏览器执行时，
        /// 这些变量将会根据系统环境被重新赋值。
        /// </summary>
        private void initializeVariable()
        {
            #region 初始化UI
            //PlugInCommand = "MYPGN";
            //PlugInName = "我的插件";
            //LanguageId = "0";  //(0-英,1-简,2-繁...8)
            //ParameterString = "";
            //RightString = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //OrBitUserId = "DEVUSER";
            //OrBitUserName = "调试者";
            //ApplicationName = "DEBUG";
            //ResourceId = "RES100000017";
            //ResourceName = "YourPC";

            //这里需要根据实际的数据库环境进行改写
            DatabaseServer = ".";
            DatabaseName = "student1";
            DatabaseUser = "sa";
            DatabasePassword = "baolj";

            //WcfServerUrl = "http://10.2.0.10/WCFService";
            //DocumentServerURL = ""; //文档服务器URL
            //PluginServerURL = "http://10.2.0.10/OrBitPlugins/";//插件服务器URL
            //RptReportServerURL = "http://10.2.0.10/OrBitReports/"; //水晶报表服务器URL

            //UserTicket = "";
            //IsExitQuery = false;
            #endregion
        }



        /// <summary>
        /// 通用执行存储过程程序.
        /// </summary>
        /// <param name="SQLCmd">传入的SqlCommand对象</param>
        /// <param name="ReturnDataSet">执行存储过程后返回的数据集</param>
        /// <param name="ReturnValue">执行存储过程的返回值</param>
        /// <returns>将SQLCmd执行后的参数刷新并传回，主要返回存储过程中的out参数</returns>
        public SqlCommand RunStoredProcedure(SqlCommand SQLCmd, out DataSet ReturnDataSet, out int ReturnValue)
        {
            #region
            ReturnValue = 0;
            try
            {
                //if (this.Parent.Name.ToString() != "FormPlugIn")
               // {　//在插件调试环境下运行时，用ADO.NET直连 
                    string ConnectionString = "Data Source=" + DatabaseServer +
                            ";Initial Catalog=" + DatabaseName +
                            ";password=" + DatabasePassword +
                            ";Persist Security Info=True;User ID=" + DatabaseUser;
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        SQLCmd.Connection = conn;
                        SQLCmd.CommandType = CommandType.StoredProcedure;
                        SQLCmd.CommandTimeout = conn.ConnectionTimeout;
                        SQLCmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                        SQLCmd.Parameters["RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = SQLCmd;

                        DataSet ds = new DataSet("WCFSQLDataSet");
                        adapter.Fill(ds, "WCFSQLDataSet");

                        ReturnDataSet = ds;
                        conn.Close();
                        ReturnValue = (int)SQLCmd.Parameters["RETURN_VALUE"].Value;
                        //ReturnValue = int.Parse(SQLCmd.Parameters["RETURN_VALUE"].Value.ToString());
                        return SQLCmd;
                    }
             //   }
                //else
                //{  //在浏览器下运行时，直接调用浏览器的RunStoredProcedure,

                //    Type type = this.ParentForm.GetType();
                //    Object obj = this.ParentForm;

                //    SqlCommand cmd = new SqlCommand();
                //    DataSet rds = new DataSet();

                //    ReturnDataSet = null;

                //    Object[] myArgs = new object[] { SQLCmd, ReturnDataSet, ReturnValue };
                //    cmd = (SqlCommand)type.InvokeMember("RunStoredProcedure", BindingFlags.InvokeMethod | BindingFlags.Public |
                //                    BindingFlags.Instance, null, obj, myArgs);
                //    ReturnValue = (int)myArgs[2];
                //    ReturnDataSet = (DataSet)myArgs[1];
                //    return cmd;

                //}
            }
            catch (Exception er)
            {
                ReturnDataSet = null;
                MessageBox.Show(er.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            #endregion
        }

        /// <summary>
        /// 执行一个指定的SQL字串，并返回一个记录集
        /// 在浏览器下执行时，直接调用浏览器的WCF服务器来传送记录集
        /// </summary>
        /// <param name="SQLString">SQL字串</param>
        /// <returns>返回的记录集</returns>
        public DataSet GetDataSetWithSQLString(string SQLString)
        {
            #region
            try
            {
                //if (this.Parent.Name.ToString() != "FormPlugIn")
               // {　//在插件调试环境下运行时，用ADO.NET直连 
                    //string ConnectionString = "Data Source=" + DatabaseServer +
                    //                    ";Initial Catalog=" + DatabaseName +
                    //                    ";password=" + DatabasePassword +
                    //                    ";Persist Security Info=True;User ID=" + DatabaseUser;

                string ConnectionString = "server=.;user=sa;pwd=baolj;database=student1";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                    MessageBox.Show("数据库连接成功");
                    SqlCommand comm = new SqlCommand();
                        comm.Connection = conn;
                        comm.CommandText = SQLString;

                        comm.CommandType = CommandType.Text;
                        comm.CommandTimeout = conn.ConnectionTimeout;

                        DataSet ds = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = comm;
                        adapter.Fill(ds, "student");

                        conn.Close();
                        return ds;
                    }
               // }
                //else
                //{　//在浏览器下运行时，直接调用浏览器的GetDataSetWithSQLString,
                //    //通过WCF服务器返回记录集

                //    Type type = this.ParentForm.GetType();
                //    Object obj = this.ParentForm;
                //    DataSet ds = new DataSet("SQLDataSet");
                //    ds = (DataSet)type.InvokeMember("GetDataSetWithSQLString", BindingFlags.InvokeMethod | BindingFlags.Public |
                //                    BindingFlags.Instance, null, obj, new object[] { SQLString });
                //    return ds;
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            #endregion
        }

        //#region
        /// <summary>
        /// 插件加载事件，由.NET自动生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student1DataSet1.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter1.Fill(this.student1DataSet1.Student);
            // TODO: 这行代码将数据加载到表“student1DataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.student1DataSet.Student);
            #region
            // KillProcess("lppa");
            // this.Dock = DockStyle.Fill;
            //  refreshOrBitIVariable(); //显示接口变量
            //  setControlsRight(RightString); //设定界面上各控件的权限
            // getMolist();
            //  getUserNamelist();
            //printInfo.Add("PortName","COM1");
            //printInfo.Add("BaudRate","9600");
            //#region  赋值ftp服务器地址和用户名，密码
            //string sql = "EXEC	[dbo].[Txn_GetFTPInfo] " +
            //          "@I_PlugInCommand = N'" + PlugInCommand + "', " +
            //          "@I_OrBitUserId = N'" + OrBitUserId + "', " +
            //          "@I_ResourceId = N'" + ResourceId + "'";
            //DataSet ds = GetDataSetWithSQLString(sql);
            //this.Cursor = Cursors.Arrow;
            //if (ds == null || ds.Tables[0] == null || ds.Tables[0].Rows.Count <= 0)
            //{
            //    showMessage("FTP服务器地址或用户名或密码不存在，请检查！", true);
            //    playFailSound();
            //    return;
            //}
            //if (ds.Tables[0].Rows[0][0].ToString() == string.Empty || ds.Tables[0].Rows[0][1].ToString() == string.Empty || ds.Tables[0].Rows[0][2].ToString() == string.Empty)
            //{
            //    showMessage("FTP服务器地址或用户名或密码有一个或多个为空，请检查！", true);
            //    playFailSound();
            //    return;
            //}
            //FTPServer = ds.Tables[0].Rows[0][0].ToString();
            //FTPUser = ds.Tables[0].Rows[0][1].ToString();
            //FTPPassWord = ds.Tables[0].Rows[0][2].ToString();

            initializeVariable();
          //  getSqltablelist();
            #endregion

        }

        /// <summary>
        /// 播放OK声音
        /// </summary>
        public void playOKSound()
        {
            System.Media.SystemSounds.Asterisk.Play();
        }
        /// <summary>
        /// 播放Fail声音
        /// </summary>
        public void playFailSound()
        {
            System.Media.SystemSounds.Hand.Play();
        }


        /// <summary>
        /// 杀死进程
        /// </summary>
        /// <param name="processName"></param>
        public static void KillProcess(string processName)
        {
            #region
        //    System.Diagnostics.Process myproc = new System.Diagnostics.Process();
        //    //得到所有打开的进程
        //    try
        //    {
        //        foreach (Process thisproc in Process.GetProcessesByName(processName))
        //        {
        //            if (!thisproc.CloseMainWindow())
        //            {
        //                thisproc.Kill();
        //            }
        //        }
        //    }
        //    catch (Exception Exc)
        //    {
        //        throw new Exception("", Exc);
        //    }
           #endregion
        }

        /// <summary>
        /// 向信息框送入信息
        /// </summary>
        /// <param name="yourMessage"></param>
        /// <param name="isWaring"></param>
                public void showMessage(string yourMessage, bool isWaring)
                { //向信息框送入信息。
                    #region
        //            try
        //            {
        //                yourMessage = yourMessage.Replace("ServerMessage:", "");
        //                richTextBox1.Text = richTextBox1.Text + System.DateTime.Now.ToLongTimeString() + " - " + yourMessage + "\r\n";
        //                richTextBox1.Select(0, richTextBox1.Text.Length);
        //                richTextBox1.SelectionColor = Color.Green;
        //                if (richTextBox1.Text.Length > 5000)
        //                {
        //                    richTextBox1.Text = richTextBox1.Text.Substring(richTextBox1.Text.Length - 5000);
        //                }

        //                if (isWaring == true)
        //                {
        //                    richTextBox1.Select(richTextBox1.Text.Length - yourMessage.Length - 1, yourMessage.Length);
        //                    richTextBox1.SelectionColor = Color.Red;
        //                    richTextBox1.SelectionFont = new System.Drawing.Font("微软雅黑", 12F);
        //                }
        //                else
        //                {
        //                    richTextBox1.Select(richTextBox1.Text.Length - yourMessage.Length - 1, yourMessage.Length);
        //                    richTextBox1.SelectionColor = Color.Green;
        //                    richTextBox1.SelectionFont = new System.Drawing.Font("微软雅黑", 12F);
        //                }
        //                //让文本框获取焦点   
        //                //this.richTextBox1.Focus();
        //                //设置光标的位置到文本尾   
        //                this.richTextBox1.Select(this.richTextBox1.TextLength, 0);
        //                //滚动到控件光标处   
        //                this.richTextBox1.ScrollToCaret();

        //                //将内容存为文件。
        //                if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\showMessageStdTxn.txt") == true)
        //                {
        //                    System.IO.File.Delete(System.Windows.Forms.Application.StartupPath + @"\showMessageStdTxn.txt");
        //                }
        //                richTextBox1.SaveFile(System.Windows.Forms.Application.StartupPath + @"\showMessageStdTxn.txt", RichTextBoxStreamType.PlainText);
        //            }
        //            catch
        //            { }
                   #endregion
                }
        //#endregion

        #region 公共的方法，操作数据库的方法
        /// <summary>
        /// 执行返回受影响的行数的方法
        /// </summary>
        /// <returns></returns>
        private int ExecuteNonQuery(string sql)
        {
            #region 返回受影响的行数
            int result = 0;
            string ConnectionString = "Data Source=" + DatabaseServer +
                            ";Initial Catalog=" + DatabaseName +
                            ";password=" + DatabasePassword +
                            ";Persist Security Info=True;User ID=" + DatabaseUser;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlCommand cmd = null;
                try
                {
                    cmd = new SqlCommand(sql, con);
                    result = cmd.ExecuteNonQuery();
                }
                catch { result = 0; }
            }
            return result;
            #endregion
        }
        /// <summary>
        /// 执行返回第一行的第一列的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private object ExecuteScalar(string sql)
        {
            #region 返回第一行第一列
            object obj = null;
            string ConnectionString = "Data Source=" + DatabaseServer +
                            ";Initial Catalog=" + DatabaseName +
                            ";password=" + DatabasePassword +
                            ";Persist Security Info=True;User ID=" + DatabaseUser;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlCommand cmd = null;
                try
                {
                    cmd = new SqlCommand(sql, con);
                    obj = cmd.ExecuteScalar();
                }
                catch { obj = null; }
            }
            return obj;
            #endregion
        }
        /// <summary>
        /// 查询返回数据表的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable GetDataTableBySql(string sql)
        {
            #region 返回数据表
            DataTable dt = new DataTable();
            string ConnectionString = "Data Source=" + DatabaseServer +
                            ";Initial Catalog=" + DatabaseName +
                            ";password=" + DatabasePassword +
                            ";Persist Security Info=True;User ID=" + DatabaseUser;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlDataAdapter sda = null;
                try
                {
                    sda = new SqlDataAdapter(sql, con);
                    sda.Fill(dt);
                }
                catch { dt = null; }
            }
            return dt;
            #endregion
        }
        /// <summary>
        /// 只能输入数字的方法，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region
            TextBox textBox = sender as TextBox;
            char a = e.KeyChar;
            textBox.SelectedText = "";
            string text = textBox.Text.Trim();
            if (e.KeyChar == (char)8)
            {
                if (text.Trim().Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                }
                else
                {
                    text = "";
                }
            }
            else
            {
                switch (a)
                {
                    case '1':
                        text = text + "1";
                        break;
                    case '2':
                        text = text + "2";
                        break;
                    case '3':
                        text = text + "3";
                        break;
                    case '4':
                        text = text + "4";
                        break;
                    case '5':
                        text = text + "5";
                        break;
                    case '6':
                        text = text + "6";
                        break;
                    case '7':
                        text = text + "7";
                        break;
                    case '8':
                        text = text + "8";
                        break;
                    case '9':
                        text = text + "9";
                        break;
                    case '0':
                        text = text + "0";
                        break;
                }
            }
            textBox.Text = "";
            textBox.Text = text;
            textBox.SelectionStart = textBox.Text.Length;
            e.Handled = true;
            #endregion
        }


        #endregion



        #region   多线程事件及方法

        ///// <summary>
        ///// 添加节点的方法
        ///// </summary>
        ///// <param name="tn">当前节点</param>
        ///// <param name="tv">父级树控件</param>
        //private void AddNode(TreeNode tn, TreeView tv)
        //{
        //    #region
        //    if (tv.InvokeRequired)
        //    {
        //        Add_Node add = new Add_Node(AddNode);
        //        tv.Invoke(add, new object[] { tn, tv });
        //    }
        //    else
        //    {
        //        tv.Nodes.Add(tn);
        //        tv.SelectedNode = tn;
        //    }
        //    #endregion
        //}

        //#endregion



        /// <summary>
        /// 播放OK声音 YH编写的
        /// </summary>
        //   #region
        //private void PlayYesSound()
        //{
        //    try
        //    {
        //        System.Media.SystemSounds.Asterisk.Play();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}
        /// <summary>
        /// 播放不通过的声音  YH编写的
        /// </summary>
        //private void PlayNOSound()
        //{
        //    try
        //    {
        //        string path = System.Windows.Forms.Application.StartupPath + "\\" + FilePath.Substring(FilePath.LastIndexOf("/") + 1);
        //        if (File.Exists(path))
        //        {
        //            PlayFileSound.PlaySound(path);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}
        //#endregion
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form_Setting form = new Form_Setting();
        //    form.printInfo = printInfo;
        //    form.ShowDialog();
        //    printInfo = form.printInfo;
        //}
        #endregion
        // 获取数据集
        private void getSqltablelist()
        {
            #region 获取数据列表
            string sql =@"SELECT StuNo,StuName FROM dbo.Student ORDER BY StuNo";
            DataSet ds = GetDataSetWithSQLString(sql);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {


                //DataTable dt = new DataTable();
                //dt =ds.Tables[0];

             

               
              //   this.namecomboBox.DataSource = dt;
                // this.namecomboBox.DisplayMember = "姓名";
                //this.namecomboBox.DisplayMember = "student.stuno";
                //this.namecomboBox.ValueMember = "student.stuno";
                //this.namecomboBox.SelectedIndex = 0;



                //dataGridView1.Columns[1].Width = 150;
                //dataGridView1.Columns[2].Width = 150;
                //dataGridView1.Columns[3].Width = 150;
                //dataGridView1.Columns[4].Width = 150;

                //this.cboMO.DataSource = ds;
                //this.cboMO.DisplayLayout.Bands[0].Columns[0].Hidden = true;
                //this.cboMO.DisplayLayout.Bands[0].GroupHeadersVisible = false;
                //this.cboMO.DisplayLayout.Bands[0].ColHeadersVisible = true;
                //this.cboMO.DisplayLayout.Bands[0].Columns[1].Width = 200;
                //this.cboMO.DisplayLayout.Bands[0].Columns[2].Width = 200;
                //this.cboMO.DisplayLayout.Bands[0].Columns[1].Header.Caption = "工单";
                //this.cboMO.DisplayLayout.Bands[0].Columns[2].Header.Caption = "产品名";
                //this.cboMO.DisplayLayout.Bands[0].Columns[3].Header.Caption = "需求数量";

                //this.cboMO.DisplayMember = "MOName";
                //this.cboMO.ValueMember = "MOId";

            }
            #endregion
        }


        public void getsn(string procedure, string sn, string sn2, string by)
        {
            #region 执行存储过程
            //    string ParaName = "";
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = procedure;

            //ParaName = "@I_OrBitUserId";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NChar, 12));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //cmd.Parameters[ParaName].Value = OrBitUserId;

            //ParaName = "@I_ResourceId";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NChar, 12));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //cmd.Parameters[ParaName].Value = ResourceId;

            ////ParaName = "@MOId";
            ////cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NChar, 12));
            ////cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            ////cmd.Parameters[ParaName].Value = moId;

            //ParaName = "@I_PlugInCommand";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NChar, 5));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //cmd.Parameters[ParaName].Value = PlugInCommand;

            //ParaName = "@reprint";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NChar, 1));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //cmd.Parameters[ParaName].Value = by;
            //if (procedure == "Txn_UserPowerDomethod")
            //{
            //    ParaName = "@OldUserName";
            //    cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 50));
            //    cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //    cmd.Parameters[ParaName].Value = sn;

            //    ParaName = "@UserName";
            //    cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 50));
            //    cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //    cmd.Parameters[ParaName].Value = sn2;
            //}
            //else
            //{
            //    ParaName = "@OldProductName";
            //    cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 50));
            //    cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //    cmd.Parameters[ParaName].Value = sn;

            //    ParaName = "@NewProductName";
            //    cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 50));
            //    cmd.Parameters[ParaName].Direction = ParameterDirection.Input;
            //    cmd.Parameters[ParaName].Value = sn2;

            //}

            //ParaName = "@I_ReturnMessage";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 200));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Output;

            //ParaName = "@Colour";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 20));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Output;

            //ParaName = "@PrintQty";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.Int));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Output;

            //ParaName = "@I_ExceptionFieldName";
            //cmd.Parameters.Add(new SqlParameter(ParaName, SqlDbType.NVarChar, 20));
            //cmd.Parameters[ParaName].Direction = ParameterDirection.Output;



            //int result = -1;

            //DataSet ds = new DataSet();
            //cmd = RunStoredProcedure(cmd, out ds, out result);

            //string ReturnMessage = cmd.Parameters["@I_ReturnMessage"].Value.ToString();
            ////string colour = cmd.Parameters["@Colour"].Value.ToString();
            ////string qty = cmd.Parameters["@PrintQty"].Value.ToString();
            //string focus = cmd.Parameters["@I_ExceptionFieldName"].Value.ToString();

            //if (result == -1)
            //{
            //    MessageBox(ReturnMessage);
            //}
            //else
            //{

            //    MessageBox(ReturnMessage);
            //    //labprint.Text = string.Format("扫描数量：{0}", qty);
            //}
            //switch (focus)
            //{
            //    case "OldUserName":
            //        userNameCombo.Focus();
            //        break;
            //    case "UserName":
            //        newUserNameCombo1.Focus();
            //        //newUserNameCombo1.SelectAll();
            //        break;

            //    case "OldProductName":
            //        textBox1.Focus();
            //        break;
            //    case "NewProductName":
            //        textBox2.Focus();
            //        //newUserNameCombo1.SelectAll();
            //        break;
            //    default:
            //        //txtlotsn.Focus();
            //        //txtlotsn.SelectAll();
            //        break;
            //}

            #endregion


        }




    }
}
