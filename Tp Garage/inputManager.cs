using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public static class inputManager
    {
        // Classe qui va gerer les inputs et les erreurs des utilisateurs

        public static int askInt(string message)
        {
            Regex regInt = new Regex("^\\d+$");
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


        public static string askMotorType()
        {
            Regex regMotorType = new Regex("^\\b(diesel|essence|electrique|hybride|e|h|d|el)$");
            bool firstIteration = true;
            string value = "";

            while (regMotorType.Match(value.ToLower()).Length <= 0)
            {
                if (!firstIteration)
                {
                    displayError("Erreur dans le choix !");
                }

                firstIteration = false;
                Console.WriteLine("Type du moteur :");
                Console.WriteLine("- Diesel ou e");
                Console.WriteLine("- Essence ou e");
                Console.WriteLine("- Hybride ou h");
                Console.WriteLine("- Electrique ou el");
                Console.Write("\nVotre choix : ");
                value = Console.ReadLine();
            }

            switch (value)
            {
                case "e":
                    value = "essence";
                    break;
                case "el":
                    value = "electrique";
                    break;
                case "d":
                    value = "diesel";
                    break;
                case "h":
                    value = "hybride";
                    break;
            }

            return value.ToLower();
        }

        public static void displayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}