using System;
using System.Collections.Generic;
using System.Text;

namespace StavNadrzeOOP
{
    class Nadrz
    {
        //atributy
        private uint objem; //kolik se vejde
        uint stav; //private  // kolik paliva je v nadrzi

        //Konstruktor
        public Nadrz()
        {
            this.objem = 50;
            stav = 0;
        }
        //konstruktor - pretizeni metody
        public Nadrz(uint novyObjem)
        {
            this.objem = novyObjem;
            stav = 0;
        }

        //Get metody
        public uint GetStav()
        {
            return stav;
        }

        public uint GetObjem()
        {
            return objem;
        }

        //Metody
       public void Pridej(uint kolik)
        {
            if (stav + kolik > objem)
                return; //dalsi kod v metode se dal neprovede

            stav = stav + kolik; //stav += kolik;
        }
                
        public void Odeber(uint kolik)
        {
            if (stav < kolik)
                return;
            stav = stav - kolik; //stav -= kolik;
        }

    }
}
