namespace _29_01_2026_DigitalisNyomozas;

internal class Case
{

    private string ugyAzonosito;
    private string cim;
    private string leiras;
    private string allapot;
    private string szemelyek;
    private string bizonyitekok;

    public Case(string ugyAzonosito, string cim, string leiras, string allapot, string szemelyek, string bizonyitekok)
    {
        this.ugyAzonosito = ugyAzonosito;
        this.cim = cim;
        this.leiras = leiras;
        this.allapot = allapot;
        this.szemelyek = szemelyek;
        this.bizonyitekok = bizonyitekok;
    }
    
    public string UgyAzonosito
    {
        get => ugyAzonosito;
        set => ugyAzonosito = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Cim
    {
        get => cim;
        set => cim = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Leiras
    {
        get => leiras;
        set => leiras = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Allapot
    {
        get => allapot;
        set => allapot = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Szemelyek
    {
        get => szemelyek;
        set => szemelyek = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Bizonyitekok
    {
        get => bizonyitekok;
        set => bizonyitekok = value ?? throw new ArgumentNullException(nameof(value));
    }

}