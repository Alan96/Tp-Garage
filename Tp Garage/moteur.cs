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

        private void setMoteur()
        {
            string saisie = "";
            while (_puissance <= 0)
            {
                Console.WriteLine("Indiquez la puissance en chevaux du Moteur");
                saisie = Console.ReadLine();
                try
                {
                    _puissance = int.Parse(saisie);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Test uni, message erreur : {0}", e.Message);
                }
            }

            while (!(saisie == "diesel" || saisie == "essence" || saisie == "hybride" || saisie == "electrique"))
            {
                Console.WriteLine("Indiquez le type du Moteur");
                Console.WriteLine("d ou diesel");
                Console.WriteLine("e ou essence");
                Console.WriteLine("h ou hybride");
                Console.WriteLine("el ou electique");

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
                    Console.WriteLine("Veuillez saisir une des valeurs indiquee");
                }

            }

            _type = saisie;
        }
    }
}
