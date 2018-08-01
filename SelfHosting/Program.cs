using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CardInfo;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(card));
            host.Open();
            Console.WriteLine("Server Started");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
