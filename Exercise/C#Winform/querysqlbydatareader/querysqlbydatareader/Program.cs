using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace querysqlbydatareader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection mysqlcon = new SqlConnection();
            mysqlcon.ConnectionString = "Server=.;user=sa;pwd=baolj;database=baozidatabase;";

            try
            {
                mysqlcon.Open();
                string sql = "select * from student ";
                SqlCommand mysqlcom = new SqlCommand(sql,mysqlcon);
                SqlDataReader mydr = mysqlcom.ExecuteReader();
                Console.WriteLine("使用datareader打印输出");
                for (int i = 0; i < mydr.FieldCount; i++)
                {
                    Console.Write(mydr.GetName(i).ToString()+"\t");
                }
                Console.WriteLine();
                while(mydr.Read())
                {

                    for (int i = 0; i < mydr.FieldCount; i++)
                    {
                        Console.Write(mydr[i].ToString()+"\t");
                    }
                    Console.WriteLine();

                }

                mydr.Close();

                Console.WriteLine("使用数据集打印输出");
                SqlDataAdapter myda = new SqlDataAdapter(sql,mysqlcon);
                DataSet ds = new DataSet();
                myda.Fill(ds,"student");
                foreach (DataTable dt in ds.Tables)
                {

                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(col.ColumnName+"\t");
                    }
                    Console.WriteLine();
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            Console.Write(row[col]+"\t");
                        }
                        Console.WriteLine();
                    }
                   
                }

                

                
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mysqlcon.Close();
            }
            Console.WriteLine("关闭数据库成功");
            Console.ReadKey();
        }
    }
}
