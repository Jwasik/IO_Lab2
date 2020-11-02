using System;

namespace TCPAsych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ip = System.Net.IPAddress.Parse("192.168.0.120");
            TCPAsynchClasses.Asynch server = new TCPAsynchClasses.Asynch(ip,8888);
            server.Start();
        }
    }
}
