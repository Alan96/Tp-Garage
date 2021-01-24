using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tp_Garage
{
    public class garage
    {
        public List<vehicule> vehiculesGarage = new List<vehicule>();
        private List<moteur> listeMoteurs = new List<moteur>();
        private List<options> listeOptions = new List<options>();
        private List<string> listeMarques = new List<string>();

        public garage()
        {

            moteur incrMoteur;
            listeMoteurs.Add(incrMoteur = new moteur(60, "d"));
            listeMoteurs.Add(incrMoteur = new moteur(70, "e"));
            listeMoteurs.Add(incrMoteur = new moteur(50, "el"));
            listeMoteurs.Add(incrMoteur = new moteur(65, "h"));
            //liste options
            options incrOption;
            listeOptions.Add(incrOption = new options("climatiseur", 100));
            listeOptions.Add(incrOption = new options("porte-velo", 150));
            listeOptions.Add(incrOption = new options("camera recul", 300));
            listeOptions.Add(incrOption = new options("interieur cuir", 500));
            //liste marque
            listeMarques.Add("ferrari");
            listeMarques.Add("audi");
            listeMarques.Add("smart");
            listeMarques.Add("citroen");


            //Faire fonctions affichage listes + ajouts objets
            //Faire une liste de marques strings

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
            if(vehiculesGarage.Count > 0)
            {
                foreach (vehicule vehiculeG in vehiculesGarage)
                {
                    outputManager.displaySeparator();
                    vehiculeG.afficherInfos();
                    outputManager.displaySeparator();
                }
            }
            else
            {
                Console.WriteLine("Garage vide");
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

        public void afficherListeMoteur()
        {
            addListeItem();
            outputManager.displaySeparator();
            Console.WriteLine("Moteurs disponibles :");
            for (int i = 0; i < listeMoteurs.Count; i++)
            {
                Console.WriteLine("Moteur {0} : {1} de {2} chevaux", i + 1, listeMoteurs[i]._type, listeMoteurs[i]._puissance);
            }
            outputManager.displaySeparator();
        }

        public void afficherListeOpt()
        {
            addListeItem();
            outputManager.displaySeparator();
            Console.WriteLine("Options disponibles :");
            for (int i = 0; i < listeOptions.Count; i++)
            {
                Console.WriteLine("Option {0} : {1}", i + 1, listeOptions[i]._nomOption);
            }
            outputManager.displaySeparator();
        }

        private void addListeItem()
        {
            foreach (vehicule v in vehiculesGarage)
            {
                for (int i = 0; i < listeMoteurs.Count; i++)
                {
                    if (v.Marque() == listeMarques[i])
                    {
                        listeMarques.Add(v.Marque());
                    }

                    if (v.Moteur().GetType().Equals(listeMoteurs[i].GetType()))
                    {
                        listeMoteurs.Add(v.Moteur());

                    }
                }

            }
        }

        public void afficherListeMarque()
        {
            outputManager.displaySeparator();
            Console.WriteLine("Marques disponibles :");
            for (int i = 0; i < listeMarques.Count; i++)
            {
                Console.WriteLine("Marque {0} : {1}", i + 1, listeMarques[i]);
            }
            outputManager.displaySeparator();
        }

        public void enregistrer(object toSave, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream flux = null; 
            try
            {
                flux = new FileStream(path, FileMode.Create, FileAccess.Write);
                formatter.Serialize(flux, toSave);
                flux.Flush();
            }
            catch
            {

            }
            finally
            {
                if (flux != null)
                    flux.Close();
            }
        }

        public T charger<T>(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter(); 
            FileStream flux = null;

            try
            {
                flux = new FileStream(path, FileMode.Open, FileAccess.Read); 
                return (T)formatter.Deserialize(flux);
            }
            catch
            {

                return default(T);
            }
            finally
            {
                if (flux!=null)
                {
                    flux.Close();
                }

            }
        }
    }
}