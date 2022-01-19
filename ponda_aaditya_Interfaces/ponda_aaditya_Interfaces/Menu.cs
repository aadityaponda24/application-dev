using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    public class Menu
    {
        /* List of menu items */
        private List<string> _menuItems;

        /* Constructor to initialize Menu */
        public Menu(List<string> menuItems)
        {
            this._menuItems = menuItems;
        }


        /* Displays menu list starting with given index */
        public void displayMenu(int startIndex)
        {
            int index = startIndex;
            foreach (string menu in _menuItems)
            {
                Console.WriteLine($"[{index}] {menu}");
                index++;
            }
            Console.WriteLine();
        }

        /* Displays menu list starting with given index */
        public static void DisplayHeader(string header)
        {
            Console.WriteLine(header);
            Console.WriteLine("=============================================");
            Console.WriteLine();
        }

        /* Displays content */
        public static void DisplayContent(string content)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(content);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        public static void ReadKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
