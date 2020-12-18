using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    class Program
    {
        static void Main()
        {

            //-----Test voiture---
            //vehicule v1 = new voiture();
            //v1.afficherInfos();


            garage ChezBernard = new garage();

            ChezBernard.ajouterVehicule(2);
            
            
            ChezBernard.triVehicules();
            ChezBernard.afficherVehicules();


            ChezBernard.supprimerVehicule();
            Console.WriteLine();
            Console.WriteLine();
            ChezBernard.supprimerVehicule();

            Console.WriteLine();
            Console.WriteLine();

            ChezBernard.afficherVehicules();
            

            
        }
    }
}