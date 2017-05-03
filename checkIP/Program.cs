using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using checkIP.Libs;

namespace checkIP
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter x = new TextWriter();
            string NazwaHosta = Dns.GetHostName();
            IPHostEntry AdresyIP = Dns.GetHostEntry(NazwaHosta);
            x.PcName("Nazwa komputera: " + NazwaHosta);
            int licznik = 0;
           

            foreach (IPAddress AdresIP in AdresyIP.AddressList)
            {
                if (AdresIP.ToString() == "127.0.0.1")
                {
                    Console.WriteLine("Komputer nie jest podłączony do sieci. Adres IP to: "
                        + AdresIP.ToString());
                }
                else
                {

                    x.AdresText("  Adres IP - nr. " + ++licznik + ". " + AdresIP.ToString());
 

                }
                Console.ReadLine();
            }
        }
    }
}
