namespace _29_01_2026_DigitalisNyomozas;

public class Witness
{
    private List<Person> person;
    private string vallomas;
    private string datum;

    public Witness(List<Person> person, string vallomas, string datum)
    {
        this.person = person;
        this.vallomas = vallomas;
        this.datum = datum;
    }

    public List<Person> Person
    {
        get => person;
        set => person = value ?? throw new ArgumentNullException(nameof(value));
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
}