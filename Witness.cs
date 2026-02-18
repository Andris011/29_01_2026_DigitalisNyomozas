namespace _29_01_2026_DigitalisNyomozas;

public class Witness : Person
{
    private string vallomas;
    private string datum;

    public Witness(string nev, int eletkor, string megjegyzes, string vallomas, string datum) : base(nev, eletkor, megjegyzes)
    {
        this.vallomas = vallomas;
        this.datum = datum;
    }

    public string Vallomas
    {
        get => vallomas;
        set => vallomas = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Datum
    {
        get => datum;
        set => datum = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return base.ToString() + $" ,vallomás: {vallomas}, dátum: {datum}";
    }
}