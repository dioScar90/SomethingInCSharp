using SomethingInCSharp.Writer;

internal class Program
{
    private static void Main(string[] args)
    {
        string header = "----- Programa de mensagens -----";
        string bomdia = "Bom dia";
        string loading = "Loading";
        string ok = "Ok então...";
        string msg = "" +
            "---------- PARABÉNS :) ----------" +
            "\n" +
            "--- Feliz dia do programador! ---" +
            "\n" +
            "---------------------------------" +
            "\n";

        Writer.WriteNow(header, 25, false);
        Console.WriteLine();

        Console.WriteLine();
        Thread.Sleep(500);
        Writer.WriteNow(bomdia + "!", 40, true);
        Writer.WriteNow("Que dia é hoje? ", 40, false);
        string dia = Console.ReadLine();

        Console.WriteLine();
        Writer.Blinker(loading + "...");
        Thread.Sleep(800);
        Writer.ClearCurrentConsoleLine();
        Thread.Sleep(100);
        if (dia == "13/09/2022")
            Writer.WriteNow(msg, 25, false);
        else
            Writer.WriteNow(ok, 25, false);
    }
}