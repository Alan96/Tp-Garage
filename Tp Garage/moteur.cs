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
            //Nous avons pris quelques libertés pour faire les verifications de saisie a l'aide d'expressions regulieres
            _type = inputManager.askMotorType();
        }


        public void afficherInfos()
        {
            Console.WriteLine("Type de moteur : {0}", _type);
            Console.WriteLine("Puissance : {0}", _puissance);
        }
    }
}