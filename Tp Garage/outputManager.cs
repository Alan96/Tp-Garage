using System;

namespace Tp_Garage
{
    public static class outputManager
    {
        public static void displaySeparator()
        {
            Console.WriteLine("=======================================================");
        }

        public static void coloredMessage(string message, ConsoleColor color, bool inline)
        {
            Console.ForegroundColor = color;
            if (inline)
            {
                Console.Write(message);
            }
            else
            {
                Console.WriteLine(message);
            }

            Console.ResetColor();
        }

        public static void displayError(string message)
        {

            coloredMessage("\n" + message + "\n", ConsoleColor.Red, false);
        }


    }
}