namespace _29_01_2026_DigitalisNyomozas;

class Program
{
    static List<Evidence> evidences = new List<Evidence>();
    
    static void EvidenceManager()
    {
        
        Console.Clear();
        Console.WriteLine("1. Bizonyíték hozzáadása");
        Console.WriteLine("2. Bizonyíték törlése");
        Console.WriteLine("3. Listázás");

        string opcio = Console.ReadLine();
        
        switch (opcio)
        {
            
            case "1":
                
                Console.Write("Adja meg a bizonyíték azonosítóját: ");
                string azonosito = Console.ReadLine();

                Console.Write("Adja meg a bizonyíték típusát: ");
                string tipus = Console.ReadLine();

                Console.Write("Adja meg a bizonyíték leírását: ");
                string leiras = Console.ReadLine();

                Console.Write("Adja meg a bizonyíték megbízhatóságát: ");
                int megbizhatosag = int.Parse(Console.ReadLine());
                
                evidences.Add(new Evidence(azonosito, tipus, leiras, megbizhatosag));
                
                break;
            
            case "2":

                Console.Write("Melyik azonosítójú bizonyítékot szeretné törölni? ");
                azonosito = Console.ReadLine();


                foreach (Evidence evidence in evidences)
                {
                    if (evidence.Azonosito  == azonosito)
                    {
                        Console.WriteLine("A bizonyíték törtése megtörtént!");
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen bizonyíték");
                    }

                    
                }
                evidences.RemoveAll(e => e.Azonosito == azonosito);
                
                Console.WriteLine("Nyomjon meg egy gombot a folytatáshoz");
                Console.ReadKey();
                break;

            case "3":
                
                Console.WriteLine($"Lista elemszáma: {evidences.Count}");

                foreach (Evidence evidence in evidences)
                {
                    Console.WriteLine(evidence);
                }

                Console.WriteLine("Nyomjon egy gombot a folytatáshoz!");
                Console.ReadKey();
                
                break;
        }

        
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1. Ügyek kezelése");
        Console.WriteLine("2. Személyek kezelése");
        Console.WriteLine("3. Bizonyítékok kezelése");
        Console.WriteLine("4. Idővonal megtekintése");
        Console.WriteLine("5. Elemzések / döntések");
        Console.WriteLine("6. Kilépés");

    }
    
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<string> opciok = ["1", "2", "3", "4", "5", "6"];

        // string menu_be = Console.ReadLine();
        //
        // do
        // {
        //     menu_be = Console.ReadLine();
        // } while (!opciok.Contains(menu_be));
        //
        // Console.Clear();

        string menuBe = "";
        
        do
        {
            Menu();
            menuBe = Console.ReadLine();
        
             
            switch (menuBe)
            {
                case "3":
                    EvidenceManager();
                    break;
                
                default:
                    Console.WriteLine("Hibás input!");
                    break;
                    
            }
        
        } while (menuBe != "6");
        
        
        Console.WriteLine(menuBe);
        
        
        
    }
}