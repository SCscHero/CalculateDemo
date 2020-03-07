using System;
using System.Collections.Generic;
namespace CalculateDemo
{
    class Program
    {
        /// <summary>
        /// 记录方法的Dictionary
        /// </summary>
        static Dictionary<string, string> cfg = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Load();
            while(true)
            {
                Console.Write("请输入操作数1：");
                int x = int.Parse(Console.ReadLine());
                Console.Write("请输入操作数2：");
                int y = int.Parse(Console.ReadLine());
                Console.Write("请输入运算符:");
                string op = Console.ReadLine();
                Operator opr = OperatorFactory.Create(cfg[op]);
                opr.Left = x;
                opr.Right = y;
                int r = opr.Calc();
                Console.WriteLine($"{x}{op}{y}={r}");
            }
        }
        /// <summary>
        /// 初始化赋值
        /// </summary>
        static void Load()
        {
            cfg.Add("+", "CalculateDemo.AddOperator");
            cfg.Add("-","CalculateDemo.SubOperator");
            cfg.Add("*", "CalculateDemo.MulOperator");
            cfg.Add("/", "CalculateDemo.DivOperator");
        }
    }
}
