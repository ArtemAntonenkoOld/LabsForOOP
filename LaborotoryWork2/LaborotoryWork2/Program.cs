using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborotoryWork2
{
    class Program
    {
        
        private static void ChangeColor() {
            Console.WriteLine("Input a color please");
            int color = int.Parse(Console.ReadLine());
            Console.BackgroundColor = (ConsoleColor)(color%16);
        }
        private static void CapsLockChecker()
        {
            bool capsValue = Console.CapsLock;
            switch (capsValue)
            {
                case true:
                    Console.WriteLine("CapsLock is pushed");
                    break;
                case false:
                    Console.WriteLine("CapsLock is not pushed");
                    break;
            }
        }
        public static void Main(string[] args)
        {
            bool a = true;
            while (a==true)
            {
                string text = Console.ReadLine().ToLower();
                switch (text)
                {
                    case "changecolor":
                        ChangeColor();
                        break;
                    case "capslockchecker":
                        CapsLockChecker();
                        break;
                    case "exit":
                        a = false;
                        break;
                }
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }

        
    }
}
