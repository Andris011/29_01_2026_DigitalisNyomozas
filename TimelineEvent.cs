namespace _29_01_2026_DigitalisNyomozas;

public class TimelineEvent
{
    private string azonosito;
    private string datum;
    private string leiras;

    public TimelineEvent(string azonosito, string datum, string leiras)
    {
        this.azonosito = azonosito;
        this.datum = datum;
        this.leiras = leiras;
    }

    public string Azonosito
    {
        get => azonosito;
        set => azonosito = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Datum
    {
        get => datum;
        set => datum = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Leiras
    {
        get => leiras;
        set => leiras = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return $"\n Azonosító {azonosito}, dátum: {datum}, leíras: {leiras}";
    }
}