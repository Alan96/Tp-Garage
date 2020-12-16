using System;
using System.Text.RegularExpressions;

namespace Tp_Garage
{
    class Program
    {
        static void Main()
        {

            //-----Test moteur-----
            // moteur test = new moteur();
            // Console.WriteLine(test._puissance);
            // Console.WriteLine(test._type);
            // Console.ReadKey();

            //-----Test voiture---
            //vehicule v1 = new voiture();
            //vehicule v2 = new voiture();
            
            //v1.afficherInfos();
            //v2.afficherInfos();


            //-----Test options-----
            //options options = new options();


            //----Test camion-----
            //camion testCam = new camion();
            //testCam.afficherInfos();
            

            //----Test moto-----
            //moto testMoto = new moto();
            //testMoto.afficherInfos();

            garage ChezBernard = new garage();

            for (int i = 0; i < 2; i++)
            {
                ChezBernard.ajouterVehicule();
            }

            // ChezBernard.ajouterVehicule(2);
            //ChezBernard.trieVehicule();

            ChezBernard.afficherVehicules();

            
        }
    }
}