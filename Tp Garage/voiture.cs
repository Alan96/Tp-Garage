using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    class voiture : vehicule
    {
        public int _chevaux;
        private int _nbrPorte;
        private int _nbrSieges;
        private float _tailleCoffre;

        protected override void setInfos()
        {
            base.setInfos();

            //chevaux
            _chevaux = this._moteurvehicule._puissance;

            // //Porte
            //_nbrPorte = inputManager.askInt("Saisir nbr Porte : ");

            // //Sieges
            //_nbrSieges = inputManager.askInt("Saisir nbr sieges: ");

            // //Coffre
            //_tailleCoffre = inputManager.askInt("Saisir taille Coffre : ");

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
    }
}