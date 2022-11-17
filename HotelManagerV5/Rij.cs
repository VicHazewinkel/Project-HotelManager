using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerV5
{
    internal class Rij <T>
        //
        // Toevoegen Functie om Namen Toe te voegen aan lijst van geinteresserden Voor een activiteit 
        //
    {
        private List<T> rij = new List<T>();
        private T huidige;

        public T InRijToevoegen(T element)
        {
            rij.Add(element);
            if (this.rij.Count == 1)
            {
                huidige = element;
            }
            return huidige;
        }

        public int Count()
        {
            return rij.Count;
        }
        public T HuidigElement()
        {
            return huidige;
        }
    }


}
