namespace _29_01_2026_DigitalisNyomozas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Ügyek kezelése");
        Console.WriteLine("2. Személyek kezelése");
        Console.WriteLine("3. Bizonyítékok kezelése");
        Console.WriteLine("4. Idővonal megtekintése");
        Console.WriteLine("5. Elemzések / döntések");
        Console.WriteLine("6. Kilépés");

        List<string> opciok = ["1", "2", "3", "4", "5", "6"];

        string menu_be = Console.ReadLine();
        
        do
        {
            menu_be = Console.ReadLine();
        } while (!opciok.Contains(menu_be));
        
        Console.Clear();
        
        Console.WriteLine(menu_be);
        
        
        
    }
}