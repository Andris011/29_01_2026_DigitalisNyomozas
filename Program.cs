namespace _29_01_2026_DigitalisNyomozas;

class Program
{
    private static List<Evidence> evidences = new List<Evidence>();
    private static List<Case> cases = new List<Case>();
    private static List<Person> persons = new List<Person>();
    private static List<Suspect> suspects = new List<Suspect>();
    private static List<User> users = new List<User>();
    private static List<Witness> witnesses = new List<Witness>();
    private static List<TimelineEvent> timelineEvents = new List<TimelineEvent>();

    static void AdatokFeltoltese()
    {
        evidences.Add(new Evidence("teszt1", "fotó", "teszt1", 10));
        cases.Add(new Case("teszt1", "teszt1", "teszt1", "teszt1"));
        persons.Add(new Person("pteszt1", 20, "pteszt1"));
        suspects.Add(new Suspect("steszt1", 20, "steszt1", 10, "őrizetben"));
        witnesses.Add(new Witness("wteszt1",  20, "wteszt1", "látta a bűnt", "18/02/2026"));
        users.Add(new User("teszt1", "teszt1", "nyomozo"));
        timelineEvents.Add(new TimelineEvent("teszt1","18/02/2026", "unatkozás"));
    }

    public static void Wait()
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
        Console.WriteLine("4. Vissza");

        string opcio = Console.ReadLine();

        Console.Clear();
        
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

                Console.Write("Melyik azonosítójú bizonyítékot szeretné törölni?          [V]issza \n");
                Console.WriteLine(string.Join("\n", evidences));
                azonosito = Console.ReadLine();


                foreach (Evidence evidence in evidences)
                {
                    if (evidence.Azonosito  == azonosito)
                    {
                        Console.WriteLine("A bizonyíték törtése megtörtént!");
                        Thread.Sleep(1000);
                    }
                    else if (azonosito == "v" || azonosito == "V") Console.WriteLine();
                    else
                    {
                        Console.WriteLine("Nincs ilyen bizonyíték");
                    }

                    
                }
                evidences.RemoveAll(e => e.Azonosito == azonosito);
                
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
            
            case "4":
                break;
            
