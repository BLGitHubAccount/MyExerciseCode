using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dataadapter
{
    class Program
    {
        static void Main(string[] args)
        {

            string constr = "Server=.;user=sa;pwd=baolj;database=baozidatabase;";
            SqlConnection mysqlcon = new SqlConnection(constr);


            try
            {
                mysqlcon.Open();
                //string sql = "select * from student";

                //SqlDataAdapter myada = new SqlDataAdapter(sql,mysqlcon);
                //DataSet ds = new DataSet();

                //myada.Fill(ds, "student");

                //Console.WriteLine("填充成功");

                //outputvalues(ds);

                string updatesql = "update student set name='pengxi'  where studentid=2";

                SqlDataAdapter myada = new SqlDataAdapter("select * from student",mysqlcon);
                myada.UpdateCommand = new SqlCommand(updatesql,mysqlcon);
                DataSet ds = new DataSet();
                myada.Fill(ds,"student");
                Console.WriteLine("更改前的数据");
                outputvalues(ds);

                DataRow row = ds.Tables[0].Rows[1];
                row["name"] = "pengxi";
                Console.WriteLine("更改后的数据");
                myada.Update(ds,"student");
                outputvalues(ds);
               
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mysqlcon.Close();
            }

            Console.ReadKey();
        }

        public static void outputvalues(DataSet ds)
        {
            foreach (DataTable tables in ds.Tables)
            {
                Console.WriteLine("表名" + tables.TableName);
                foreach (DataRow row in tables.Rows)
                {
                    foreach (DataColumn col in tables.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }
                    Console.WriteLine();
                }

            }

        }
    }
}

