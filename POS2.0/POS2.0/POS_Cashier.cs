using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS2._0
{
    internal class POS_Cashier
    {

        public void DisplayProduct(Inventory product)
        {
            int menuX = 50; // X-coordinate for the menu
            int menuY = 9;  // Y-coordinate for the menu
            int productX = 50; // X-coordinate for the product display
            int productY = 11; // Y-coordinate for the product display
            int pagelimit = 10; // page per slide
            int currentpage = 1;
            int totalpage = (int)Math.Ceiling((double)product.ProductName.Count / pagelimit);

            while (true)
            {
                Console.Clear();

                //Menu Labels: Product Name, Quantity and Price
                Console.SetCursorPosition(menuX, menuY);
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = 0; i < product.MenuLabels.Length; i++)
                {
                    Console.Write($"{product.MenuLabels[i].PadRight(25)}");
                }

                // The MENU Display: including the product itself, its quantity and its prices
                for (int i = (currentpage - 1) * pagelimit; i < Math.Min(currentpage * pagelimit, product.ProductName.Count); i++)
                {
                    Console.SetCursorPosition(productX, productY + i % pagelimit);
                    Console.ResetColor();
                    Console.Write($"{product.ProductName[i].PadRight(25)}");
                    Console.Write($" {product.ProductQuantity[i].ToString().PadRight(23)}");
                    Console.Write($" Php {product.ProductPrice[i].ToString().PadRight(20)}\n");
                    Console.ResetColor();
                }

                Console.SetCursorPosition(productX, productY + pagelimit); // Set the Y-coordinate after the loop
                Console.WriteLine("══════════════════════════════════════════════════════════");
                Console.SetCursorPosition(productX, productY + pagelimit + 1);
                Console.WriteLine($"  < prev.               Page {currentpage} of {totalpage}             next >");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    // Go to the next page
                    currentpage++;
                    if (currentpage > totalpage)
                    {
                        currentpage = 1; // Wrap around to the first page
                    }
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    // Go to the previous page
                    currentpage--;
                    if (currentpage < 1)
                    {
                        currentpage = totalpage; // Wrap around to the last page
                    }
                }

                
            }

        }
        public void MoveSelection(int move, Inventory inventory)
        {
            inventory.selectedindex += move;

            if (inventory.selectedindex < 0)
                inventory.selectedindex = inventory.ProductName.Count - 1;
            else if (inventory.selectedindex >= inventory.ProductName.Count)
                inventory.selectedindex = 0;
        }


    }
}
