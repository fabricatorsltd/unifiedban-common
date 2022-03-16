using System;

namespace Unifiedban.Next.Common
{
    public class Utils
    {
        public static void WriteLine(string? message, int severity = 1)
        {
            Console.Write("{0} ", DateTime.UtcNow);

            var prefix = "[info]";

            switch (severity)
            {
                case -1:
                    prefix = "[trace]";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 0:
                    prefix = "[debug]";
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    prefix = "[warn]";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 3:
                    prefix = "[error]";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    prefix = "[fatal]";
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    prefix = "[info]";
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.Write(prefix);
            Console.ResetColor();
            Console.Write(" - {0}", message);
            Console.Write(Environment.NewLine);
        }
    }
}