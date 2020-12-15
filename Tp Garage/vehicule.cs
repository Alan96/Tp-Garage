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

        public vehicule(string nomVehicule, string marqueVehicule, float prixBrutVehicule, float prixNetVehicule, float taxe)
        {
            _nomVehicule = nomVehicule;
            _marqueVehicule = marqueVehicule;
            _moteurvehicule = new moteur();
            _prixBrutVehicule = prixBrutVehicule;
            _prixNetVehicule = prixNetVehicule;
            _taxe = taxe;
            _id++;
        }

        public vehicule()
        {
            setInfos();
        }

        protected virtual void setInfos()
        {
            string saisie;
            // Trouver facon de recuper automatiquement le nom de la classe
            Console.WriteLine("Saisir nom vehicule");
            _nomVehicule = Console.ReadLine();


            //Marque
            Console.WriteLine("Saisir marque vehicule");
            _marqueVehicule = Console.ReadLine();
            
            //Moteur
            Console.WriteLine("Moteur :");
            _moteurvehicule = new moteur();

            //option
            Console.WriteLine("Ajouter option");


            Console.WriteLine("Saisir prix Brut du vehicule");
            saisie = Console.ReadLine();
            _prixBrutVehicule = int.Parse(saisie);
           // calculTaxe();
           // setPrixNet();

        }

        public virtual void afficherInfos()
        {
            Console.WriteLine("Nom vehicule {0}", _nomVehicule);
            Console.WriteLine("marque vehicule {0}", _marqueVehicule);
            Console.WriteLine("Infos Moteur");
            this._moteurvehicule.afficherInfos();
            Console.WriteLine("Infos Options");

            foreach (options option in optionsVehicule)
            {
                option.afficherInfos();
            }

            Console.WriteLine("Prix brut vehicule {0}", _prixBrutVehicule);
            Console.WriteLine("Taxe appliquee : {0}", _taxe);
            Console.WriteLine("Prix net vehicule {0}", _prixNetVehicule);
        }

     //   protected virtual moteur GetMoteur() { }
        public float getPrixNet()
        {
            return _prixNetVehicule;

        }
        public float getPrixBrut()
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
            _prixNetVehicule = _prixBrutVehicule + _taxe;
        }

       protected abstract void calculTaxe();

    }
}
