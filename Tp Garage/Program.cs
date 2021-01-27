using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Tp_Garage
{
    class Program
    {
        static void Main()
        {


            String test = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Console.WriteLine(test);
            //-----Test voiture---
            //vehicule v1 = new voiture();
            //v1.afficherInfos();

          //  string path = "C:/Users/mancu/OneDrive - Campus Rene Cassin/EPSI/B2/Langage C#/Tp Garage/Tp Garage/saveFic.bin";


            garage ChezBernard = new garage();

          //  ChezBernard.ajouterVehicule(2);


            //ChezBernard.triVehicules();
            //ChezBernard.afficherVehicules();

           // ChezBernard.enregistrer(ChezBernard.vehiculesGarage, path);

            //ChezBernard.supprimerVehicule();
            //Console.WriteLine();
            //Console.WriteLine();

         //   ChezBernard.supprimerVehicule();

            //Console.WriteLine();
            //Console.WriteLine();

            // ChezBernard.afficherVehicules();
            // outputManager.displaySeparator();
            //List<int> test = new List<int>();

            //foreach(int testc in test)
            //{
            //    outputManager.displaySeparator();
            //}

        //    ChezBernard.vehiculesGarage = ChezBernard.charger<List<vehicule>>(path);

            Menu _menu = new Menu(ChezBernard);


        }
    }
}