            default:
                Console.WriteLine("Hibás input!");
                break;
        }
            
        
    }

    static void CaseManager()
    {
        string opcio;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Új ügy létrehozása");
            Console.WriteLine("2. Ügyyek listázása");
            Console.WriteLine("3. Bizonyítékok hozzárendelése");
            Console.WriteLine("4. Személyek hozzárendelése");
            Console.WriteLine("5. Ügy állapotának módosítása");
            Console.WriteLine("6. Vissza");

            opcio = Console.ReadLine();
            
            Console.Clear();

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
                    Console.WriteLine(string.Join("\n", cases));
                    
                    ugyAzonosito = Console.ReadLine();

                    Case ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                    while (ugy == null)
                    {
                        Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                        ugyAzonosito = Console.ReadLine();
                        ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                    }


                    Console.WriteLine("Melyik bizonyítékot szertné hozzáadni? (azonosító)          [V]issza");
                    Console.WriteLine(string.Join("\n", evidences));
                    
                    string bizAzonosito = Console.ReadLine();

                    foreach (Evidence evidence in evidences)
                    {
                        if (evidence.Azonosito == bizAzonosito)
                        {
                            Console.WriteLine("A bizonyíték hozzáadása megtörtént!");
                            ugy.AddEvidence(evidence);
                            Wait();
                        }
                        else if (bizAzonosito == "v" || bizAzonosito == "V") Console.WriteLine();
                        else
                        {
                            Console.WriteLine("Nincs ilyen bizonyíték");
                            Wait();
                        }


                    }

                    break;

                case "4":
                    Console.WriteLine("Melyik ügyhöz szeretne hozzáadni a személyt? (azonosító)");
                    Console.WriteLine(string.Join("\n", cases));
                    ugyAzonosito = Console.ReadLine();

                    ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                    while (ugy == null)
                    {
                        Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                        ugyAzonosito = Console.ReadLine();
                        ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                    }
                    
                    Console.Clear();
                    Console.WriteLine("Milyen típusú személyt szeretne hozzáadni?");
                    Console.WriteLine("1. Tanú");
                    Console.WriteLine("2. Gyanúsított");
                    Console.WriteLine("3. Vissza");
                    string valasz = Console.ReadLine();
                    Console.Clear();

                    switch (valasz)
                    {
                        case "1":
                            Console.WriteLine("Melyik tanút szeretné hozzáadni? (név)          [V]issza");
                            Console.WriteLine(string.Join("\n", witnesses));
                            string tanuNev = Console.ReadLine();

                            if (tanuNev != "v" && tanuNev != "V")
                            {
                                Witness witness = witnesses.FirstOrDefault(p => p.Nev == tanuNev);

                                while (witness == null)
                                {
                                    Console.WriteLine("Nem létezik ilyen személy, adjon meg egy másikat");
                                    tanuNev = Console.ReadLine();
                                    witness = witnesses.FirstOrDefault(p => p.Nev == tanuNev);

                                }

                                ugy.AddWitness(witness);
                            }

                            break;

                        case "2":
                            Console.WriteLine("Melyik gyanúsítottat szeretné hozzáadni? (név)          [V]issza");
                            Console.WriteLine(string.Join("\n", suspects));
                            string.Join("\n", suspects);
                            string gyanusitottNev = Console.ReadLine();

                            if (gyanusitottNev != "v" && gyanusitottNev != "V")
                            {
                                Suspect suspect = suspects.FirstOrDefault(p => p.Nev == gyanusitottNev);

                                while (suspect == null)
                                {
                                    Console.WriteLine("Nem létezik ilyen gyanúsított, adjon meg egy másikat");
                                    gyanusitottNev = Console.ReadLine();
                                    suspect = suspects.FirstOrDefault(p => p.Nev == gyanusitottNev);

                                }

                                suspect.Szint += ugy.Bizonyitekok.Count;

                                if (suspect.Szint > 100)
                                {
                                    Console.WriteLine("A gyanusított szintje a bizonyítékok száma miatt meghaladná" +
                                                      " a 100-at, így értéke 100 marad"
                                    );
                                    
                                    suspect.Szint = 100;
                                    
                                    Wait();
                                }

                                ugy.AddSuspect(suspect);
                            }

                            break;
                        
                        case "3":
                            break;
                        
                        default:
                            Console.WriteLine("Hibás input!");
                            Thread.Sleep(1000);
                            break;

                    }


                    break;
                
                case "5":
                    Console.Clear();
                    Console.WriteLine("Melyik ügynek szeretné módosítani az állapotát? (azonosító)");
                    Console.WriteLine(string.Join("\n", cases));
                    ugyAzonosito = Console.ReadLine();

                    ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);

                    while (ugy == null)
                    {
                        Console.WriteLine("Nincs ilyen ügy, adjon meg egy másikat!");
                        ugyAzonosito = Console.ReadLine();
                        ugy = cases.FirstOrDefault(c => c.UgyAzonosito == ugyAzonosito);
                    }

                    Console.WriteLine("Mire szeretné változtatni?");
                    ugy.Status(Console.ReadLine());
                    
                    
                    break;
                
                case "6":
                    break;
                
                default:
                    Console.WriteLine("Hibás input!");
                    Thread.Sleep(1000);
                    break;

            }
        } while (opcio != "6");
    }

    static void PersonManager()
    {
        string opcio;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Személy hozzáadása");
            Console.WriteLine("2. Személy törlése");
            Console.WriteLine("3. Listázás");
            Console.WriteLine("4. Vissza");
            
            opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Milyen típusú személyt szeretne hozzáadni?");
                    Console.WriteLine("1. Tanú");
                    Console.WriteLine("2. Gyanúsított");
                    Console.WriteLine("3. Vissza");
                    string valasz = Console.ReadLine();

                    switch (valasz)
                    {
                        case "1":
                            Console.Clear();
                            Console.Write("Név: ");
                            string wnev = Console.ReadLine();
                            
                            Console.Write("Életkor: ");
                            int weletkor = int.Parse(Console.ReadLine());

                            Console.Write("Megjegyzés: ");
                            string wmegjegyzes = Console.ReadLine();
                            
                            Console.Write("Vallomás: ");
                            string wvallomas = Console.ReadLine();
                            
                            Console.Write("Dátum: ");
                            string wdatum = Console.ReadLine();
                            
                            witnesses.Add(new Witness(wnev, weletkor, wmegjegyzes, wvallomas, wdatum));
                            
                            break;
                        
                            case "2":
                                Console.Clear();
                                Console.Write("Név: ");
                                string snev = Console.ReadLine();
                                
                                Console.Write("Életkor: ");
                                int seletkor = int.Parse(Console.ReadLine());

                                Console.Write("Megjegyzés: ");
                                string smegjegyzes = Console.ReadLine();

                                int sszint;

                                do
                                {
                                    Console.Write("Szint: ");
                                    sszint = int.Parse(Console.ReadLine());

                                    if (sszint > 100)
                                    {
                                        Console.WriteLine("Az érték nem lehet nagydobb mint 100!");
                                        Thread.Sleep(1000);
                                    }
                                } while (sszint > 100);

                                Console.WriteLine("Státusz: ");
                                string sstatusz = Console.ReadLine();
                                
                                
                                suspects.Add(new Suspect(snev, seletkor, smegjegyzes, sszint, sstatusz));
                                
                                break;
                            }

                            break;
                    
                    
                    break;
                
                case "2":
                    Console.Clear();
                    Console.WriteLine("1. Tanú");
                    Console.WriteLine("2. Gyanúsított");
                    Console.WriteLine("3. Vissza");

                    string nev;
                    bool talalt;

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Melyik tanút szeretné törölni?          [V]issza \n");
                            Console.WriteLine(string.Join("\n", witnesses));
                            nev = Console.ReadLine();


                            foreach (Witness witness in witnesses)
                            {
                                if (witness.Nev  == nev)
                                {
                                    Console.WriteLine("A tanú törtése megtörtént!");
                                    talalt = true;
                                    Thread.Sleep(1000);
                                }
                                else if (nev == "v" || nev == "V") Console.WriteLine();
                                else
                                {
                                    Console.WriteLine("Nincs ilyen tanú");
                                }
                            }
                            
                            if (talalt = true) witnesses.RemoveAll(e => e.Nev == nev);
                            
                            break;
                        
                        case "2":
                            Console.Write("Melyik gyanúsítottat szeretné törölni?          [V]issza \n");
                            Console.WriteLine(string.Join("\n", suspects));
                            nev = Console.ReadLine();
                            

                            foreach (Suspect suspect in suspects)
                            {
                                if (suspect.Nev  == nev)
                                {
                                    Console.WriteLine("A gyanúsított törtése megtörtént!");
                                    talalt = true;
                                    Thread.Sleep(1000);
                                }
                                else if (nev == "v" || nev == "V") Console.WriteLine();
                                else
                                {
                                    Console.WriteLine("Nincs ilyen gyanúsított");
                                }
                            }
                            
                            if (talalt = true) suspects.RemoveAll(e => e.Nev == nev);
                            
                            break;
                    }
                    
                    break;
                
                case "3":
                    Console.Clear();
                    Console.WriteLine("1. Tanúk");
                    Console.WriteLine("2. Gyanúsítottak");
                    Console.WriteLine("3. Vissza");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (witnesses.Count > 0) Console.WriteLine(string.Join("\n", witnesses));
                            else Console.WriteLine("Nincs semmilyen tanú");
                            
                            Wait();
                            
                            break;
                        
                        case "2":
                            if (suspects.Count > 0) Console.WriteLine(string.Join("\n", suspects));
                            else Console.WriteLine("Nincs semmilyen gyanúsított");
                            
                            Wait();
                            
                            break;
                        
                        case "3":
                            break;
                        
                        default:
                            Console.WriteLine("Hibás input");
                            Thread.Sleep(1000);
                            break;
                        
                    }
                    
                    break;
                    
            }
            
        } while (opcio != "4");
    }

    static void TimeLineManager()
    {
        Console.Clear();
        
        Console.WriteLine("Melyik ügynek szeretné módosítani az idővonalát?");
        Console.WriteLine(string.Join("\n", cases));

        string azonosito;
        Case ugy;

        do
        {
            azonosito = Console.ReadLine();
            ugy = cases.FirstOrDefault(c => c.UgyAzonosito == azonosito);
            Console.WriteLine(ugy.ToString());
            
        } while (ugy == null);
        
        ugy.TimelineManager();
        
    }
    
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1. Ügyek kezelése");
        Console.WriteLine("2. Személyek kezelése");
        Console.WriteLine("3. Bizonyítékok kezelése");
        Console.WriteLine("4. Idővonalak kezelése");
        Console.WriteLine("5. Kilépés");

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
                
                case "2":
                    PersonManager();
                    break;
                
                case "3":
                    EvidenceManager();
                    break;
                
                case "4":
                    TimeLineManager();
                    break;
                
                case "5":
                    Console.WriteLine("Viszlát");
                    break;
                
                default:
                    Console.WriteLine("Hibás input!");
                    Thread.Sleep(1000);
                    break;
                    
            }
        
        } while (menuBe != "5");
    }
}