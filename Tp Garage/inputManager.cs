using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public static class inputManager
    {
        // Classe qui va gerer les inputs et les erreurs des utilisateurs a l'aide d'expressions régulières

        public static int askInt(string message)
        {
            // La saisie doit etre un nombre (et pas plus de 7 chiffres a la suite afin de ne pas depasser la taille d'un int)
            Regex regInt = new Regex("^\\d{1,7}?$");
            string value = "";
            bool firstIteration = true;

            while (regInt.Match(value).Length <= 0)
            {
                if (!firstIteration)
                {
                    outputManager.displayError("Erreur dans le choix !");
                }

                firstIteration = false;
                Console.Write(message);
                value = Console.ReadLine();
            }

            return int.Parse(value);
        }


        public static int testIntTryCatch(string saisie)
        {
            int choix = -1;
            try
            {
                choix = int.Parse(saisie);
            }
            catch (Exception e)
            {
                outputManager.displayError("Veuillez saisir une valeur numérique");
                Console.WriteLine("Test uni, message erreur : {0}", e.Message);
            }
            return choix;
        }


        public static string askMotorType()
        {
            //La saisie doit etre un mot parmi cette liste
            Regex regMotorType = new Regex("^\\b(diesel|essence|electrique|hybride|e|h|d|el)$");
            bool firstIteration = true;
            string value = "";

            while (regMotorType.Match(value.ToLower()).Length <= 0)
            {
                if (!firstIteration)
                {
                    outputManager.displayError("Erreur dans le choix !");
                }

                firstIteration = false;
                Console.WriteLine("Type du moteur :");
                Console.WriteLine("    - Diesel ou d");
                Console.WriteLine("    - Essence ou e");
                Console.WriteLine("    - Hybride ou h");
                Console.WriteLine("    - Electrique ou el");
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


        public static string askAddVehicule()
        {
            // Le chiffre doit être entre 1 et 3
            Regex regInt = new Regex("^[1-3]$");
            bool firstIteration = true;
            string value = "";

            while (regInt.Match(value.ToLower()).Length <= 0)
            {
                if (!firstIteration)
                {
                    outputManager.displayError("Veuillez saisir une des valeurs indiquee !");
                }

                firstIteration = false;
                Console.WriteLine("Quel type de vehicule souhaitez vous ajouter ?");
                Console.WriteLine("    - Voiture : 1");
                Console.WriteLine("    - Camion : 2");
                Console.WriteLine("    - Moto : 3");
                Console.Write("\nVotre choix : ");
                value = Console.ReadLine();
            }

            return value;
        }

        public static string askYesNo(string message)
        {
            // La saisie doit être Y ou N
            Regex regYesNo = new Regex("^\\b(y|n)$");
            bool firstIteration = true;
            string value = "";
            
            while (regYesNo.Match(value.ToLower()).Length <= 0)
            {
                if (!firstIteration)
                {
                    outputManager.displayError("Veuillez saisir Y ou N");
                }

                firstIteration = false;
                Console.Write(message);
                value = Console.ReadLine();
            }

            return value;
            
        }
        

    }
}