using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortiki;
using System.IO;


namespace Tortiki
{
    internal class DlyaZakaza
    {
        private int cost = 0;
        private List<string> order = new List<string>();
        private string or = "";

        public void osnova()
        {
            Console.WriteLine("Заказ тортов в ПУПА И ЛУПА, торты на ваш выбор!");
            Console.WriteLine("Выберите параметры торта:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine();
            Console.WriteLine("Цена: " + cost);
            Console.Write("Ваш заказ: ");
            foreach (var index in order)
            {
                Console.Write(index + ", ");
            }
            int position = Menu.Cursor(3, 9);

            switch (position)
            {
                case 3:

                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake formcircle = new Cake("  Круг - ", 200);
                    Cake formsquare = new Cake("  Квадрат - ", 500);
                    Cake formrectangle = new Cake("  Прямоугольник - ", 500);
                    Cake formheart = new Cake("  Сердечко - ", 700);
                    position = Menu.Cursor(3, 6);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 200;
                        order.Add("Круг - 200");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 500;
                        order.Add("Квадрат - 500");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 500;
                        order.Add("Прямоугольник - 500");
                        osnova();
                    }
                    if (position == 6)
                    {
                        Console.Clear();
                        cost = cost + 700;
                        order.Add("Сердечко - 700");
                        osnova();
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake sizemin = new Cake("  Маленький (Диаметр 16 см, 8 порций) - ", 1000);
                    Cake sizemedium = new Cake("  Обычный (Диаметр 18 см, 10 порций) - ", 1200);
                    Cake sizebig = new Cake("  Большой (Диаметр 28 см, 24 порций) - ", 2000);
                    position = Menu.Cursor(3, 6);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 1000;
                        order.Add("Маленький (Диаметр 16 см, 8 порций) - 1000");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 1200;
                        order.Add("Обычный (Диаметр 18 см, 10 порций) - 1200");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 2000;
                        order.Add("Большой (Диаметр 28 см, 24 порций) - 2000");
                        osnova();
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake tastevanilla = new Cake("  Ванильный - ", 100);
                    Cake tastechoko = new Cake("  Шоколадный - ", 100);
                    Cake tastecaramel = new Cake("  Карамельный - ", 150);
                    Cake tasteberry = new Cake("  Ягодный - ", 200);
                    Cake tastecoconut = new Cake("  Клубнично-малиновый - ", 250);
                    position = Menu.Cursor(3, 7);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 100;
                        order.Add("Ванильный - 100");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 100;
                        order.Add("Шоколадный - 100");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Карамельный - 150");
                        osnova();
                    }
                    if (position == 6)
                    {
                        Console.Clear();
                        cost = cost + 200;
                        order.Add("Ягодный - 200");
                        osnova();
                    }
                    if (position == 7)
                    {
                        Console.Clear();
                        cost = cost + 250;
                        order.Add("Клубнично-малиновый - 250");
                        osnova();
                    }
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake shortcakeone = new Cake("  1 корж - ", 200);
                    Cake shortcaketwo = new Cake("  2 коржа - ", 400);
                    Cake shortcakethree = new Cake("  3 коржа - ", 800);
                    Cake shortcakeonefour = new Cake("  4 коржа - ", 1000);
                    position = Menu.Cursor(3, 6);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 200;
                        order.Add("1 корж - 200");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 400;
                        order.Add("2 коржа - 400");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 800;
                        order.Add("3 коржа - 800");
                        osnova();
                    }
                    if (position == 6)
                    {
                        Console.Clear();
                        cost = cost + 1000;
                        order.Add("4 коржа - 1000");
                        osnova();
                    }
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake glazechokolate = new Cake("  Шоколад - ", 100);
                    Cake glazecream = new Cake("  Крем - ", 100);
                    Cake glazemeringue = new Cake("  Безе - ", 150);
                    Cake glazedragees = new Cake("  Драже - ", 150);
                    Cake glazeberry = new Cake("  Ягоды - ", 200);
                    position = Menu.Cursor(3, 7);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 100;
                        order.Add("Шоколад - 100");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 100;
                        order.Add("Крем - 100");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Безе - 150");
                        osnova();
                    }
                    if (position == 6)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Драже - 150");
                        osnova();
                    }
                    if (position == 7)
                    {
                        Console.Clear();
                        cost = cost + 200;
                        order.Add("Ягоды - 200");
                        osnova();
                    }
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("-------------------------");
                    Cake decorchocolate = new Cake("  Шоколадная - ", 150);
                    Cake decorberry = new Cake("  Ягодная - ", 150);
                    Cake decorcream = new Cake("  Кремовая - ", 150);
                    position = Menu.Cursor(3, 5);
                    if (position == 3)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Шоколадная - 150");
                        osnova();
                    }
                    if (position == 4)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Ягодная - 150");
                        osnova();
                    }
                    if (position == 5)
                    {
                        Console.Clear();
                        cost = cost + 150;
                        order.Add("Кремовая - 150");
                        osnova();
                    }
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ. Если хотите сделать ещё один заказ, нажмите Escape");
                    safefile();
                    break;
            }
        }
        private void safefile()
        {
            string pathtofile = "tort.txt";

            string costforfile = Convert.ToString(cost);
            for (int i = 0; i < order.Count; i++)
            {
                or += order[i] + ", ";
            }

            if (File.Exists(pathtofile))
            {
                File.AppendAllText(pathtofile, "Заказ от : " + DateTime.Now.ToString("f"));
                File.AppendAllText(pathtofile, "\n\t");
                File.AppendAllText(pathtofile, "Заказ: " + or);
                File.AppendAllText(pathtofile, "\n\t");
                File.AppendAllText(pathtofile, "Цена: " + costforfile);
                File.AppendAllText(pathtofile, "\n");
                File.AppendAllText(pathtofile, "\n");
            }

            else 
            {
                File.Create(pathtofile).Close();
                safefile();
            }


            ConsoleKeyInfo cursor = Console.ReadKey();
            if (cursor.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                cost = 0;
                order.Clear();
                or = "";
                osnova();
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}
