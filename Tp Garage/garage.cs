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
            Console.WriteLine("Ajout d'un nouveau vehicule :");
            outputManager.displaySeparator();
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

        public void afficherVehicules()
        {
            foreach (vehicule vehiculeG in vehiculesGarage)
            {
                outputManager.displaySeparator();
                vehiculeG.afficherInfos();
                outputManager.displaySeparator();
            }
        }
    }
}