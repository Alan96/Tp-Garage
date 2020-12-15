using System;

namespace Tp_Garage
{
    class Program
    {
        static void Main()
        {
            moteur test = new moteur();
            Console.WriteLine(test._puissance);
            Console.WriteLine(test._type);
            Console.ReadKey();
            vehicule ggre = new voiture();
            ggre.afficherInfos();

        }
    }
}
