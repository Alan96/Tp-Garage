using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public class garage
    {
        public List<vehicule> vehiculesGarage = new List<vehicule>();

        public void ajouterVehicule(int test)
        {
        }

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

        public void afficherVehicules()
        {
            foreach (vehicule vehiculeG in vehiculesGarage)
            {
                outputManager.displaySeparator();
                vehiculeG.afficherInfos();
                outputManager.displaySeparator();
            }
        }

        //Test de trie avec compare to mais je comprends rien a leur fonction
        //public void trieVehicule()
        //{
        //    foreach (vehicule vehiculeG in vehiculesGarage)
        //    {
        //        foreach (vehicule test in vehiculesGarage)
        //        {
        //            voiture v = vehiculeG as voiture;
        //            if (v != vehiculeG)
        //            {
        //                if (v._chevaux.CompareTo(vehiculeG) != 1)
        //                {
        //                    int swap;
        //                    swap = vehiculesGarage.IndexOf(v);
        //                    vehiculesGarage.IndexOf(v) = vehiculesGarage.FindIndex(test);

        //                }
        //            }
        //        }

        //    }

        //}
    }
}