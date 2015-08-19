using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTestingServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ServiceReference2.ServiceClient();
            //Console.WriteLine(a.helloWorld());
            var b = new ServiceReference1.AuthorizationServiceClient();
            //Console.WriteLine(b.VerifyEmail("snek@gmail.com").Item1);
            var c = new ServiceAuthorization.AuthorizationService();
            Console.WriteLine(c.VerifyEmail("grandys@seznam.cz").m_Item1);
            var d = new ServiceTest.Service();
            Console.WriteLine(d.helloWorld());
            Console.ReadKey();
        }
    }
}
