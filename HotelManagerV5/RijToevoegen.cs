using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelManagerV5
{
    internal class RijToevoegen
    {
        private int id; 
        private static int count = 0;
        private string Naam;


        // public even Toelichten
        // gebruikmakende van een Delegate
        public EventHandler Toelichten; 

        public RijToevoegen(string naam)
        { 
            this.Naam = naam;
            count++;
            id = count;
        }

        public override string ToString()
        {
            return (id + ", " + Naam); 
        }
    }
}
