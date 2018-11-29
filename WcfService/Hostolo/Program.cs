using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hostolo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfService.Service1)))
            {
                host.Open();
                Console.WriteLine("Elindult");
                Console.ReadKey();
            }

        }
    }
}
