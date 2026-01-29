namespace _29_01_2026_DigitalisNyomozas;

public class Person
{
    private string nev;
    private int eletkor;
    private string megjegyzes;

    public Person(string nev, int eletkor, string megjegyzes)
    {
        this.nev = nev;
        this.eletkor = eletkor;
        this.megjegyzes = megjegyzes;
    }

    public string Nev
    {
        get => nev;
        set => nev = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Eletkor
    {
        get => eletkor;
        set => eletkor = value;
    }

    public string Megjegyzes
    {
        get => megjegyzes;
        set => megjegyzes = value ?? throw new ArgumentNullException(nameof(value));
    }
}