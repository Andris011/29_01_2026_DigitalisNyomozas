namespace _29_01_2026_DigitalisNyomozas;

class Program
{
    private static List<Evidence> evidences = new List<Evidence>();
    private static List<Case> cases = new List<Case>();
    private static List<Person> _persons = new List<Person>();
    
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
                

                if (evidences.Count > 0)
                    foreach (Evidence evidence in evidences)
                    {
                        Console.WriteLine(evidence);
                    }

                else
                {
                    Console.WriteLine("Nincs semmilyen bizonyíték");
                }

                Console.WriteLine("Nyomjon egy gombot a folytatáshoz!");
                Console.ReadKey();
                
                break;
        }

        
    }

    static void CaseManager()
    {
        Console.Clear();
        Console.WriteLine("1. Új ügy létrehozása");
        Console.WriteLine("2. Ügyyek listázása");
        Console.WriteLine("3. Személyek hozzárendelése");
        Console.WriteLine("4. Bizonyítékok hozzárendelése");
        
        string opcio = Console.ReadLine();
        
        switch (opcio)
        {
            case "1":
                Console.WriteLine("Ügy azonosítója: ");
                string ugyAzonosito = Console.ReadLine();

                Console.WriteLine("Cím: ");
                string cim = Console.ReadLine();

                Console.WriteLine("Leírás: ");
                string leiras = Console.ReadLine();

                Console.WriteLine("Állapot: ");
                string allapot = Console.ReadLine();
                
                
                cases.Add(new Case(ugyAzonosito, cim, leiras, allapot));
                break;
            
            case "2":

                if (cases.Count > 0)
                {
                    Console.WriteLine(cases);
                }
                else
                {
                    Console.WriteLine("Nincs semmilyen ügy");
                }
                break;
            
            case "3":

                Console.WriteLine("Melyik ügyhöz szeretne hozzáadni bizonyítékot? (azonosító)");
                ugyAzonosito = Console.ReadLine();

                Case ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                while (ugy == null)
                {
                    Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                    ugyAzonosito = Console.ReadLine();
                    ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                }
                
                
                Console.WriteLine("Melyik bizonyítékot szertné hozzáadni? (azonosító)");
                string bizAzonosito = Console.ReadLine();
                
                foreach (Evidence evidence in evidences)
                {
                    if (evidence.Azonosito  == bizAzonosito)
                    {
                        Console.WriteLine("A bizonyíték hozzáadása megtörtént!");
                        ugy.AddEvidence(evidence);
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen bizonyíték");
                    }

                    
                }
                break;
            
            case "4":
                Console.WriteLine("Melyik ügyhöz szeretne hozzáadni bizonyítékot? (azonosító)");
                ugyAzonosito = Console.ReadLine();

                ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                while (ugy == null)
                {
                    Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                    ugyAzonosito = Console.ReadLine();
                    ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                }
                
                Console.WriteLine("Melyik személyt szeretné hozzáadni? (név)");
                string szemelyNev = Console.ReadLine();
                
                Person szemely = _persons.FirstOrDefault(p => p.Nev == szemelyNev);
                
                while (szemely == null)
                {
                    Console.WriteLine("Nem létezik ilyen személy, adjon meg egy másikat");
                    szemelyNev = Console.ReadLine();
                    szemely = _persons.FirstOrDefault(p => p.Nev == szemelyNev);
                    
                }
                
                ugy.AddPerson(szemely);
                
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
        evidences.Add(new Evidence("teszt1", "teszt1", "teszt1", 2));
        
        
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