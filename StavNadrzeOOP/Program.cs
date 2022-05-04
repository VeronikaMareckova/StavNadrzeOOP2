using System;

namespace StavNadrzeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Nadrz NadrzBeznehoAuta = new Nadrz();
            Console.WriteLine(NadrzBeznehoAuta.GetObjem());

            Nadrz NadrzAuta = new Nadrz(500);
            Console.WriteLine(NadrzAuta.GetObjem());

         /*
         * atrituby
         * Get metody (stav objem)
         * metody PRIDEJ ODEBER
         *  
         *  metoda  PRIDEJ overi podminkou zda se vejde  polivo do nadrze
         *  metoda  ODEBER overi podminkou zda jde pozadovane mnozsvi odebrat
         * 
         * Konstruktor 
         * pozn. na zacatku neni OBJEKT nastaven.
         * pozn. Konstruktor pomaha OBJEKT inicializovat (pomaha objekt vytvaret)
         */

        }
    }
}
