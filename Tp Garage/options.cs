using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    [Serializable]

    public class options
    {

        public string _nomOption;
        public int _prixOption;

        public options()
        {
            setOption();
        }

        public options(string nom, int prix)
        {
            _nomOption = nom;
            _prixOption = prix;
        }

        private void setOption()
        {
            Console.Write("Saisir nom de l'option : ");
            _nomOption = Console.ReadLine();
            _prixOption = inputManager.askInt("Saisir prix de l'option : ");
        }

        public void afficherInfos()
        {
            Console.WriteLine("Nom de l'option : {0}", _nomOption);
            Console.WriteLine("Prix de l'option : {0}", _prixOption);         
        }

    }
}
