using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS2._0
{
    internal class Inventory
    {
        //arrowkeys
        public int selectedindex = 0;
        //POS SYSTEM
        public List<string> ProductName { get; set; }
        public List<int> ProductPrice { get; set; }
        public List<int> ProductQuantity { get; set; }
        public string[] MenuLabels { get; set; }

        //MAIN MENU
        public List<string> MainMenu { get; set; }
       
        public Inventory()
        {
            //POS SYSTEM
            ProductName = new List<string>()
            {
                "Presto",
                "Bingo",
                "Grahams",
                "C2",
                "Coke",
                "Hansel",
                "Royal Can",
                "Trust",
                "Robust",
                "Lighter",
                "Milo",
                "Orange Juice",
                "Tang",
                "Eight Oclock",
                "Bread",
                "Mayonnaise",
            };
            ProductPrice = new List<int>()
            {
                8,
                8,
                8,
                12,
                15,
                8,
                35,
                35,
                35,
                15,
                8,
                15,
                24,
                24,
                75,
                55
            };
            ProductQuantity = new List<int>()
            {
                15,
                15,
                15,
                9,
                24,
                15,
                15,
                23,
                34,
                23,
                12,
                43,
                23,
                34,
                12,
                32
            };
            MenuLabels = new string[] 
            { 
                "Product Name",
                "Quantity",
                "Price"
            };

            //MAIN MENU
            MainMenu = new List<string>() 
            { 
                "Point of Sale System",
                "Product Management",
                "Exit"
            };
        }
        
    }
}
