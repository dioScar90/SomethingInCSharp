
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingInCSharp
{
    public class Program
    {
        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Thread.Sleep(100);
            Console.SetCursorPosition(0, currentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth-1));
            Thread.Sleep(100); 
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void WriteNow(string bomdia, int sec, bool end)
        {
            for (int i = 0; i < bomdia.Length; i++) {
                if (i == bomdia.Length-1 && end == true)
                    Console.WriteLine(bomdia[i]);
                else
                    Console.Write(bomdia[i]);
                Thread.Sleep(sec);
            }
        }
        static void Blinker(string text)
        {
            int currentLineCursor = Console.CursorTop;
            
            for (int i = 0; i < 3; i++) {
                Console.SetCursorPosition(0, currentLineCursor);
                ClearCurrentConsoleLine();
                WriteNow(text, 50, false);
            }
        }

        public static void Main(string[] args)
        {
            string header = "----- Programa de mensagens -----";
            string bomdia = "Bom dia";
            string loading = "Loading";
            string msg = ""+
                "---------- PARABÉNS :) ----------"+
                "\n"+
                "--- Feliz dia do programador! ---"+
                "\n"+
                "---------------------------------"+
                "\n";

            WriteNow(header, 25, false);
            Console.WriteLine();

            Console.WriteLine();
            Thread.Sleep(500);
            WriteNow(bomdia+"!", 40, true);
            WriteNow("Que dia é hoje? ", 40, false);
            string dia = Console.ReadLine();

            if (dia == "13/09/2022") {
                Console.WriteLine();
                Blinker(loading+"...");
                Thread.Sleep(800);
                ClearCurrentConsoleLine();
                Thread.Sleep(100);
                WriteNow(msg, 25, false);
            }
        }
    }
}