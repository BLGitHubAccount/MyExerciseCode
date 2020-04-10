using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace datareader
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
                Console.WriteLine("1.成功打开数据库");

                string sql = "select * from student ";
                SqlCommand mycom = new SqlCommand(sql, mysqlcon);

                //声明datareader
                SqlDataReader mydr;
                mydr = mycom.ExecuteReader();

                if (mydr.HasRows)
                {
                    Console.WriteLine("2.学生表中有数据");
                    Console.WriteLine("表中一共有:"+mydr.FieldCount+"个字段");

                }
                else
                {

                    Console.WriteLine("2.学生表中没有数据");
                }

                Console.WriteLine(mydr.GetName(0));
                Console.WriteLine(mydr.GetDataTypeName(0));


                //if(mydr.Read())
                //Console.WriteLine(mydr.GetValue(2));

                //object[] myobj = new object[mydr.FieldCount];
                //while (mydr.Read())//逐行读取
                //{
                //    mydr.GetValues(myobj);
                //    foreach (object outobj in myobj)//字段遍历
                //    {
                //        Console.Write(outobj);
                //       // Console.Write(outobj + "\t");
                //    }

                //    Console.WriteLine();

                //}

                while (mydr.Read())
                {
                    Console.Write(mydr[0].ToString() + "\t");
                    Console.Write(mydr[1].ToString() + "\t");
                    Console.Write(mydr[2].ToString() + "\t");
                    Console.Write(mydr[3].ToString() + "\t");
                    Console.Write(mydr[4].ToString() + "\t");

                    //Console.Write(mydr["studentid"].ToString()+"\t");
                    //Console.Write(mydr["name"].ToString()+"\t");
                    //Console.Write(mydr["sex"].ToString()+"\t");
                    //Console.Write(mydr["age"].ToString()+"\t");
                    //Console.Write(mydr["stdno"].ToString()+"\t");
                    Console.WriteLine();
                }

                //isclosed属性表示datareader是否是关闭的
                Console.WriteLine(mydr.IsClosed);//
                mysqlcon.Close();
                Console.WriteLine(mydr.IsClosed);

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            finally

            {
                
                Console.WriteLine();
                mysqlcon.Close();
                Console.WriteLine("3.关闭数据库成功");
            }

            Console.ReadLine();


        }
    }
}
