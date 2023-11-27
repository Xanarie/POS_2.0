using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POS2._0
{
    internal class Logo
    {
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(50, 8);
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.ResetColor();
            Console.SetCursorPosition(50, 9);
            Console.WriteLine(@"  ████████▄     ▄█   ▄█▄ ████████▄     ▄█   ▄█▄ ████████▄  ");
            Console.SetCursorPosition(50, 10);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███   ▀███   ███ ▄███▀ ███   ▀███   ███ ▄███▀ ███   ▀███");
            Console.SetCursorPosition(50, 11);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███    ███   ███▐██▀   ███    ███   ███▐██▀   ███    ███");
            Console.SetCursorPosition(50, 12);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███    ███  ▄█████▀    ███    ███  ▄█████▀    ███    ███");
            Console.SetCursorPosition(50, 13);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███    ███ ▀▀█████▄    ███    ███ ▀▀█████▄    ███    ███");
            Console.SetCursorPosition(50, 14);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███    ███   ███▐██▄   ███    ███   ███▐██▄   ███    ███");
            Console.SetCursorPosition(50, 15);
            Thread.Sleep(50);
            Console.WriteLine(@"  ███   ▄███   ███ ▀███▄ ███   ▄███   ███ ▀███▄ ███   ▄███");
            Console.SetCursorPosition(50, 16);
            Thread.Sleep(50);
            Console.WriteLine(@"  ████████▀    ███   ▀█▀ ████████▀    ███   ▀█▀ ████████▀");
            Console.SetCursorPosition(50, 17);
            Thread.Sleep(50);
            Console.WriteLine(@"  ▀                      ▀                      ▀");
            Console.SetCursorPosition(50, 18);
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("════════════════════════════════════════════════════════════");
            Console.SetCursorPosition(50, 19);
            Thread.Sleep(50);
            

        }

        public void OpenSystem()
        {
            Console.ResetColor();
            Console.Write("Opening System");
            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(50 + i, 20);
                Console.Write(". ");
                Thread.Sleep(100);
            }
        }
    }
}
