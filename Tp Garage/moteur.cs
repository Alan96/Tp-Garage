using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    public class moteur
    {
        public int _puissance = 0;
        public string _type;

        public moteur()
        {
            setMoteur();
        }

        public moteur(int puissance, string type)
        {
            _puissance = puissance;
            _type = type;
        }

        private void setMoteur()
        {
            string saisie = "";
            
            _puissance = inputManager.askInt("Indiquez la puissance du Moteur : ");
            
            while (!(saisie == "diesel" || saisie == "essence" || saisie == "hybride" || saisie == "electrique"))
            {
                Console.WriteLine("Indiquez le type du Moteur");
                Console.WriteLine("d ou diesel");
                Console.WriteLine("e ou essence");
                Console.WriteLine("h ou hybride");
                Console.WriteLine("el ou electique");
                Console.Write("\nVotre choix : ");

                saisie = Console.ReadLine();

                if (saisie == "e")
                {
                    saisie = "essence";
                }
                else if (saisie == "d")
                {
                    saisie = "diesel";
                }
                else if (saisie == "h")
                {
                    saisie = "hybride";
                }
                else if (saisie == "el")
                {
                    saisie = "electrique";
                }

                if (!(saisie == "diesel" || saisie == "essence" || saisie == "hybride" || saisie == "electrique"))
                {
                    inputManager.displayError("Veuillez saisir une des valeurs indiquee !");
                }
            }

            _type = saisie;
        }


        public void afficherInfos()
        {
            Console.WriteLine("Type de moteur : {0}", _type);
            Console.WriteLine("Puissance en chevaux : {0}", _puissance);
        }
    }
}