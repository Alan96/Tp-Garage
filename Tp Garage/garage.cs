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
            Console.WriteLine("Ajout d'un nouveau vehicule :");
            separator();
            string saisie = "";
            while (!(saisie == "1" || saisie == "2"|| saisie == "3"))
            {
                Console.WriteLine("Quel type de vehicule souhaitez vous ajouter ?");
                Console.WriteLine("Voiture = 1");
                Console.WriteLine("Camion = 2");
                Console.WriteLine("Moto = 3");
                saisie = Console.ReadLine();
                if (!(saisie == "1" || saisie == "2" || saisie == "3"))
                {
                    inputManager.displayError("Veuillez saisir une des valeurs indiquee !");
                }
            }
            separator();
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
            foreach(vehicule vehiculeG in vehiculesGarage)
            {
                separator();
                vehiculeG.afficherInfos();
                separator();
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

        private void separator()
        {
            Console.WriteLine("=======================================================");
        }
    }
}