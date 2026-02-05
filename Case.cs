namespace _29_01_2026_DigitalisNyomozas;

internal class Case
{

    private string ugyAzonosito;
    private string cim;
    private string leiras;
    private string allapot;
    private List<Person> szemelyek = new List<Person>();
    private List<Evidence> bizonyitekok = new List<Evidence>();
    

    public Case(string ugyAzonosito, string cim, string leiras, string allapot)
    {
        this.ugyAzonosito = ugyAzonosito;
        this.cim = cim;
        this.leiras = leiras;
        this.allapot = allapot;
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

    public void AddEvidence(Evidence evidence)
    {
        bizonyitekok.Add(evidence);
    }

    public void AddPerson(Person person)
    {
        szemelyek.Add(person);
    }
    
    
    public override string ToString()
    {
        return $"azonosító: {ugyAzonosito}, cím: {cim}, leírás: {leiras}, állapot: {allapot} " +
               $"\n személyek: {szemelyek} \n bizonyitekok: {bizonyitekok}";
    }
}