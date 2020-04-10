using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqlCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;database=baozidatabase;user=sa;pwd=baolj;";

            SqlConnection mysqlcon = new SqlConnection(constr);
         


            try
            {
                mysqlcon.Open();
                // string sql = "insert into student(studentid,name,sex,age,stdno) values('4','baolj','man','17','022')";
                string sql = "select count(1) from student";
                //创建Command对象
                SqlCommand mysqlcommand = new SqlCommand(sql,mysqlcon);
                mysqlcommand.CommandTimeout = 2;
                //更改数据 ExecuteNonQuery()
                //int count=mysqlcommand.ExecuteNonQuery();
                // Console.Write("数据更改完成,受影响的行数为{0}",count);
                //返回一个值 ExecuteScalar()
                int count =(int)mysqlcommand.ExecuteScalar();
                Console.WriteLine("学生表里一共有"+count+"行数据");
               


                

            }

            catch(Exception ex)

            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mysqlcon.Close();
            }

            Console.ReadLine();
        }
    }
}
