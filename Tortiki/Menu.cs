using Tortiki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortiki
{
    internal class Menu
    {
        
        public static int Cursor(int minstr, int maxstr)
        {

            
            ConsoleKeyInfo cursor;
            int position = 3;
            do
            {

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                cursor = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (cursor.Key == ConsoleKey.DownArrow && position != maxstr)
                {
                    position++;
                }

                if (cursor.Key == ConsoleKey.UpArrow && position != minstr)
                {
                    position--;
                }
                if (cursor.Key == ConsoleKey.Escape)
                {
                    DlyaZakaza one = new DlyaZakaza();
                    Console.Clear();
                    one.osnova();
                }
                Console.SetCursorPosition(0, position);

            } while (cursor.Key != ConsoleKey.Enter);
            return position;


        }
    }
}
