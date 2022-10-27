
namespace GameInventoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("\n\n Alege o optiune:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("GHIOZDAN: ");
            Console.WriteLine("1) Afisare ghiozdan");
            Console.WriteLine("2) Afisare articole din ghiozdan");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("ARTICOLE: ");
            Console.WriteLine("3) Adaugare o [ Sageata ] in ghiozdan");
            Console.WriteLine("4) Adaugare un [ Arc ] in ghiozdan");
            Console.WriteLine("5) Adaugare o [ Franghie ] in ghiozdan");
            Console.WriteLine("6) Adaugare o [ Apa ] in ghiozdan");
            Console.WriteLine("7) Adaugare o [ Portie de mancare ] in ghiozdan");
            Console.WriteLine("8) Adaugare o [ Sabie ] in ghiozdan");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DEBUG: ");
            Console.WriteLine("9) Resetare valori curente [ Ghiozdan ]");
            Console.WriteLine("10) Setare valoare maxima pentru numar articole din [ Ghiozdan ]");
            Console.WriteLine("11) Setare valoare maxima pentru greutatea [ Ghiozdan ]");
            Console.WriteLine("12) Setare valoare maxima pentru volumul [ Ghiozdan ]");
            Console.WriteLine("13) BONUS");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nOptiunea selectata este: ");
            
            Ghiozdan ghiozdan = new Ghiozdan();

            



            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    ghiozdan.AfisareGhiozdan();
                    return true;
                case "2":
                    ghiozdan.AfisareArticoleDinGhiozdan();
                    return true;
                case "3":
                    ghiozdan.Adauga(new Sageata());
                    return true;
                case "4":
                    ghiozdan.Adauga(new Arc());
                    return true;
                case "5":
                    ghiozdan.Adauga(new Franghie());
                    return true;
                case "6":
                    ghiozdan.Adauga(new Apa());
                    return true;
                case "7":
                    ghiozdan.Adauga(new PortieMancare());
                    return true;
                case "8":
                    ghiozdan.Adauga(new Sabie());
                    return true;
                case "9":
                    ghiozdan.FullReset();
                    return true;
                case "10":
                    ghiozdan.SetMaxArt(CaptureInput());
                    return true;
                case "11":
                    ghiozdan.SetMaxGr(CaptureInput());
                    return true;
                case "12":
                    ghiozdan.SetMaxVol(CaptureInput());
                    return true;
                case "13":
                    ghiozdan.Bonus();
                    return true;

                default:
                    return true;
            }
        }

        private static float CaptureInput()
        {
            Console.Write("Introdu valoarea dorita: ");
            float value = Single.Parse(Console.ReadLine());
            return value;
        }
    }
}