using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈的应用_四则运算
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入计算表达式：");
                string exp = Console.ReadLine();
                Console.Write("=");
                string str = TranformExpression(exp);
                Console.WriteLine(CalculateExpression(str));
            }

           
        }

        //将中缀表达式转换为后缀表达式
        public static string TranformExpression(string str)
        {
            string strTemp = "";
            //原始数据中提取出操作数
            string[] subStrs = str.Split('+', '-', '*', '/', '(', ')');
            List<string> newStrs = new List<string>();
            foreach (string temp in subStrs)
            {
                if (temp != "")
                    newStrs.Add(temp);
            }

            Stack<char> charStack = new Stack<char>();
            //将表达式转换为后缀表达式
            //规则如下：1.若是数字直接输出 
            //2.若是符号，判断其与栈顶符号的优先级,是右括号或优先级不高于栈顶符号（乘除优先加减），则栈顶元素一次出栈并输出
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                bool currentNum = false;//当前字符与下一个字符是否均为数字
                                        //当前字符为运算符
                if (str[i] < '0' || str[i] > '9')
                {
                    /*符号输出操作*/
                    //为左边括号直接进栈
                    if (str[i] == '(')
                        charStack.Push(str[i]);
                    else if (str[i] == ')')
                    {
                        //括号匹配，依次出栈
                        while (charStack.Count > 0 && charStack.Peek() != '(')
                        {
                            strTemp += charStack.Pop() + " ";
                        }
                        if (charStack.Count > 0)
                        {
                            charStack.Pop(); //取出左小括号
                        }
                    }
                    else if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                    {
                        //若当前栈为空
                        if (charStack.Count == 0)
                            charStack.Push(str[i]);
                        else
                        {
                            //比较当前字符与栈顶字符的优先级
                            while (charStack.Count > 0 && !IsPriority(str[i], charStack.Peek()))
                            {
                                strTemp += charStack.Pop() + " ";
                            }
                            charStack.Push(str[i]);
                        }
                    }
                }
                //当前字符为数字
                else
                {
                    //下一个字符仍为数字
                    if ((i + 1) < str.Length && str[i + 1] >= '0' && str[i + 1] <= '9')
                        currentNum = true;
                    if (!currentNum && j < newStrs.Count)
                    {
                        strTemp += newStrs[j++] + " ";
                    }
                }
            }

            //顺序输出栈中剩余操作符
            while (charStack.Count > 0)
            {
                if (charStack.Count == 1)
                    strTemp += charStack.Pop();
                else
                    strTemp += charStack.Pop() + " ";
            }
            return strTemp;
        }

        //ch1优先级高,返回false,否则，返回true
        //ch1为当前元素，ch2为栈顶元素
        //优先级不高于栈顶元素，则栈顶元素依次出栈并输出，并将当前符号进栈
        public static bool IsPriority(char ch1, char ch2)
        {
            if ((ch1 == '+' || ch1 == '-') && (ch2 == '*' || ch2 == '/' || ch2 != '('))
            {
                return false;
            }
            return true;
        }

        //计算后缀表达式
        public static string CalculateExpression(string transStr)
        {
            string result = "";
            string[] strs = transStr.Split(' ');
            Stack<string> calStack = new Stack<string>();

            //判断字符串是否为数字
            foreach (string str in strs)
            {
                if (isNumberic(str))
                {
                    calStack.Push(str);
                }
                else
                {
                    string op1 = calStack.Pop();
                    string op2 = calStack.Pop();
                    double temp = CalculateAllOperation(str, op2, op1);
                    calStack.Push(temp + "");
                }
            }
            return result = calStack.Peek();
        }

        //判断字符串能否转换成数字
        private static bool isNumberic(string str)
        {
            try
            {
                double.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //计算操作
        private static double CalculateAllOperation(string operation, string op1, string op2)
        {
            double operation_1 = double.Parse(op1);
            double operation_2 = double.Parse(op2);
            if (Math.Abs(operation_2 - 0.0f) < 0.000001f)
                return default(double);
            double result = 0.0f;

            switch (operation)
            {
                case "+":
                    result = operation_1 + operation_2;
                    break;
                case "-":
                    result = operation_1 - operation_2;
                    break;
                case "*":
                    result = operation_1 * operation_2;
                    break;
                case "/":
                    result = operation_1 / operation_2;
                    break;
            }
            return result;
        }
    }
}
