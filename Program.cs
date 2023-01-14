using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace screens
{
    static class console
    {
        static private int xxx = 0;
        static private int yyy = 0;
        static private int zzz = 0;
        static public void SetCursorPositions(int x, int y)
        {
            xxx = x;
            yyy = y;
            zzz = y * 80 * 2 + x;

        }
        static public void Writeln(string s)
        {
            string ss = s + "\0";
            copyb8000(zzz, ss);
            xxx = 0;
            yyy++;

            if (yyy > 25)
            {
                yyy = 25;
                scrollb8000();
            }
            SetCursorPositions(xxx, yyy);
        }
        static void scrollb8000()
        {
            Console.SetCursorPosition(0, 29);
            Console.WriteLine("");
            Console.SetCursorPosition(xxx, yyy);
        }
        static void copyb8000(Int32 addresss, string s)
        {
            Int32 i = addresss / 2;
            int y = i / 80;
            int x = i - (y * 80);
            if (y < 26)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
        }
    }
    internal class Program
    {

        
        static void mainss() {
            int x = 0;
            int y = 1;
            int n = 0;
            string memory = "hello world...";
           
            console.SetCursorPositions(x, y);
            console.Writeln(memory);
            for (n = 0; n < 24; n++)
            {

                console.Writeln((25 - n).ToString());
                
            }
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
