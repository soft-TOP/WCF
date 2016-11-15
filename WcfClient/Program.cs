using System;
using System.Text;
using System.ServiceModel;
using WcfHost;

namespace WcfClient
{
    class Program
    {
        private static IWcfHost host = null;

        static void Main(string[] args)
        {   
            Uri baseAddress = new Uri("net.tcp://localhost:8999/MyService");
            EndpointAddress address = new EndpointAddress(baseAddress);
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IWcfHost> factory = new ChannelFactory<IWcfHost>(binding, address);
            host = factory.CreateChannel();

            Console.WriteLine("Please enter some words.");
            string input = Console.ReadLine(); // read input
            string output = host.Echo(input); // send to host, receive output
            Console.WriteLine(output); // write output

            int sum = host.Sum(5, 8);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}