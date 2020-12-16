using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
        protected string _typeVehicule;

        public vehicule(string nomVehicule, string marqueVehicule, float prixBrutVehicule, float prixNetVehicule,
            float taxe)
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
            _id++;
            // Trouver facon de recuper automatiquement le nom de la classe
            this._typeVehicule = this.GetType().Name;
            Console.WriteLine("Creation d'un(e) nouveau/nouvelle {0}", _typeVehicule);  // Recupere automatiquement le nom de la classe comme tu le voulais mon cochon
            Console.Write("Saisir nom {0} :", _typeVehicule);
            _nomVehicule = Console.ReadLine();


            //Marque
             Console.Write("Saisir marque {0} :", _typeVehicule);
            _marqueVehicule = Console.ReadLine();

            //Moteur
            Console.Write("Moteur : ");
            _moteurvehicule = new moteur();


            //option
            Console.Write("Ajouter option : ");


            //Console.Write("Saisir prix Brut du vehicule : ");
            //saisie = Console.ReadLine();
            //_prixBrutVehicule = int.Parse(saisie);
            _prixBrutVehicule = inputManager.askInt("Saisir prix Brut : ");

            // calculTaxe();
            // setPrixNet();
        }

        public virtual void afficherInfos()
        {
            Console.WriteLine("ID : {0}", _id);
            Console.WriteLine("Nom  {0} : {1}", _typeVehicule, _nomVehicule);
            Console.WriteLine("marque {0} : {1}", _typeVehicule, _marqueVehicule);
            Console.WriteLine("Infos Moteur");
            this._moteurvehicule.afficherInfos();
            Console.WriteLine("Infos Options");

            foreach (options option in optionsVehicule)
            {
                option.afficherInfos();
            }

            Console.WriteLine("Prix brut {0} : {1}", _typeVehicule, _prixBrutVehicule);
            Console.WriteLine("Taxe appliquee : {0}", _taxe);
            Console.WriteLine("Prix net {0} : {1}", _typeVehicule, _prixNetVehicule);
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


        static void checkInt(int value)
        {
        }

        protected abstract void calculTaxe();
    }
}