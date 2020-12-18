using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    class Program
    {
        static void Main()
        {

            //-----Test voiture---
            vehicule v1 = new voiture();
            v1.afficherInfos();


            garage ChezBernard = new garage();

            ChezBernard.ajouterVehicule(3);
            
            
            ChezBernard.triVehicules();
            ChezBernard.afficherVehicules();
            

            
        }
    }
}