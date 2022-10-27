using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventoryConsoleApp
{
    public class Ghiozdan
    {
        public static float NR_CURENT_ARTICOLE;
        public static float NR_TOTAL_ARTICOLE = 15;

        public static float GREUTATE_CURENTA;
        public static float GREUTATE_TOTAL_ADMISA = 15;

        public static float VOLUM_CURENT;
        public static float VOLUM_TOTAL_ADMIS = 25;

        public static List<ArticolInventar> listaArticole = new List<ArticolInventar>();
        public bool Adauga(ArticolInventar articol)
        {
            if (NR_CURENT_ARTICOLE + articol.cantitate > NR_TOTAL_ARTICOLE)
            {
                Console.WriteLine($"EROARE: Se incalca numarul maxim de articole acceptate in ghiozdan. \n (!) Numarul de articole curente din ghiozdan fiind de {NR_CURENT_ARTICOLE}, iar maximul este de {NR_TOTAL_ARTICOLE} \n");
                return false;
            }
            else if(articol.greutate + GREUTATE_CURENTA > GREUTATE_TOTAL_ADMISA)
            {
                Console.WriteLine($"EROARE: Se incalca greutatea maxima acceptata in ghiozdan. \n (!) Greutatea acestuia fiind de {GREUTATE_CURENTA}, iar maximul este de {GREUTATE_TOTAL_ADMISA} \n");
                return false;
            }
            else if(articol.volum + VOLUM_CURENT > VOLUM_TOTAL_ADMIS)
            {
                Console.WriteLine($"EROARE: Se incalca volumul maxim acceptat in ghiozdan. \n (!) Volumul acestuia fiind de {VOLUM_CURENT}, iar maximul este de {VOLUM_TOTAL_ADMIS} \n");
                return false;
            }
            else
            {
                NR_CURENT_ARTICOLE += articol.cantitate;
                GREUTATE_CURENTA += articol.greutate;
                VOLUM_CURENT += articol.volum;
                listaArticole.Add(articol);
                Console.WriteLine($"A fost adaugat cu succes in ghiozdan {articol.GetType().Name}, cu greutatea = {articol.greutate} si volum = {articol.volum}");
                return true;
            }

        }

        public void AfisareGhiozdan()
        {
            Console.WriteLine("\n In ghiozdan sunt [ "+NR_CURENT_ARTICOLE + " / " + NR_TOTAL_ARTICOLE + " ] articole, greutatea de [ "+GREUTATE_CURENTA + " / " + GREUTATE_TOTAL_ADMISA + " ] avand volumul de [ " + VOLUM_CURENT + " / " + VOLUM_TOTAL_ADMIS + " ] \n");


        }

        public void AfisareArticoleDinGhiozdan()
        {
            foreach (var item in listaArticole)
            {
                Console.WriteLine($"Nume articol: [ {item.GetType().Name} ], Greutate: [ {item.greutate} ], Volum: [ {item.volum} ]   \n");
            }

        }

        public void FullReset()
        {
            Console.WriteLine($"(!) Ghiozdanul a fost resetat cu succes.");
            NR_CURENT_ARTICOLE = 0;
            GREUTATE_CURENTA = 0;
            VOLUM_CURENT = 0;
            listaArticole.Clear();
        }

        public void Bonus()
        {
            Console.WriteLine($"(!) Curios de fel? Ma bucur, bonusul consta in faptul ca valorile maxime pentru articole, greutate si volum care sunt limitele ghiozdanului au fost actualizate aleator. \n");
            Random rnd = new Random();
            NR_TOTAL_ARTICOLE = rnd.Next(1, 71);
            GREUTATE_TOTAL_ADMISA = rnd.Next(1, 73);
            VOLUM_TOTAL_ADMIS = rnd.Next(1, 79);
        }

        public void SetMaxArt(float cant)
        {
            NR_TOTAL_ARTICOLE = cant;
        }

        public void SetMaxGr(float cant)
        {
            GREUTATE_TOTAL_ADMISA = cant;
        }

        public void SetMaxVol(float cant)
        {
            VOLUM_TOTAL_ADMIS = cant;
        }





    }

    

    
}


