using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POS2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logo Display
            Logo logo = new Logo();
            logo.DisplayLogo();
            logo.OpenSystem();
           
            //Inventory Global Declare
            Inventory inventory = new Inventory();

            ConsoleKeyInfo keyInfo; //arrow keys manipulation

            //Cashier Global Declaration
            POS_Cashier cashier = new POS_Cashier();

            //Main Menu Global Declaration
            MainMenu_Options menuOptions = new MainMenu_Options();
            do
            {

                Console.Clear();
                //cashier.DisplayProduct(inventory);

                menuOptions.DisplayMenu_Options(inventory);
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Escape);



            Console.ReadKey();
        }
    }
}
