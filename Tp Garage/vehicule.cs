﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    public abstract class vehicule : IComparable<vehicule>
    {
        private static int _id; // Id de la classe
        protected int _vehiculeId;
        protected string _nomVehicule;
        protected string _marqueVehicule;
        protected moteur _moteurvehicule;
        protected List<options> optionsVehicule = new List<options>();
        protected float _prixBrutVehicule;
        protected float _prixNetVehicule;
        protected float _taxe;
        protected float _totalOptions;
        protected string _typeVehicule;

        public int getVehiculeID()
        {
            return _vehiculeId;
        }
            
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
            _vehiculeId = _id;
        }

        public vehicule()
        {
            setInfos();
        }

        protected virtual void setInfos()
        {
            _id++;

            _vehiculeId = _id;
            
            this._typeVehicule = this.GetType().Name;
            Console.WriteLine("Creation d'un(e) nouveau/nouvelle {0}",
                _typeVehicule);
            Console.Write("Saisir nom {0} : ", _typeVehicule);
            _nomVehicule = Console.ReadLine();


            //Marque
            Console.Write("Saisir marque {0} : ", _typeVehicule);
            _marqueVehicule = Console.ReadLine();

            //Moteur
            Console.Write("Moteur : ");
            _moteurvehicule = new moteur();


            //option
            string saisie = inputManager.askYesNo("Voulez-vous ajouter une option ? (y/n) : ");

            if (saisie == "y")
            {
                ajouterOption(inputManager.askInt("Nombre d'options à ajouter : "));
            }

            //Prix Brut
            _prixBrutVehicule = inputManager.askInt("Saisir prix Brut : ");
        }

        public virtual void afficherInfos()
        {
            Console.WriteLine("ID : {0}", _vehiculeId);
            Console.WriteLine("Nom  {0} : {1}", _typeVehicule, _nomVehicule);
            Console.WriteLine("marque {0} : {1}", _typeVehicule, _marqueVehicule);
            Console.WriteLine("Infos Moteur");
            this._moteurvehicule.afficherInfos();

            afficherOptions();

            Console.WriteLine("Prix brut {0} : {1}", _typeVehicule, _prixBrutVehicule);
            Console.WriteLine("Prix total des options " + _totalOptions);
            Console.WriteLine("Taxe appliquee : {0}", _taxe);
            Console.WriteLine("Prix net {0} : {1}", _typeVehicule, _prixNetVehicule);
        }

        protected void ajouterOption()
        {
            optionsVehicule.Add(new options());
        }


        protected void afficherOptions()
        {
            int i = 0;
            foreach (options option in optionsVehicule)
            {
                if (i == 0)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("Infos Options");
                }

                i++;

                Console.WriteLine();
                Console.WriteLine("Option " + i);
                option.afficherInfos();
                if (i == optionsVehicule.Count)
                {
                    Console.WriteLine("---------------");
                }
            }
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
            int prixOptions = 0;
            foreach (options opt in optionsVehicule)
            {
                _totalOptions += opt._prixOption;
            }

            _prixNetVehicule = _prixBrutVehicule + _taxe + _totalOptions;
        }

        protected abstract void calculTaxe();

        public int CompareTo(vehicule other)
        {
            return _prixNetVehicule.CompareTo(other._prixNetVehicule);
        }
    }
}