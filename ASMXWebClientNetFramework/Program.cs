using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMXWebClientNetFramework
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            var client = new ServiceReference1.WebServiceSoapClient();
            Task<ServiceReference1.SumResponse> response = client.SumAsync("2", "2");
            Console.WriteLine(response.Result);
            Console.ReadLine();
        }
    }
}
