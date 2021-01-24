using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    [Serializable]

    class camion : vehicule
    {

        private int _nbrEssieux;
        private int _poidChargement;
        private int _volumeChargement;
        
        protected override void setInfos()
        {
            base.setInfos();

            //Essieux
            _nbrEssieux = inputManager.askInt("Saisir nbr essieux : ");

            //Poid chargement
            _poidChargement = inputManager.askInt("Saisir poid chargement : ");

            //Volume chargement
            _volumeChargement = inputManager.askInt("Saisir volume chargement : ");

            calculTaxe();
            setPrixNet();
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
        }
        
    }
}