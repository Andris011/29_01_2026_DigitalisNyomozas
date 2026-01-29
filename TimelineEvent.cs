namespace _29_01_2026_DigitalisNyomozas;

public class TimelineEvent
{
    private string datum;
    private string leiras;

    public TimelineEvent(string datum, string leiras)
    {
        this.datum = datum;
        this.leiras = leiras;
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
}