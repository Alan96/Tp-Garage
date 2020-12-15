using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    class voiture : vehicule
    {
        private int _chevaux;
        private int _nbrPorte;
        private int _nbrSieges;
        private float _tailleCoffre;

        protected override void setInfos()
        {
            base.setInfos();

            //chevaux
            Console.Write("Saisir nbr Chevaux fiscaux : ");
            _chevaux = int.Parse(Console.ReadLine());
            
            //Porte
            Console.Write("Saisir nbr Porte : ");
            _nbrPorte = int.Parse(Console.ReadLine());

            //Sieges
            Console.Write("Saisir nbr  : ");
            _nbrSieges = int.Parse(Console.ReadLine());

            //Coffre
            Console.Write("Saisir taille Coffre : ");
            _tailleCoffre = int.Parse(Console.ReadLine());
            calculTaxe();
        }

        public override void afficherInfos()
        {
            base.afficherInfos();
            Console.WriteLine("Chevaux vehicule {0}", _chevaux);
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
