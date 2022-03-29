using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.WCFServiceClient();
            string response = client.Sum("2", "2");
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
