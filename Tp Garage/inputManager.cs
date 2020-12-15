using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public static class inputManager
    {
        // Classe qui va gerer les inputs et les erreurs des utilisateurs

        public static int askInt(string message)
        {
            Regex regInt = new Regex("^[0-9]+$");
            string value = "";
            bool firstIteration = true;

            while (regInt.Match(value).Length <= 0)
            {
                if (!firstIteration)
                {
                    displayError("Erreur dans le choix !");
                }

                firstIteration = false;
                Console.Write(message);
                value = Console.ReadLine();
            }

            return int.Parse(value);
        }

        public static void displayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}