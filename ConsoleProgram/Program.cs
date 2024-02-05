using System;
using System.Reflection;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            char[] mainLine = Console.ReadLine().ToCharArray();

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

            Console.Write(" . . . Нажмите любую кнопку, чтобы выйти; Space, чтобы перезапустить  . . . ");
            char endKey = Console.ReadKey().KeyChar;

            if (endKey == ' ')
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
