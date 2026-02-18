namespace _29_01_2026_DigitalisNyomozas;

class Program
{
    private static List<Evidence> evidences = new List<Evidence>();
    private static List<Case> cases = new List<Case>();
    private static List<Person> persons = new List<Person>();
    private static List<Suspect> suspects = new List<Suspect>();
    private static List<User> users = new List<User>();
    private static List<Witness> witnesses = new List<Witness>();

    static void AdatokFeltoltese()
    {
        evidences.Add(new Evidence("teszt1", "fotó", "teszt1", 10));
        cases.Add(new Case("teszt1", "teszt1", "teszt1", "teszt1"));
        persons.Add(new Person("pteszt1", 20, "pteszt1"));
        suspects.Add(new Suspect("steszt1", 20, "steszt1", 10, "őrizetben"));
        witnesses.Add(new Witness("wteszt1",  20, "wteszt1", "látta a bűnt", "18/02/2026"));
        users.Add(new User("teszt1", "teszt1", "nyomozo"));
    }

    static void Wait()
    {
        Console.WriteLine("Nyomjon egy gombot a folytatáshoz!");
        Console.ReadKey();
    }
    
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
        Console.WriteLine("3. Bizonyítékok hozzárendelése");
        Console.WriteLine("4. Személyek hozzárendelése");

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

                    foreach (Case elem in cases)
                    {
                        Console.WriteLine(elem.ToString());
                    }
                    
                    Wait();
                }
                else
                {
                    Console.WriteLine("Nincs semmilyen ügy");
                    Wait();
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
                        Wait();
                    }
                    else
                    {
                        Console.WriteLine("Nincs ilyen bizonyíték");
                        Wait();
                    }

                    
                }
                break;
            
            case "4":
                Console.WriteLine("Melyik ügyhöz szeretne hozzáadni a személyt? (azonosító)");
                ugyAzonosito = Console.ReadLine();

                ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                while (ugy == null)
                {
                    Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                    ugyAzonosito = Console.ReadLine();
                    ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                }

                Console.WriteLine("Milyen típusú személyt szeretne hozzáadni?");
                Console.WriteLine("1. Tanú");
                Console.WriteLine("2. Gyanúsított");
                string valasz = Console.ReadLine();

                switch (valasz)
                {
                    case "1":
                        Console.WriteLine("Melyik személyt szeretné hozzáadni? (név)");
                        string tanuNev = Console.ReadLine();
                        
                        Witness witness = witnesses.FirstOrDefault(p => p.Nev == tanuNev);
                        
                        while (witness == null)
                        {
                            Console.WriteLine("Nem létezik ilyen személy, adjon meg egy másikat");
                            tanuNev = Console.ReadLine();
                            witness = witnesses.FirstOrDefault(p => p.Nev == tanuNev);
                        
                        }
                        
                        ugy.AddWitness(witness);
                        break;
                    
                    case "2":
                        Console.WriteLine("Melyik személyt szeretné hozzáadni? (név)");
                        string gyanusitottNev = Console.ReadLine();
                    
                        Suspect suspect = suspects.FirstOrDefault(p => p.Nev == gyanusitottNev);
                    
                        while (suspect == null)
                        {
                            Console.WriteLine("Nem létezik ilyen személy, adjon meg egy másikat");
                            gyanusitottNev = Console.ReadLine();
                            suspect = suspects.FirstOrDefault(p => p.Nev == gyanusitottNev);
                        
                        }
                    
                        ugy.AddSuspect(suspect);
                        break;
                        
                }
                    
                
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
        AdatokFeltoltese();
        
        
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
                case "1":
                    CaseManager();
                    break;
                
                case "3":
                    EvidenceManager();
                    break;
                
                case "6":
                    Console.WriteLine("Viszlát");
                    break;
                
                default:
                    Console.WriteLine("Hibás input!");
                    break;
                    
            }
        
        } while (menuBe != "6");
        
        
        Console.WriteLine(menuBe);
        
        
        
    }
}