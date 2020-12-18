using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public class garage
    {
        public List<vehicule> vehiculesGarage = new List<vehicule>();


        public void ajouterVehicule()
        {

                string saisie = inputManager.askAddVehicule();
                outputManager.displaySeparator();
                switch (saisie)
                {
                    case "1":
                        vehiculesGarage.Add(new voiture());
                        break;
                    case "2":
                        vehiculesGarage.Add(new camion());
                        break;
                    case "3":
                        vehiculesGarage.Add(new moto());

                        break;
                    default:
                        break;
                }
            
        }

        public void ajouterVehicule(int nbVehicule)
        {
            for (int i = 0; i < nbVehicule; i++)
            {
                string saisie = inputManager.askAddVehicule();
                outputManager.displaySeparator();
                switch (saisie)
                {
                    case "1":
                        vehiculesGarage.Add(new voiture());
                        break;
                    case "2":
                        vehiculesGarage.Add(new camion());
                        break;
                    case "3":
                        vehiculesGarage.Add(new moto());

                        break;
                    default:
                        break;
                }

            }
        }

        public void afficherVehicules()
        {
            foreach (vehicule vehiculeG in vehiculesGarage)
            {
                outputManager.displaySeparator();
                vehiculeG.afficherInfos();
                outputManager.displaySeparator();
            }
        }

        public void triVehicules()
        {
            outputManager.displaySeparator();
            Console.WriteLine("Tri des vehicules en cours");
            outputManager.displaySeparator();
            vehiculesGarage.Sort(); // Va directement chercher la fonction CompareTo() pour savoir comment trier
        }

        public vehicule choisirVehicule()
        {
            string saisie;
            int choix = -1;
            if (vehiculesGarage.Count > 1)
            {


                while (choix < 0 || choix > vehiculesGarage.Count)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Saisir L'ID ou le nom du vehicule");
                    Console.WriteLine("La saisie doit être comprise entre 1 et " + vehiculesGarage.Count);
                    outputManager.displayError("Si vous souhaitez revoir la liste des vehicules tapez Y");

                    saisie = Console.ReadLine();

                    if (saisie == "y")
                    {
                        afficherVehicules();
                    }
                    else
                    {
                        choix = inputManager.testIntTryCatch(saisie);
                    }
                }

                foreach (vehicule v in vehiculesGarage)
                {
                    if (v.getVehiculeID() == choix)
                    {
                        return v;
                    }
                }
            }

            return vehiculesGarage[0];
        }

        public void supprimerVehicule()
        {
            vehicule vehiculeASuppr = choisirVehicule();
            Console.WriteLine("Le Vehicule {0} a bien ete supprime !", vehiculeASuppr.getVehiculeID());

            vehiculesGarage.Remove(vehiculeASuppr);
        }

        public void afficherOptionVehicule()
        {
            vehicule v = choisirVehicule();
            Console.WriteLine("Option du Vehicule {0} : ", v.getVehiculeID());
            v.afficherOptions();
        }

        public void ajouterOptionVehicule()
        {
            vehicule v = choisirVehicule();
            Console.WriteLine("Ajout d'options au Vehicule {0} : ", v.getVehiculeID());
            v.ajouterOption(inputManager.askInt("Nombre d'options à ajouter : "));

        }
    }
}