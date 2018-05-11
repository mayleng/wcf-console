using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleClient.WcfSvc;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
           Service1Client client = new Service1Client();
            var result = client.GetData(123);
            Console.Title = "Wcf Client";   //设置控制台窗口的标题
            Console.WriteLine(result);
            // Console.Read();

            while (true)
            {
                //接收用户的输入
                Console.ForegroundColor = ConsoleColor.White;  //设置字体颜色为红色
                Console.Write("请输入任意字符串：");
                string put = Console.ReadLine();
                string put1 = "";
                for (int i = 0; i <= put.Length - 1; i++)
                {
                    put1 += put[i];
                }
                string aa = client.ShowPut(put1);
                Console.ForegroundColor = ConsoleColor.Red;  //设置字体颜色为红色
                Console.WriteLine(aa);
               // Console.Read();
            }
          

        }
    }
}
