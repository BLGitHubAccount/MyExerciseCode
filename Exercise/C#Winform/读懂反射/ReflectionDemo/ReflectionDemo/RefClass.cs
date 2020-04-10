using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class RefClass
    {
        private int test3;
        private int test1 { get; set; }
        protected int test2 { get; set; }
        public int Test3 { get; set; }

        public string Show(string s)
        {
            string a;
            return s;
        }

        public static void Show2()
        { }

        public static string  Show3(string s)
        {
            int b;
            int c;
            return s;
        }
    }
}
