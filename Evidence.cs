namespace _29_01_2026_DigitalisNyomozas;

public class Evidence
{
    private string azonosito;
    private string tipus;
    private string leiras;
    private int megbizhatosag;

    public Evidence(string azonosito, string tipus, string leiras, int megbizhatosag)
    {
        this.azonosito = azonosito;
        this.tipus = tipus;
        this.leiras = leiras;
        this.megbizhatosag = megbizhatosag;
    }

    public string Azonosito
    {
        get => azonosito;
        set => azonosito = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Tipus
    {
        get => tipus;
        set => tipus = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Leiras
    {
        get => leiras;
        set => leiras = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Megbizhatosag
    {
        get => megbizhatosag;
        set => megbizhatosag = value;
    }

    public override string ToString()
    {
        return $"Azonosító: {azonosito} Megbízhatóság: {megbizhatosag} Típus: {tipus} Leírás: {leiras}";
    } 
}