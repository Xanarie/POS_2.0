using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS2._0
{
    internal class MainMenu_Options
    {
        //MainMenu after Logo Display: POS,Product Management and Exit


        public void DisplayMenu_Options(Inventory inventory)
        {
            Console.SetCursorPosition(inventory.selectedindex, 0);
            Console.Write($"{inventory.MainMenu}");
            Console.CursorVisible = false;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                for (int i = 0; i < inventory.MainMenu.Count; i++)
                {
                    if (i == inventory.selectedindex)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.SetCursorPosition(70, 12 + i);
                    Console.WriteLine(inventory.MainMenu[i]);
                    Console.ResetColor();
                }
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveSelection(-1, inventory);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveSelection(1, inventory);
                        break;
                    case ConsoleKey.Enter:
                        ExecuteSelectedOption(inventory);
                        break;
                }

            } while (key.Key != ConsoleKey.Enter);


        }
        public void MoveSelection(int move, Inventory inventory)
        {
            inventory.selectedindex += move;

            if (inventory.selectedindex < 0)
                inventory.selectedindex = inventory.MainMenu.Count - 1;
            else if (inventory.selectedindex >= inventory.MainMenu.Count)
                inventory.selectedindex = 0;
        }

        public void ExecuteSelectedOption(Inventory inventory)
        {
            POS_Cashier  cashier = new POS_Cashier();
            
            switch (inventory.selectedindex)
            {
                case 0:
                    // Execute action for Option 1 (navigate to Class1)
                    Console.Clear();
                    cashier.DisplayProduct(inventory);
                    break;
                    //case 1:
                    //    // Execute action for Option 2 (navigate to Class2)
                    //    Console.WriteLine("Executing action for Option 2 (navigate to Class2)");
                    //    Class2.Run();
                    //    break;

            }
        }
    }
}
