using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    class voiture : vehicule, IComparable
    {
        public int _chevaux;
        private int _nbrPorte;
        private int _nbrSieges;
        private float _tailleCoffre;

        protected override void setInfos()
        {
            base.setInfos();

            //chevaux
            // Console.Write("Saisir nbr Chevaux fiscaux : ");
            //  _chevaux = int.Parse(Console.ReadLine());
            _chevaux = this._moteurvehicule._puissance;
            
           // //Porte
           //// Console.Write("Saisir nbr Porte : ");
           //// _nbrPorte = int.Parse(Console.ReadLine());
           // _nbrPorte = inputManager.askInt("Saisir nbr Porte : ");

           // //Sieges
           //// Console.Write("Saisir nbr  : ");
           //// _nbrSieges = int.Parse(Console.ReadLine());
           // _nbrSieges = inputManager.askInt("Saisir nbr sieges: ");

           // //Coffre
           // //Console.Write("Saisir taille Coffre : ");
           // //_tailleCoffre = int.Parse(Console.ReadLine());
           // _tailleCoffre = inputManager.askInt("Saisir taille Coffre : ");
            
            
            calculTaxe();
        }

        public override void afficherInfos()
        {
            base.afficherInfos();
            Console.WriteLine("Chevaux {0} : {1}", _typeVehicule, _chevaux);
            Console.WriteLine("Nbr Portes : {0}", _nbrPorte);
            Console.WriteLine("Nbr Sieges : {0}", _nbrSieges);
            Console.WriteLine("Taille du coffre : {0}", _tailleCoffre);
        }
        

        protected override void calculTaxe()
        {
            _taxe = _moteurvehicule._puissance * 10;
            setPrixNet();
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null) return 1;
            voiture newVec = obj as voiture;
            return this._chevaux.CompareTo(newVec._chevaux);

        }
    }
}
