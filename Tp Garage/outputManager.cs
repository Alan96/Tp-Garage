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

        public static void Menu(garage _garage)
        {
            string saisie;
            int choix = 0;
            while (choix != 0)
            {
                Console.WriteLine("1 - Afficher les véhicules");
                Console.WriteLine("2 - Ajouter un véhicule");
                Console.WriteLine("3 - Supprimer un véhicule");
                Console.WriteLine("4 - Sélectionner un véhicule");
                Console.WriteLine("5 - Afficher les options d'un véhicule");
                Console.WriteLine("6 - Ajouter des options à un véhicule");
                Console.WriteLine("7 - Supprimer des options à un véhicule");
                Console.WriteLine("8 - Afficher les options");
                Console.WriteLine("9 - Afficher les marques");
                Console.WriteLine("10 - Afficher les types de moteurs");
                Console.WriteLine("11 - Sauvegarder le garage");
                Console.WriteLine("0 - Quitter l'application ");

                saisie = Console.ReadLine();


                //switch (choix)
                //{
                //    case 1:
                //        _garage.afficherVehicules();
                //        break;
                //    case 2:
                //        _garage.ajouterVehicule();
                //        break;
                //    case 3:
                //        _garage.supprimerVehicule();
                //    case 4:
                //        _garage.a
                //    default:
                //        break;
                //}
            }
        }





    }
}