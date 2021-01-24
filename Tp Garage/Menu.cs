using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    class Menu
    {
        private garage _garage;
        private string path = "C:/Users/mancu/OneDrive - Campus Rene Cassin/EPSI/B2/Langage C#/Tp Garage/Tp Garage/saveFic.bin";

        public Menu(garage Speedy)
        {
            _garage = Speedy;
           _garage.vehiculesGarage = _garage.charger<List<vehicule>>(path);
            Start();
        }

        public void Start()
        {
            int saisie = -1;
            while (saisie != 0)
            {
                outputManager.displaySeparator();
                Console.WriteLine("Menu Garage");
                outputManager.displaySeparator();

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

                try
                {
                    saisie = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Saisir une des valeurs ci-dessus");
                }


                switch (saisie)
                {
                    case 1:
                        _garage.afficherVehicules();
                        break;
                    case 2:
                        _garage.ajouterVehicule();
                        break;
                    case 3:
                        _garage.supprimerVehicule();
                        break;
                    case 4:
                        _garage.choisirVehicule();
                        break;
                    case 5:
                        _garage.afficherOptionVehicule();
                        break;
                    case 6:
                        _garage.choisirVehicule().ajouterOption();
                        break;
                    case 7:
                        _garage.choisirVehicule().supprimerOption();
                        break;
                    case 8:
                        _garage.afficherListeOpt();
                        break;
                    case 9:
                        _garage.afficherListeMarque();
                        break;
                    case 10:
                        _garage.afficherListeMoteur();
                        break;
                    case 11:
                        _garage.enregistrer(_garage, path);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
