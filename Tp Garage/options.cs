﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
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
            Console.WriteLine("Saisir nom de l'option");
            _nomOption = Console.ReadLine();
            Console.WriteLine("Saisir prix de l'option");
            _prixOption = int.Parse(Console.ReadLine());
        }

        private void afficherInfos()
        {
            Console.WriteLine("Nom de l'option : {0}", _nomOption);
            Console.WriteLine("Prix de l'option : {0}", _prixOption);         
        }

    }
}
