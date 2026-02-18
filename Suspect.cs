namespace _29_01_2026_DigitalisNyomozas;

public class Suspect : Person
{
    private int szint;
    private string status;

    public Suspect(string nev, int eletkor, string megjegyzes, int szint, string status) : base(nev, eletkor, megjegyzes)
    {
        this.szint = szint;
        this.status = status;
    }

    public int Szint
    {
        get => szint;
        set => szint = value;
    }

    public string Status
    {
        get => status;
        set => status = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return base.ToString() + $" ,szint: {szint}, status: {status}";
    }
}