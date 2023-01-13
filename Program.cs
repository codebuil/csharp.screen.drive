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
        static void copyb8000(Int32 addresss,string s)
        {
            Int32 i = addresss / 2;
            int y = i / 80;
            int x = i - (y * 80);
            Console.SetCursorPosition(x,y);
            Console.Write(s);
        }
        static void mainss() {
            int x = 0;
            int y = 1;
            string memory = "hello world...";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            copyb8000(y*80*2+x, memory);
        }
        static void Main(string[] args)

        {
            mainss();


            Console.ReadLine();

        }
    }
}
