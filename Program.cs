using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace screens
{
    internal class Program
    {
        static void scrollb8000()
        {
            Console.SetCursorPosition(0,29);
            Console.WriteLine("");
        }
        static void copyb8000(Int32 addresss,string s)
        {
            Int32 i = addresss / 2;
            int y = i / 80;
            int x = i - (y * 80);
            if (y < 30)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
        }
        static void mainss() {
            int x = 0;
            int y = 1;
            string memory = "hello world...";
            
            copyb8000(y*80*2+x, memory);
            scrollb8000();
        }
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            mainss();


            Console.ReadLine();

        }
    }
}
