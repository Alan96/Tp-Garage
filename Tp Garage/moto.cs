﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Garage
{
    [Serializable]

    class moto : vehicule
    {

        private int _cylindre;


        protected override void setInfos()
        {
            base.setInfos();
            _cylindre = _moteurvehicule._puissance;
            calculTaxe();
            setPrixNet();
        }

        public override void afficherInfos()
        {
            base.afficherInfos();
            Console.WriteLine("Cylindree de la {0} : {1}", _typeVehicule, _cylindre);
        }

        protected override void calculTaxe()
        {
            _taxe = (int) Math.Round(_cylindre * 0.3f);
        }


    }
}
