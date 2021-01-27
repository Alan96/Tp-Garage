using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Tp_Garage
{
    public class Menu
    {
        private garage _garage;
        private string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\saveFic.bin";
        public vehicule vehiculeSelected;

        public Menu(garage Speedy)
        {
            _garage = Speedy;

            garage tempGarage = _garage.charger<garage>(path);
            //_garage.vehiculesGarage = _garage.charger<List<vehicule>>(path);
            _garage.vehiculesGarage = tempGarage.vehiculesGarage;

            if (_garage.vehiculesGarage == null) //Empeche d'avoir un garage egal a null
            {
                _garage.vehiculesGarage = new List<vehicule>();
            }
            else
            {
                for (int i = 0; i < _garage.vehiculesGarage.Count; i++) // Réecrit les IDs pour ne pas avoir de doublons
                {
                    _garage.vehiculesGarage[i].VehiculeId = i + 1;
                    vehicule.Id = i + 1;
                }
            }

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

                        if (vehiculeSelected != null)
                        {
                            _garage.supprimerVehicule(this.vehiculeSelected);
                        }
                        else
                        {
                            outputManager.displayError("Pas de vehicule selectionne");
                        }

                        break;
                    case 4:
                        this.vehiculeSelected = _garage.choisirVehicule(this);
                        break;
                    case 5:

                        if (vehiculeSelected != null)
                        {
                            _garage.afficherOptionVehicule(this.vehiculeSelected);
                        }
                        else
                        {
                            outputManager.displayError("Pas de vehicule selectionne");
                        }

                        break;
                    case 6:
                        if (vehiculeSelected != null)
                        {
                            this.vehiculeSelected.ajouterOption();
                        }
                        else
                        {
                            outputManager.displayError("Pas de vehicule selectionne");
                        }

                        break;
                    case 7:
                        if (vehiculeSelected != null)
                        {
                            this.vehiculeSelected.supprimerOption();
                        }
                        else
                        {
                            outputManager.displayError("Pas de vehicule selectionne");
                        }

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