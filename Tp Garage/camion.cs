using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    class camion : vehicule
    {
        private int _nbrEssieux;
        private int _poidChargement;
        private int _volumeChargement;


        protected override void setInfos()
        {
            base.setInfos();

            //Essieux
            //Console.Write("Saisir nbr essieux : ");
            //_nbrEssieux = int.Parse(Console.ReadLine());
            _nbrEssieux = inputManager.askInt("Saisir nbr essieux : ");

            //Poid chargement
           // Console.Write("Saisir poid chargement : ");
            //_poidChargement = int.Parse(Console.ReadLine());
            _poidChargement = inputManager.askInt("Saisir poid chargement : ");

            //Volume chargement
            //Console.Write("Saisir volume chargement : ");
            //_volumeChargement = int.Parse(Console.ReadLine());
            _volumeChargement = inputManager.askInt("Saisir volume chargement : ");

            calculTaxe();
        }


        public override void afficherInfos()
        {
            base.afficherInfos();
            Console.WriteLine("Nbr essieux {0}", _nbrEssieux);
            Console.WriteLine("Poid chargement : {0}", _poidChargement);
            Console.WriteLine("Volume chargement : {0}", _volumeChargement);
        }


        protected override void calculTaxe()
        {
            _taxe = _nbrEssieux * 50;
            setPrixNet();
        }

        // protected override moteur GetMoteur()
        // {
        //     throw new NotImplementedException();
        // }
//
        // protected override float getPrixBrut()
        // {
        //     throw new NotImplementedException();
        // }
//
        // protected override float getPrixNet()
        // {
        //     throw new NotImplementedException();
        // }
    }
}