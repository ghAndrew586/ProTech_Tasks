using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            
            string inputLine = Console.ReadLine();

            while (!Regex.IsMatch(inputLine, "^[a-zA-Z]+$"))
            {
                Console.WriteLine("В строке должны быть только латинские буквы!");
                inputLine = Console.ReadLine();
            }

            char[] mainLine = inputLine.ToCharArray();

            Console.Write("Выход: ");
            if (mainLine.Length % 2 != 0)
            {
                string unrevLine = new string(mainLine);
                Array.Reverse(mainLine);
                Console.Write(mainLine); Console.WriteLine(unrevLine);
            }
            else
            {
                Array.Reverse(mainLine);
                var lastSegment = new ArraySegment<char>(mainLine, 0, mainLine.Length / 2);
                var firstSegment = new ArraySegment<char>(mainLine, mainLine.Length / 2, mainLine.Length / 2);
                Console.Write(String.Join("", firstSegment)); Console.WriteLine(String.Join("", lastSegment));
            }

            Console.Write(" . . . Нажмите любую кнопку, чтобы выйти; Enter, чтобы перезапустить  . . . ");
            char endKey = Console.ReadKey().KeyChar;

            if (endKey == '\r')
            {
                System.Diagnostics.Process.Start(Assembly.GetExecutingAssembly().Location);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
