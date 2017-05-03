using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkIP.Libs
{
    class TextWriter
    {
        private ConsoleColor bgcolor = ConsoleColor.White;
        private ConsoleColor fbcolor = ConsoleColor.Black;

        public void AdresText(string s)
        {

            Console.ForegroundColor = fbcolor;
            Console.BackgroundColor = bgcolor;
            Console.WriteLine(s);

        }

        public void PcName(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(s);
            Console.ForegroundColor = fbcolor;
            Console.BackgroundColor = bgcolor;

        }


    }
}
