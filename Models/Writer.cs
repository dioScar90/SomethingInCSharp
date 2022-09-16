using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingInCSharp.Writer
{
    public class Writer
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Thread.Sleep(100);
            Console.SetCursorPosition(0, currentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth-1));
            Thread.Sleep(100); 
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void WriteNow(string bomdia, int sec, bool end)
        {
            for (int i = 0; i < bomdia.Length; i++)
            {
                if (i == bomdia.Length-1 && end == true)
                    Console.WriteLine(bomdia[i]);
                else
                    Console.Write(bomdia[i]);
                Thread.Sleep(sec);
            }
        }
        public static void Blinker(string text)
        {
            int currentLineCursor = Console.CursorTop;
            
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                ClearCurrentConsoleLine();
                WriteNow(text, 50, false);
            }
        }
    }
}