using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WcfServiceLib;
using System.Threading;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Thread.Sleep(20);
                Console.WriteLine("Service start.");
                Console.Read();
            }
        }
    }
}
