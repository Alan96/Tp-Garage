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
            vehicule ggre = new voiture();
            ggre.afficherInfos();


            //-----Test options-----
            //options options = new options();


            //----Test camion-----
            camion testCam =  new camion();
            testCam.afficherInfos();
            

            
        }
    }
}