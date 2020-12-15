using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    public abstract class vehicule
    {
        protected static int _id;
        protected string _nomVehicule;
        protected string _marqueVehicule;
        protected moteur _moteurvehicule;
        protected List<options> optionsVehicule = new List<options>();
        protected float _prixBrutVehicule;
        protected float _prixNetVehicule;
        protected float _taxe;

        protected vehicule(string nomVehicule, string marqueVehicule, float prixBrutVehicule, float prixNetVehicule, float taxe)
        {
            _nomVehicule = nomVehicule;
            _marqueVehicule = marqueVehicule;
            _moteurvehicule = new moteur();
            _prixBrutVehicule = prixBrutVehicule;
            _prixNetVehicule = prixNetVehicule;
            _taxe = taxe;
            _id++;
        }

        protected virtual void setInfos()
        {
            string saisie;
            // Trouver facon de recuper automatiquement le nom de la classe
            Console.WriteLine("Saisir nom vehicule");
            _nomVehicule = Console.ReadLine();
            Console.WriteLine("Saisir marque vehicule");
            _marqueVehicule = Console.ReadLine();
            Console.WriteLine("Saisir prix Brut du vehicule");
            saisie = Console.ReadLine();
            _prixBrutVehicule = int.Parse(saisie);
            calculTaxe();
            setPrixNet();



        }

        protected abstract moteur GetMoteur();
        protected float getPrixNet()
        {
            return _prixNetVehicule;

        }
        protected float getPrixBrut()
        {
            return _prixBrutVehicule;
        }

        protected void ajouterOption()
        {
            optionsVehicule.Add(new options());
        }

        protected void ajouterOption(int plusieursOptions)
        {
            for (int i = 0; i < plusieursOptions; i++)
            {
                optionsVehicule.Add(new options());

            }
        }

        protected void setPrixNet()
        {
            _prixNetVehicule = (_prixBrutVehicule * _taxe) / 100;
        }
        protected abstract void calculTaxe();

    }
}
