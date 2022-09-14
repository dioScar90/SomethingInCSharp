
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
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(0, currentLineCursor);
            Console.Write(new string(' ', Console.WindowWidth-1));
            System.Threading.Thread.Sleep(100); 
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void WriteNow(string bomdia, int sec, bool end)
        {
            for (int i = 0; i < bomdia.Length; i++) {
                if (i == bomdia.Length-1 && end == true)
                    Console.WriteLine(bomdia[i]);
                else
                    Console.Write(bomdia[i]);
                System.Threading.Thread.Sleep(sec);
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
            System.Threading.Thread.Sleep(500);
            WriteNow(bomdia+"!", 25, true);
            WriteNow("Que dia é hoje? ", 25, false);
            string dia = Console.ReadLine();

            if (dia == "13/09/2022") {
                Console.WriteLine();
                WriteNow(loading+"...", 100, false);
                System.Threading.Thread.Sleep(800);
                ClearCurrentConsoleLine();
                System.Threading.Thread.Sleep(100);
                WriteNow(msg, 25, false);
            }
        }
    }
}