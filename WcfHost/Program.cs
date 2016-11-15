using System;
using System.ServiceModel;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfHost)))
            {
                Uri baseAddress = new Uri("net.tcp://localhost:8999/MyService");
                NetTcpBinding binding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IWcfHost), binding, baseAddress);
                host.Open();

                Console.WriteLine("Service started, press any key to finish execution.");
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
