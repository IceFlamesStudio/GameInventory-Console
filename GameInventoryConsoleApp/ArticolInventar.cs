using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventoryConsoleApp
{
    public class ArticolInventar
    {
        
        public float greutate { get; set; }
        public float volum { get; set; }
        public int cantitate { get; set; }

        public ArticolInventar(float gr, float vol)
        {
            this.greutate = gr;
            this.volum = vol;
            this.cantitate = 1;
        }

        public void AfisareInformatii()
        {

            Console.WriteLine($"Nume Articol: [ {this.GetType().Name} ], Greutate: [ {greutate} ], Volum: [ {volum} ] \n");
        }

    }
}


