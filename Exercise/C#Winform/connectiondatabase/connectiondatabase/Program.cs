using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace connectiondatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //string constr = "Server=.;user=sa;pwd=baolj;database=baozidatabase;";        //sql身份验证
            string constr = "Server=.;database=baozidatabase;integrated security=SSPI;";   //windows身份验证

            //创建sql连接对象 mycon
            SqlConnection mycon = new SqlConnection(constr);

            //打开数据库和关闭数据库
            //mycon.Open();
            //Console.WriteLine("连接数据库成功");
            //mycon.Close();


            //实用try catch finally 打开关闭数据库
            try
            {
                mycon.Open();
                Console.WriteLine("数据库连接成功");
            }

            catch

            {

            }

            finally
            {
                mycon.Close();
                Console.WriteLine("数据库关闭成功");
            }

            //实用using语句打开数据库
            //using (mycon)
            //{

            //    mycon.Open();
            //    Console.WriteLine("连接数据库成功");
            //}
            //  mycon.Close();

            //Console.WriteLine(" 关闭数据库成功");
            Console.ReadLine();


        }
    }
}
