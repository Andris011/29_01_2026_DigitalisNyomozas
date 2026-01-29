namespace _29_01_2026_DigitalisNyomozas;

public class Suspect
{
    private List<Person> person;
    private int szint;
    private string status;

    public Suspect(List<Person> person, int szint, string status)
    {
        this.person = person;
        this.szint = szint;
        this.status = status;
    }

    public List<Person> Person
    {
        get => person;
        set => person = value ?? throw new ArgumentNullException(nameof(value));
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
    
    
}