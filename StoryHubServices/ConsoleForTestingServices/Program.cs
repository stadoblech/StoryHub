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
            var c = new ServiceAuthorization.AuthorizationService();
            //Console.WriteLine(c.VerifyEmail("grandys@seznam.cz").m_Item1);

            Console.WriteLine(c.VerifyPassword("snek@gmail.com", "heslo").m_Item1); //spravne prihlasovaci udaje
            Console.WriteLine(c.VerifyPassword("snek@gmhail.com", "heslo").m_Item1);  //nespravny mail
            Console.WriteLine(c.VerifyPassword("snek@gmail.com", "hesjlo").m_Item1); //nespravne heslo
            Console.WriteLine(c.VerifyPassword("snek@gmkail.com", "hekslo").m_Item1);  //nespravny mail a heslo

            //test vložení a odstranění uživatele
            Console.WriteLine(c.Register("holby@hoal.ru", "heslo", true, true, "cs_CZ", true, true, new string[] { "cs_CZ", "en_US" }).m_Item1);
            Console.WriteLine(c.RemoveUser("holby@hoal.ru").m_Item1);
            Console.WriteLine(c.Register("martin.vasek@seznam.cz", "heslo", true, true, "cs_CZ", true, true, new string[] { "cs_CZ", "en_US" }).m_Item1);

            Console.ReadKey();
        }
    }
}
