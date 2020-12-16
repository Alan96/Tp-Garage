using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public class garage
    {
        public List<vehicule> vehiculesGarage = new List<vehicule>();

        public void ajouterVehicule(int nbVehicule = 1)
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

        public void trieVehicule()
        {
            vehiculesGarage.Sort(); // Va directement chercher la fonction CompareTo() pour savoir comment trier
        }
    }
}