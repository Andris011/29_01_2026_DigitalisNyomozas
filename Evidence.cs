namespace _29_01_2026_DigitalisNyomozas;

public class Evidence
{
    private string azonosito;
    private string tipus;
    private string liras;
    private int megbizhatosag;

    public Evidence(string azonosito, string tipus, string liras, int megbizhatosag)
    {
        this.azonosito = azonosito;
        this.tipus = tipus;
        this.liras = liras;
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

    public string Liras
    {
        get => liras;
        set => liras = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Megbizhatosag
    {
        get => megbizhatosag;
        set => megbizhatosag = value;
    }
}