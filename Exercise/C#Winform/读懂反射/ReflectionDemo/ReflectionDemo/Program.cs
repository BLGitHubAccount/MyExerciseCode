using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(RefClass);
            RefClass rc = new RefClass();
            rc.Test3 = 3;
            #region 窥视内部
            //Func<MemberTypes, string> getType = (x) =>
            // {
            //     switch (x)
            //     {

            //         case MemberTypes.Field:
            //             return "字段";

            //         case MemberTypes.Method:
            //             return "方法";

            //         case MemberTypes.Property:
            //             return "属性";

            //         default:
            //             return "未知";

            //     }
            // };
            //MemberInfo[] memberInfos = t.GetMembers(BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.DeclaredOnly | BindingFlags.Static);
            //foreach (MemberInfo item in memberInfos)
            //{
            //    Console.WriteLine(item.Name+"类型"+getType(item.MemberType));
            //}
            #endregion 窥视内部
            #region 深入窥视字段
            //FieldInfo[] fields = t.GetFields(BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly);

            //foreach (FieldInfo item in fields)
            //{
            //    item.SetValue(rc,100);
            //    Console.WriteLine(string.Format("字段名称:{0}字段类型{1}rc中的值{2}",item.Name,item.FieldType.ToString(),item.GetValue(rc)));
            //}
            #endregion 深入窥视字段
            #region 深入窥视属性
            //PropertyInfo[] propertyInfos = t.GetProperties(BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly);
            //foreach (PropertyInfo item in propertyInfos)
            //{
            //    MethodInfo getInfo = item.GetGetMethod(true);
            //    Console.WriteLine("get方法名称{0} 返回值类型{1} 参数数量{2} MSIL代码长度{3} 局部变量{4}",getInfo.Name,getInfo.ReturnType.ToString(),getInfo.GetParameters().Count(),getInfo.GetMethodBody().GetILAsByteArray().Length,getInfo.GetMethodBody().LocalVariables.Count);
            //    MethodInfo setInfo = item.GetSetMethod(true);
            //    Console.WriteLine("set方法名称{0} 返回值类型{1} 参数数量{2} MSIL代码长度{3} 局部变量{4}", setInfo.Name, setInfo.ReturnType.ToString(), setInfo.GetParameters().Count(), setInfo.GetMethodBody().GetILAsByteArray().Length, setInfo.GetMethodBody().LocalVariables.Count);

            //    setInfo.Invoke(rc,new object[] { 123});
            //    object obj = getInfo.Invoke(rc,null);
            //    Console.WriteLine("方法名{0} 内部值{1}",item.Name,obj);
            //}
            #endregion 深入窥视属性
            #region 深入窥视方法

            MethodInfo[] finfos = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly|BindingFlags.Static);
            foreach (MethodInfo finfo in finfos)
            {
                if (finfo.GetParameters().Count() > 0 && finfo.GetParameters()[0].ParameterType == typeof(string))
                {
                    object obj = finfo.Invoke(rc, new[] { "123" });
                    MethodBody mbody = finfo.GetMethodBody();
                    Console.WriteLine("拥有参数的方法名：{0} 返回值类型{1} 参数1类型{2} 参数1名称{3} 方法调用后的返回的值{4}", finfo.Name, finfo.ReturnType.ToString(), finfo.GetParameters()[0].ParameterType.ToString(), finfo.GetParameters()[0].Name, obj.ToString());
                }
                else
                {
                    MethodBody mbody = finfo.GetMethodBody();
                    Console.WriteLine("没有参数的方法名{0} 返回值类型：{1}",finfo.Name,finfo.ReturnType.ToString());
                }
            }
            #endregion 深入窥视方法
            Console.ReadKey();
        }
    }
}
